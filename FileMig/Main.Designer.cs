namespace FileMig
{
    partial class frmFileMain
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
            this.lbBatches = new System.Windows.Forms.ListBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
            this.gvScripts = new System.Windows.Forms.DataGridView();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.statMain = new System.Windows.Forms.StatusStrip();
            this.statLblMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBatches = new System.Windows.Forms.Label();
            this.lblContains = new System.Windows.Forms.Label();
            this.btnEditBatch = new System.Windows.Forms.Button();
            this.btnAddBatch = new System.Windows.Forms.Button();
            this.btnMigrate = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvScripts)).BeginInit();
            this.statMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBatches
            // 
            this.lbBatches.FormattingEnabled = true;
            this.lbBatches.Location = new System.Drawing.Point(12, 55);
            this.lbBatches.Name = "lbBatches";
            this.lbBatches.Size = new System.Drawing.Size(157, 160);
            this.lbBatches.TabIndex = 0;
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(641, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // mnuMainFile
            // 
            this.mnuMainFile.Name = "mnuMainFile";
            this.mnuMainFile.Size = new System.Drawing.Size(37, 20);
            this.mnuMainFile.Text = "&File";
            // 
            // gvScripts
            // 
            this.gvScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvScripts.Location = new System.Drawing.Point(175, 55);
            this.gvScripts.Name = "gvScripts";
            this.gvScripts.Size = new System.Drawing.Size(454, 160);
            this.gvScripts.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(12, 237);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(423, 153);
            this.txtOutput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(10, 218);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(56, 16);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output:";
            // 
            // statMain
            // 
            this.statMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statLblMain});
            this.statMain.Location = new System.Drawing.Point(0, 405);
            this.statMain.Name = "statMain";
            this.statMain.Size = new System.Drawing.Size(641, 22);
            this.statMain.TabIndex = 5;
            this.statMain.Text = "statusStrip1";
            // 
            // statLblMain
            // 
            this.statLblMain.Name = "statLblMain";
            this.statLblMain.Size = new System.Drawing.Size(39, 17);
            this.statLblMain.Text = "Ready";
            // 
            // lblBatches
            // 
            this.lblBatches.AutoSize = true;
            this.lblBatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatches.Location = new System.Drawing.Point(10, 36);
            this.lblBatches.Name = "lblBatches";
            this.lblBatches.Size = new System.Drawing.Size(64, 16);
            this.lblBatches.TabIndex = 6;
            this.lblBatches.Text = "Batches";
            // 
            // lblContains
            // 
            this.lblContains.AutoSize = true;
            this.lblContains.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContains.Location = new System.Drawing.Point(172, 36);
            this.lblContains.Name = "lblContains";
            this.lblContains.Size = new System.Drawing.Size(134, 16);
            this.lblContains.TabIndex = 7;
            this.lblContains.Text = "Scripts Contained:";
            // 
            // btnEditBatch
            // 
            this.btnEditBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBatch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBatch.ForeColor = System.Drawing.Color.White;
            this.btnEditBatch.Location = new System.Drawing.Point(442, 237);
            this.btnEditBatch.Name = "btnEditBatch";
            this.btnEditBatch.Size = new System.Drawing.Size(187, 34);
            this.btnEditBatch.TabIndex = 8;
            this.btnEditBatch.Text = "Edit Batch";
            this.btnEditBatch.UseVisualStyleBackColor = false;
            this.btnEditBatch.Click += new System.EventHandler(this.btnEditBatch_Click);
            // 
            // btnAddBatch
            // 
            this.btnAddBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBatch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBatch.ForeColor = System.Drawing.Color.White;
            this.btnAddBatch.Location = new System.Drawing.Point(442, 285);
            this.btnAddBatch.Name = "btnAddBatch";
            this.btnAddBatch.Size = new System.Drawing.Size(187, 34);
            this.btnAddBatch.TabIndex = 9;
            this.btnAddBatch.Text = "Add Batch";
            this.btnAddBatch.UseVisualStyleBackColor = false;
            this.btnAddBatch.Click += new System.EventHandler(this.btnAddBatch_Click);
            // 
            // btnMigrate
            // 
            this.btnMigrate.BackColor = System.Drawing.Color.Green;
            this.btnMigrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMigrate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrate.ForeColor = System.Drawing.Color.White;
            this.btnMigrate.Location = new System.Drawing.Point(442, 334);
            this.btnMigrate.Name = "btnMigrate";
            this.btnMigrate.Size = new System.Drawing.Size(187, 56);
            this.btnMigrate.TabIndex = 10;
            this.btnMigrate.Text = "RUN MIGRATION";
            this.btnMigrate.UseVisualStyleBackColor = false;
            // 
            // frmFileMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 427);
            this.Controls.Add(this.btnMigrate);
            this.Controls.Add(this.btnAddBatch);
            this.Controls.Add(this.btnEditBatch);
            this.Controls.Add(this.lblContains);
            this.Controls.Add(this.lblBatches);
            this.Controls.Add(this.statMain);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.gvScripts);
            this.Controls.Add(this.lbBatches);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmFileMain";
            this.Text = "File Migrator - 3000";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvScripts)).EndInit();
            this.statMain.ResumeLayout(false);
            this.statMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBatches;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
        private System.Windows.Forms.DataGridView gvScripts;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.StatusStrip statMain;
        private System.Windows.Forms.ToolStripStatusLabel statLblMain;
        private System.Windows.Forms.Label lblBatches;
        private System.Windows.Forms.Label lblContains;
        private System.Windows.Forms.Button btnEditBatch;
        private System.Windows.Forms.Button btnAddBatch;
        private System.Windows.Forms.Button btnMigrate;
    }
}

