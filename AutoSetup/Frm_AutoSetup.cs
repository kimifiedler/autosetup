using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Configuration;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace AutoSetup
{
    public partial class Frm_AutoSetup : Form
    {
        public Frm_AutoSetup()
        {
            InitializeComponent();
        }

        private void Btn_AddProcess_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "C:\\",
                Title = "Select Process",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool uniqueFileName = true;
                foreach (ListViewItem listViewItem in Liv_Processes.Items)
                {
                    if (listViewItem.SubItems[0].Text == openFileDialog.FileName)
                    {
                        uniqueFileName = false;
                    }
                }
                if (uniqueFileName)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Open();

                        string query = string.Format("INSERT INTO Profile{0} (Name, Status) VALUES (\"{1}\", \"Open\")", Cmb_Profiles.SelectedIndex, openFileDialog.FileName);

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                    LoadDataIntoListView();
                }
            }
        }

        private void Btn_EditProcess_Click(object sender, EventArgs e)
        {
            if (Liv_Processes.SelectedItems.Count == 1)
            {
                Frm_EditProcess frmEditProcess = new Frm_EditProcess(Liv_Processes.SelectedItems[0].SubItems[0].Text, Liv_Processes.SelectedItems[0].SubItems[1].Text, this);
                frmEditProcess.ShowDialog();
             }
        }

        private void Btn_DeleteProcess_Click(object sender, EventArgs e)
        {
            if (Liv_Processes.SelectedItems.Count == 1)
            {
                using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                {
                    connection.Open();

                    string query = string.Format("DELETE FROM Profile{0} WHERE Name = \"{1}\";", Cmb_Profiles.SelectedIndex, Liv_Processes.SelectedItems[0].SubItems[0].Text);

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
                LoadDataIntoListView();
            }
        }

        public void UpdateProcessStatus(string processName, string processStatus)
        {
            foreach (ListViewItem item in Liv_Processes.Items)
            {
                if (item.SubItems[0].Text == processName)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
                    {
                        connection.Open();

                        string query = string.Format("UPDATE Profile{0} SET Status = \"{1}\" WHERE Name = \"{2}\";", Cmb_Profiles.SelectedIndex, processStatus, processName);

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                        connection.Close();
                    }
                    LoadDataIntoListView();
                }
            }
            LoadDataIntoListView();
        }

        private const int SW_MINIMIZE = 6;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private void Btn_ActivateSetup_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in Liv_Processes.Items)
            {
                if (listViewItem.SubItems[1].Text == "Open")
                {
                    using (Process process = new Process())
                    {
                        try
                        {
                            process.StartInfo.FileName = listViewItem.SubItems[0].Text;
                            process.Start();
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                else if (listViewItem.SubItems[1].Text == "Close")
                {
                    Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(listViewItem.SubItems[0].Text));
                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                }
                else if (listViewItem.SubItems[1].Text == "Minimize")
                {
                    Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(listViewItem.SubItems[0].Text));

                    if (processes.Length > 0)
                    {
                        foreach (var process in processes)
                        {
                            IntPtr mainWindowHandle = process.MainWindowHandle;
                            if (mainWindowHandle != IntPtr.Zero)
                            {
                                ShowWindow(mainWindowHandle, SW_MINIMIZE);
                            }
                        }
                    }
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        private void Cmb_Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataIntoListView();
        }

        private void LoadDataIntoListView()
        {
            Liv_Processes.Items.Clear();
             
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var sql = connection.CreateCommand();
                sql.CommandText = @"SELECT * FROM Profile" + Cmb_Profiles.SelectedIndex;

                using (SQLiteDataReader reader = sql.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string colName = reader["Name"].ToString();
                        string colStatus = reader["Status"].ToString();

                        ListViewItem item = new ListViewItem(colName);
                        item.SubItems.Add(colStatus);

                        Liv_Processes.Items.Add(item);
                    }
                }
                connection.Close();
            }
        }

        private void Frm_AutoSetup_Load(object sender, EventArgs e)
        {
            LoadTableNamesIntoCmb();
            if (Cmb_Profiles.Items.Count != 0)
            {
                Cmb_Profiles.SelectedIndex = 0;
                LoadDataIntoListView();
            }
        }

        private void LoadTableNamesIntoCmb()
        {
            Cmb_Profiles.Items.Clear();
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                string query = "SELECT name FROM sqlite_master WHERE type='table'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader.GetString(0);
                            Cmb_Profiles.Items.Add(tableName);
                        }
                    }
                }
            }
        }

        private void Btn_AddProfile_Click(object sender, EventArgs e)
        {
            Liv_Processes.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                string query = string.Format("CREATE TABLE \"Profile{0}\" (\r\n\t\"Name\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Status\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"Name\")\r\n)", Cmb_Profiles.Items.Count);

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            LoadTableNamesIntoCmb();
            Cmb_Profiles.SelectedIndex = Cmb_Profiles.Items.Count - 1;
        }

        private void Btn_DeleteProfile_Click(object sender, EventArgs e)
        {
            if (Cmb_Profiles.Items.Count != 1) 
            {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                string query = string.Format("DROP TABLE Profile{0}", Cmb_Profiles.SelectedIndex);

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            Cmb_Profiles.Items.Remove(Cmb_Profiles.SelectedIndex);
            RenameAllTables();
            LoadTableNamesIntoCmb();
            Cmb_Profiles.SelectedIndex = 0;
            }
        }

        private void RenameAllTables()
        {
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                string query = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        int index = 0;
                        while (reader.Read())
                        {
                            string oldTableName = reader.GetString(0);
                            string newTableName = $"Profile{index}";

                            RenameTable(oldTableName, newTableName, connection);

                            index++;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void RenameTable(string oldTableName, string newTableName, SQLiteConnection connection)
        {
            if (oldTableName != newTableName) 
            {
                string query = $"ALTER TABLE {oldTableName} RENAME TO {newTableName};";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
