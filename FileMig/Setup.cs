using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileMig.FileObjects;

namespace FileMig
{
    public partial class Setup : Form
    {
        private string fname;
        private helper h = new helper();
        private BatchLine bl = new BatchLine();
        private BatchObject bo = new BatchObject();

        public Setup()
        {
            InitializeComponent();
            cboFTP.SelectedIndex = 0;
            cboMethod.SelectedIndex = 0;
        }

        private void lnkBrowseFrom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();

            if (diag.ShowDialog() == DialogResult.OK)
            {
                fname = diag.SafeFileName.ToString();
                txtFromDir.Text = diag.FileName.ToString();
            }

        }

        private void lnkBrowseTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();

            if (!String.IsNullOrEmpty(txtFromDir.Text) || !String.IsNullOrWhiteSpace(txtFromDir.Text))
            {

                if (!String.IsNullOrEmpty(fname) || !String.IsNullOrWhiteSpace(fname))
                {
                    diag.FileName = fname;
                }
                else
                {
                    h.alert("The source file name is empty.\nYou must first select a source file above and then select the destination.", "File Location Error");
                    txtFromDir.Focus();
                    fname = null;
                    return;               
                }
               
            }
            else
            {
                h.alert("The source file name is empty.\nYou must first select a source file above and then select the destination.", "File Location Error");
                txtFromDir.Focus();
                fname = null;
                return;
            }            

            if (diag.ShowDialog() == DialogResult.OK)
            {
               txtToDir.Text = diag.FileName.ToString();
            }

        }

        private void btnCancelBatch_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveBatch_Click(object sender, EventArgs e)
        {

            if (saveCheck())
            {
                bo.batchName = txtBatName.Text;
                bl.fileName = fname;
                bl.listName = txtScriptName.Text;
                bl.from = txtFromDir.Text;
                bl.to = txtToDir.Text;
                bl.opt = cboMethod.SelectedIndex;
                bl.ftp = cboFTP.SelectedIndex;

                FileIO fio = new FileIO(bl, bo);

                if (fio.validate())
                {
                    fio.save();
                }

            }

        }

        private bool saveCheck()
        {
            string s;

            if (String.IsNullOrEmpty(txtBatName.Text) || String.IsNullOrWhiteSpace(txtBatName.Text))
            {
                s = "The batch must have a name. Please fill in a name and try again.";
                txtBatName.Focus();
                return h.alert(s, "Save Error");
            }
            else if (String.IsNullOrEmpty(txtFromDir.Text) || String.IsNullOrWhiteSpace(txtFromDir.Text))
            {
                s = "No source directory found. Please select a directory and try again.";
                txtFromDir.Focus();
                return h.alert(s, "Save Error");
            }
            else if (String.IsNullOrEmpty(txtToDir.Text) || String.IsNullOrWhiteSpace(txtToDir.Text))
            {
                s = "No destination directory found. Please select a directory and try again.";
                txtToDir.Focus();
                return h.alert(s, "Save Error");
            }
            else if (String.IsNullOrEmpty(txtScriptName.Text) || String.IsNullOrWhiteSpace(txtScriptName.Text))
            {
                s = "The script must have a name. Please fill in a name and try again.";
                txtScriptName.Focus();
                return h.alert(s, "Save Error");
            }
            else if (cboMethod.SelectedIndex == -1)
            {
                s = "Please select a valid menu option for How";
                cboMethod.Focus();
                return h.alert(s, "Save Error");
            }
            else if (cboFTP.SelectedIndex == -1)
            {
                s = "Please select a valid menu option for How and FTP";
                cboFTP.Focus();
                return h.alert(s, "Save Error");
            }

            return true;
    
        } 
      
    }
}
