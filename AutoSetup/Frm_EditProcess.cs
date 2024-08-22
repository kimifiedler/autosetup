using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSetup
{
    public partial class Frm_EditProcess : Form
    {
        private string ProcessName { get; set; }
        private string ProcessStatus { get; set; }

        private Frm_AutoSetup Frm_AutoSetup;

        public Frm_EditProcess(string processName, string processStatus, Frm_AutoSetup frm_AutoSetup)
        {
            InitializeComponent();
            ProcessName = processName;
            ProcessStatus = processStatus;
            Frm_AutoSetup = frm_AutoSetup;
        }

        private void Btn_ApplyChanges_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl.GetType() == typeof(RadioButton))
                {
                    RadioButton rb = ctrl as RadioButton;
                    if (rb.Checked)
                    {
                        if (rb.Text == "Open Process")
                        {
                            ProcessStatus = "Open";
                        }
                        else if (rb.Text == "Close Process")
                        {
                            ProcessStatus = "Close";
                        }
                        else if (rb.Text == "Minimize Process")
                        {
                            ProcessStatus = "Minimize";
                        }
                        break;
                    }
                }
            }
            Frm_AutoSetup.UpdateProcessStatus(ProcessName, ProcessStatus);
            Close();
        }

        private void Frm_EditProcess_Load(object sender, EventArgs e)
        {
            Txt_ProcessName.Text = ProcessName;
            if (ProcessStatus == "Open")
            {
                Opt_OpenProcess.Checked = true;
            }
            else if (ProcessStatus == "Close")
            {
                Opt_CloseProcess.Checked = true;
            }
            else if (ProcessStatus == "Minimize")
            {
                Opt_MinimizeProcess.Checked = true;
            }
        }
    }
}
