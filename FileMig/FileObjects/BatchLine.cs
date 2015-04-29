using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMig.FileObjects
{
    class BatchLine
    {
        public int lineID { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string listName { get; set; }
        public int opt { get; set; }
        public int ftp { get; set; }
        public string fileName { get; set; }
        public int batchID { get; set; }

        public void autoInc()
        {
            this.lineID++;
        }

    }




}
