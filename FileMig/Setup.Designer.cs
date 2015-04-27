namespace FileMig
{
    partial class Setup
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
            this.mnuSetup = new System.Windows.Forms.MenuStrip();
            this.mnuSetupFile = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBatName = new System.Windows.Forms.Label();
            this.txtBatName = new System.Windows.Forms.TextBox();
            this.lbScripts = new System.Windows.Forms.ListBox();
            this.lblScriptsInBatch = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFromDir = new System.Windows.Forms.TextBox();
            this.txtToDir = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lnkBrowseFrom = new System.Windows.Forms.LinkLabel();
            this.lnkBrowseTo = new System.Windows.Forms.LinkLabel();
            this.txtScriptName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.lblFTP = new System.Windows.Forms.Label();
            this.cboFTP = new System.Windows.Forms.ComboBox();
            this.btnSaveBatch = new System.Windows.Forms.Button();
            this.lnkDeleteBatch = new System.Windows.Forms.LinkLabel();
            this.btnCancelBatch = new System.Windows.Forms.Button();
            this.mnuSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSetup
            // 
            this.mnuSetup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSetupFile});
            this.mnuSetup.Location = new System.Drawing.Point(0, 0);
            this.mnuSetup.Name = "mnuSetup";
            this.mnuSetup.Size = new System.Drawing.Size(559, 24);
            this.mnuSetup.TabIndex = 0;
            this.mnuSetup.Text = "menuStrip1";
            // 
            // mnuSetupFile
            // 
            this.mnuSetupFile.Name = "mnuSetupFile";
            this.mnuSetupFile.Size = new System.Drawing.Size(37, 20);
            this.mnuSetupFile.Text = "&File";
            // 
            // lblBatName
            // 
            this.lblBatName.AutoSize = true;
            this.lblBatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatName.Location = new System.Drawing.Point(13, 35);
            this.lblBatName.Name = "lblBatName";
            this.lblBatName.Size = new System.Drawing.Size(85, 16);
            this.lblBatName.TabIndex = 1;
            this.lblBatName.Text = "Batch Name:";
            // 
            // txtBatName
            // 
            this.txtBatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatName.Location = new System.Drawing.Point(104, 32);
            this.txtBatName.Name = "txtBatName";
            this.txtBatName.Size = new System.Drawing.Size(443, 22);
            this.txtBatName.TabIndex = 2;
            // 
            // lbScripts
            // 
            this.lbScripts.FormattingEnabled = true;
            this.lbScripts.Location = new System.Drawing.Point(16, 86);
            this.lbScripts.Name = "lbScripts";
            this.lbScripts.Size = new System.Drawing.Size(182, 186);
            this.lbScripts.TabIndex = 3;
            // 
            // lblScriptsInBatch
            // 
            this.lblScriptsInBatch.AutoSize = true;
            this.lblScriptsInBatch.Location = new System.Drawing.Point(16, 67);
            this.lblScriptsInBatch.Name = "lblScriptsInBatch";
            this.lblScriptsInBatch.Size = new System.Drawing.Size(42, 13);
            this.lblScriptsInBatch.TabIndex = 4;
            this.lblScriptsInBatch.Text = "Scripts:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(214, 86);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(41, 13);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "FROM:";
            // 
            // txtFromDir
            // 
            this.txtFromDir.Location = new System.Drawing.Point(261, 83);
            this.txtFromDir.Name = "txtFromDir";
            this.txtFromDir.Size = new System.Drawing.Size(229, 20);
            this.txtFromDir.TabIndex = 6;
            // 
            // txtToDir
            // 
            this.txtToDir.Location = new System.Drawing.Point(261, 123);
            this.txtToDir.Name = "txtToDir";
            this.txtToDir.Size = new System.Drawing.Size(229, 20);
            this.txtToDir.TabIndex = 8;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(214, 126);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "TO:";
            // 
            // lnkBrowseFrom
            // 
            this.lnkBrowseFrom.AutoSize = true;
            this.lnkBrowseFrom.Location = new System.Drawing.Point(496, 86);
            this.lnkBrowseFrom.Name = "lnkBrowseFrom";
            this.lnkBrowseFrom.Size = new System.Drawing.Size(51, 13);
            this.lnkBrowseFrom.TabIndex = 9;
            this.lnkBrowseFrom.TabStop = true;
            this.lnkBrowseFrom.Text = "Browse...";
            this.lnkBrowseFrom.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkBrowseFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrowseFrom_LinkClicked);
            // 
            // lnkBrowseTo
            // 
            this.lnkBrowseTo.AutoSize = true;
            this.lnkBrowseTo.Location = new System.Drawing.Point(496, 127);
            this.lnkBrowseTo.Name = "lnkBrowseTo";
            this.lnkBrowseTo.Size = new System.Drawing.Size(51, 13);
            this.lnkBrowseTo.TabIndex = 10;
            this.lnkBrowseTo.TabStop = true;
            this.lnkBrowseTo.Text = "Browse...";
            this.lnkBrowseTo.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnkBrowseTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBrowseTo_LinkClicked);
            // 
            // txtScriptName
            // 
            this.txtScriptName.Location = new System.Drawing.Point(261, 163);
            this.txtScriptName.Name = "txtScriptName";
            this.txtScriptName.Size = new System.Drawing.Size(229, 20);
            this.txtScriptName.TabIndex = 12;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(214, 166);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "NAME:";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(214, 206);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(37, 13);
            this.lblMethod.TabIndex = 13;
            this.lblMethod.Text = "HOW:";
            // 
            // cboMethod
            // 
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Items.AddRange(new object[] {
            "COPY",
            "MOVE"});
            this.cboMethod.Location = new System.Drawing.Point(261, 203);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(121, 21);
            this.cboMethod.TabIndex = 14;
            // 
            // lblFTP
            // 
            this.lblFTP.AutoSize = true;
            this.lblFTP.Location = new System.Drawing.Point(214, 247);
            this.lblFTP.Name = "lblFTP";
            this.lblFTP.Size = new System.Drawing.Size(30, 13);
            this.lblFTP.TabIndex = 15;
            this.lblFTP.Text = "FTP:";
            // 
            // cboFTP
            // 
            this.cboFTP.FormattingEnabled = true;
            this.cboFTP.Items.AddRange(new object[] {
            "None"});
            this.cboFTP.Location = new System.Drawing.Point(261, 244);
            this.cboFTP.Name = "cboFTP";
            this.cboFTP.Size = new System.Drawing.Size(121, 21);
            this.cboFTP.TabIndex = 16;
            // 
            // btnSaveBatch
            // 
            this.btnSaveBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBatch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBatch.ForeColor = System.Drawing.Color.White;
            this.btnSaveBatch.Location = new System.Drawing.Point(16, 291);
            this.btnSaveBatch.Name = "btnSaveBatch";
            this.btnSaveBatch.Size = new System.Drawing.Size(99, 34);
            this.btnSaveBatch.TabIndex = 17;
            this.btnSaveBatch.Text = "Save Batch";
            this.btnSaveBatch.UseVisualStyleBackColor = false;
            this.btnSaveBatch.Click += new System.EventHandler(this.btnSaveBatch_Click);
            // 
            // lnkDeleteBatch
            // 
            this.lnkDeleteBatch.AutoSize = true;
            this.lnkDeleteBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDeleteBatch.LinkColor = System.Drawing.Color.Maroon;
            this.lnkDeleteBatch.Location = new System.Drawing.Point(486, 302);
            this.lnkDeleteBatch.Name = "lnkDeleteBatch";
            this.lnkDeleteBatch.Size = new System.Drawing.Size(61, 16);
            this.lnkDeleteBatch.TabIndex = 18;
            this.lnkDeleteBatch.TabStop = true;
            this.lnkDeleteBatch.Text = "DELETE";
            // 
            // btnCancelBatch
            // 
            this.btnCancelBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBatch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelBatch.ForeColor = System.Drawing.Color.White;
            this.btnCancelBatch.Location = new System.Drawing.Point(130, 291);
            this.btnCancelBatch.Name = "btnCancelBatch";
            this.btnCancelBatch.Size = new System.Drawing.Size(99, 34);
            this.btnCancelBatch.TabIndex = 19;
            this.btnCancelBatch.Text = "Cancel";
            this.btnCancelBatch.UseVisualStyleBackColor = false;
            this.btnCancelBatch.Click += new System.EventHandler(this.btnCancelBatch_Click);
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 337);
            this.Controls.Add(this.btnCancelBatch);
            this.Controls.Add(this.lnkDeleteBatch);
            this.Controls.Add(this.btnSaveBatch);
            this.Controls.Add(this.cboFTP);
            this.Controls.Add(this.lblFTP);
            this.Controls.Add(this.cboMethod);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.txtScriptName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lnkBrowseTo);
            this.Controls.Add(this.lnkBrowseFrom);
            this.Controls.Add(this.txtToDir);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtFromDir);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblScriptsInBatch);
            this.Controls.Add(this.lbScripts);
            this.Controls.Add(this.txtBatName);
            this.Controls.Add(this.lblBatName);
            this.Controls.Add(this.mnuSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuSetup;
            this.MaximizeBox = false;
            this.Name = "Setup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Setup";
            this.mnuSetup.ResumeLayout(false);
            this.mnuSetup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuSetupFile;
        private System.Windows.Forms.Label lblBatName;
        private System.Windows.Forms.TextBox txtBatName;
        private System.Windows.Forms.ListBox lbScripts;
        private System.Windows.Forms.Label lblScriptsInBatch;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtFromDir;
        private System.Windows.Forms.TextBox txtToDir;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.LinkLabel lnkBrowseFrom;
        private System.Windows.Forms.LinkLabel lnkBrowseTo;
        private System.Windows.Forms.TextBox txtScriptName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label lblFTP;
        private System.Windows.Forms.ComboBox cboFTP;
        private System.Windows.Forms.Button btnSaveBatch;
        private System.Windows.Forms.LinkLabel lnkDeleteBatch;
        private System.Windows.Forms.Button btnCancelBatch;
    }
}