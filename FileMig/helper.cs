using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMig
{
    class helper
    {

        public bool alert(string m, string t = null)
        {
            if (String.IsNullOrEmpty(t)) { t = "Alert"; }
            MessageBox.Show(m, t, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }





    }
}
