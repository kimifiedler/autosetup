namespace AutoSetup
{
    partial class Frm_EditProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ProcessName = new System.Windows.Forms.Label();
            this.Btn_ApplyChanges = new System.Windows.Forms.Button();
            this.Opt_OpenProcess = new System.Windows.Forms.RadioButton();
            this.Lbl_ProcessStatus = new System.Windows.Forms.Label();
            this.Opt_CloseProcess = new System.Windows.Forms.RadioButton();
            this.Opt_MinimizeProcess = new System.Windows.Forms.RadioButton();
            this.Txt_ProcessName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_ProcessName
            // 
            this.Lbl_ProcessName.AutoSize = true;
            this.Lbl_ProcessName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProcessName.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ProcessName.Name = "Lbl_ProcessName";
            this.Lbl_ProcessName.Size = new System.Drawing.Size(121, 21);
            this.Lbl_ProcessName.TabIndex = 3;
            this.Lbl_ProcessName.Text = "Process Name:";
            // 
            // Btn_ApplyChanges
            // 
            this.Btn_ApplyChanges.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ApplyChanges.Location = new System.Drawing.Point(42, 192);
            this.Btn_ApplyChanges.Name = "Btn_ApplyChanges";
            this.Btn_ApplyChanges.Size = new System.Drawing.Size(138, 44);
            this.Btn_ApplyChanges.TabIndex = 6;
            this.Btn_ApplyChanges.Text = "Apply Changes";
            this.Btn_ApplyChanges.UseVisualStyleBackColor = true;
            this.Btn_ApplyChanges.Click += new System.EventHandler(this.Btn_ApplyChanges_Click);
            // 
            // Opt_OpenProcess
            // 
            this.Opt_OpenProcess.AutoSize = true;
            this.Opt_OpenProcess.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_OpenProcess.Location = new System.Drawing.Point(16, 102);
            this.Opt_OpenProcess.Name = "Opt_OpenProcess";
            this.Opt_OpenProcess.Size = new System.Drawing.Size(116, 24);
            this.Opt_OpenProcess.TabIndex = 7;
            this.Opt_OpenProcess.TabStop = true;
            this.Opt_OpenProcess.Text = "Open Process";
            this.Opt_OpenProcess.UseVisualStyleBackColor = true;
            // 
            // Lbl_ProcessStatus
            // 
            this.Lbl_ProcessStatus.AutoSize = true;
            this.Lbl_ProcessStatus.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProcessStatus.Location = new System.Drawing.Point(12, 78);
            this.Lbl_ProcessStatus.Name = "Lbl_ProcessStatus";
            this.Lbl_ProcessStatus.Size = new System.Drawing.Size(122, 21);
            this.Lbl_ProcessStatus.TabIndex = 8;
            this.Lbl_ProcessStatus.Text = "Process Status:";
            // 
            // Opt_CloseProcess
            // 
            this.Opt_CloseProcess.AutoSize = true;
            this.Opt_CloseProcess.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_CloseProcess.Location = new System.Drawing.Point(16, 132);
            this.Opt_CloseProcess.Name = "Opt_CloseProcess";
            this.Opt_CloseProcess.Size = new System.Drawing.Size(116, 24);
            this.Opt_CloseProcess.TabIndex = 9;
            this.Opt_CloseProcess.TabStop = true;
            this.Opt_CloseProcess.Text = "Close Process";
            this.Opt_CloseProcess.UseVisualStyleBackColor = true;
            // 
            // Opt_MinimizeProcess
            // 
            this.Opt_MinimizeProcess.AutoSize = true;
            this.Opt_MinimizeProcess.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_MinimizeProcess.Location = new System.Drawing.Point(16, 162);
            this.Opt_MinimizeProcess.Name = "Opt_MinimizeProcess";
            this.Opt_MinimizeProcess.Size = new System.Drawing.Size(141, 24);
            this.Opt_MinimizeProcess.TabIndex = 10;
            this.Opt_MinimizeProcess.TabStop = true;
            this.Opt_MinimizeProcess.Text = "Minimize Process";
            this.Opt_MinimizeProcess.UseVisualStyleBackColor = true;
            // 
            // Txt_ProcessName
            // 
            this.Txt_ProcessName.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ProcessName.Location = new System.Drawing.Point(12, 37);
            this.Txt_ProcessName.Name = "Txt_ProcessName";
            this.Txt_ProcessName.ReadOnly = true;
            this.Txt_ProcessName.Size = new System.Drawing.Size(194, 28);
            this.Txt_ProcessName.TabIndex = 11;
            // 
            // Frm_EditProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(218, 248);
            this.Controls.Add(this.Txt_ProcessName);
            this.Controls.Add(this.Opt_MinimizeProcess);
            this.Controls.Add(this.Opt_CloseProcess);
            this.Controls.Add(this.Lbl_ProcessStatus);
            this.Controls.Add(this.Opt_OpenProcess);
            this.Controls.Add(this.Btn_ApplyChanges);
            this.Controls.Add(this.Lbl_ProcessName);
            this.MaximizeBox = false;
            this.Name = "Frm_EditProcess";
            this.Text = "Edit Process";
            this.Load += new System.EventHandler(this.Frm_EditProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ProcessName;
        private System.Windows.Forms.Button Btn_ApplyChanges;
        private System.Windows.Forms.RadioButton Opt_OpenProcess;
        private System.Windows.Forms.Label Lbl_ProcessStatus;
        private System.Windows.Forms.RadioButton Opt_CloseProcess;
        private System.Windows.Forms.RadioButton Opt_MinimizeProcess;
        private System.Windows.Forms.TextBox Txt_ProcessName;
    }
}