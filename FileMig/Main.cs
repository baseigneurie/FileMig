using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMig
{
    public partial class frmFileMain : Form
    {
        private helper h = new helper();

        public frmFileMain()
        {
            InitializeComponent();


            //string path = @"C:\temp\tester.txt";

            btnMigrate.Enabled = false;
            btnEditBatch.Enabled = false;
            
            
        }




        private void btnEditBatch_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();
        }

        private void btnAddBatch_Click(object sender, EventArgs e)
        {
            Setup setup = new Setup();
            setup.Show();
        }
    }
}
