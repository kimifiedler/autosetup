namespace AutoSetup
{
    partial class Frm_AutoSetup
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_AddProcess = new System.Windows.Forms.Button();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.Btn_EditProcess = new System.Windows.Forms.Button();
            this.Btn_DeleteProcess = new System.Windows.Forms.Button();
            this.Btn_ActivateSetup = new System.Windows.Forms.Button();
            this.Cmb_Profiles = new System.Windows.Forms.ComboBox();
            this.Btn_DeleteProfile = new System.Windows.Forms.Button();
            this.Btn_AddProfile = new System.Windows.Forms.Button();
            this.Liv_Processes = new System.Windows.Forms.ListView();
            this.Col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Btn_AddProcess
            // 
            this.Btn_AddProcess.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddProcess.Location = new System.Drawing.Point(27, 328);
            this.Btn_AddProcess.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_AddProcess.Name = "Btn_AddProcess";
            this.Btn_AddProcess.Size = new System.Drawing.Size(210, 28);
            this.Btn_AddProcess.TabIndex = 1;
            this.Btn_AddProcess.Text = "Add Process";
            this.Btn_AddProcess.UseVisualStyleBackColor = true;
            this.Btn_AddProcess.Click += new System.EventHandler(this.Btn_AddProcess_Click);
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Title.Location = new System.Drawing.Point(26, 9);
            this.Lbl_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(91, 21);
            this.Lbl_Title.TabIndex = 2;
            this.Lbl_Title.Text = "AutoSetup";
            // 
            // Btn_EditProcess
            // 
            this.Btn_EditProcess.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditProcess.Location = new System.Drawing.Point(256, 328);
            this.Btn_EditProcess.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_EditProcess.Name = "Btn_EditProcess";
            this.Btn_EditProcess.Size = new System.Drawing.Size(210, 28);
            this.Btn_EditProcess.TabIndex = 3;
            this.Btn_EditProcess.Text = "Edit Process";
            this.Btn_EditProcess.UseVisualStyleBackColor = true;
            this.Btn_EditProcess.Click += new System.EventHandler(this.Btn_EditProcess_Click);
            // 
            // Btn_DeleteProcess
            // 
            this.Btn_DeleteProcess.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteProcess.Location = new System.Drawing.Point(486, 328);
            this.Btn_DeleteProcess.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_DeleteProcess.Name = "Btn_DeleteProcess";
            this.Btn_DeleteProcess.Size = new System.Drawing.Size(210, 28);
            this.Btn_DeleteProcess.TabIndex = 4;
            this.Btn_DeleteProcess.Text = "Delete Process";
            this.Btn_DeleteProcess.UseVisualStyleBackColor = true;
            this.Btn_DeleteProcess.Click += new System.EventHandler(this.Btn_DeleteProcess_Click);
            // 
            // Btn_ActivateSetup
            // 
            this.Btn_ActivateSetup.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ActivateSetup.Location = new System.Drawing.Point(256, 366);
            this.Btn_ActivateSetup.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_ActivateSetup.Name = "Btn_ActivateSetup";
            this.Btn_ActivateSetup.Size = new System.Drawing.Size(210, 58);
            this.Btn_ActivateSetup.TabIndex = 5;
            this.Btn_ActivateSetup.Text = "Activate Setup";
            this.Btn_ActivateSetup.UseVisualStyleBackColor = true;
            this.Btn_ActivateSetup.Click += new System.EventHandler(this.Btn_ActivateSetup_Click_1);
            // 
            // Cmb_Profiles
            // 
            this.Cmb_Profiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Profiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Profiles.Location = new System.Drawing.Point(27, 39);
            this.Cmb_Profiles.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cmb_Profiles.Name = "Cmb_Profiles";
            this.Cmb_Profiles.Size = new System.Drawing.Size(210, 28);
            this.Cmb_Profiles.TabIndex = 7;
            this.Cmb_Profiles.SelectedIndexChanged += new System.EventHandler(this.Cmb_Profiles_SelectedIndexChanged);
            // 
            // Btn_DeleteProfile
            // 
            this.Btn_DeleteProfile.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_DeleteProfile.Location = new System.Drawing.Point(486, 37);
            this.Btn_DeleteProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_DeleteProfile.Name = "Btn_DeleteProfile";
            this.Btn_DeleteProfile.Size = new System.Drawing.Size(210, 28);
            this.Btn_DeleteProfile.TabIndex = 10;
            this.Btn_DeleteProfile.Text = "Delete Profile";
            this.Btn_DeleteProfile.UseVisualStyleBackColor = true;
            this.Btn_DeleteProfile.Click += new System.EventHandler(this.Btn_DeleteProfile_Click);
            // 
            // Btn_AddProfile
            // 
            this.Btn_AddProfile.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AddProfile.Location = new System.Drawing.Point(256, 37);
            this.Btn_AddProfile.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Btn_AddProfile.Name = "Btn_AddProfile";
            this.Btn_AddProfile.Size = new System.Drawing.Size(210, 28);
            this.Btn_AddProfile.TabIndex = 8;
            this.Btn_AddProfile.Text = "Add Profile";
            this.Btn_AddProfile.UseVisualStyleBackColor = true;
            this.Btn_AddProfile.Click += new System.EventHandler(this.Btn_AddProfile_Click);
            // 
            // Liv_Processes
            // 
            this.Liv_Processes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_Name,
            this.Col_Status});
            this.Liv_Processes.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liv_Processes.FullRowSelect = true;
            this.Liv_Processes.GridLines = true;
            this.Liv_Processes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Liv_Processes.HideSelection = false;
            this.Liv_Processes.Location = new System.Drawing.Point(27, 75);
            this.Liv_Processes.MultiSelect = false;
            this.Liv_Processes.Name = "Liv_Processes";
            this.Liv_Processes.Scrollable = false;
            this.Liv_Processes.Size = new System.Drawing.Size(669, 245);
            this.Liv_Processes.TabIndex = 11;
            this.Liv_Processes.UseCompatibleStateImageBehavior = false;
            this.Liv_Processes.View = System.Windows.Forms.View.Details;
            // 
            // Col_Name
            // 
            this.Col_Name.Text = "Name";
            this.Col_Name.Width = 577;
            // 
            // Col_Status
            // 
            this.Col_Status.Text = "Status";
            this.Col_Status.Width = 95;
            // 
            // Frm_AutoSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(725, 438);
            this.Controls.Add(this.Liv_Processes);
            this.Controls.Add(this.Btn_DeleteProfile);
            this.Controls.Add(this.Btn_AddProfile);
            this.Controls.Add(this.Cmb_Profiles);
            this.Controls.Add(this.Btn_ActivateSetup);
            this.Controls.Add(this.Btn_DeleteProcess);
            this.Controls.Add(this.Btn_EditProcess);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Btn_AddProcess);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Frm_AutoSetup";
            this.Text = "AutoSetup";
            this.Load += new System.EventHandler(this.Frm_AutoSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_AddProcess;
        private System.Windows.Forms.Label Lbl_Title;
        private System.Windows.Forms.Button Btn_EditProcess;
        private System.Windows.Forms.Button Btn_DeleteProcess;
        private System.Windows.Forms.Button Btn_ActivateSetup;
        private System.Windows.Forms.ComboBox Cmb_Profiles;
        private System.Windows.Forms.Button Btn_DeleteProfile;
        private System.Windows.Forms.Button Btn_AddProfile;
        private System.Windows.Forms.ListView Liv_Processes;
        private System.Windows.Forms.ColumnHeader Col_Name;
        private System.Windows.Forms.ColumnHeader Col_Status;
    }
}

