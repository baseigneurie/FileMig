using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMig.FileObjects
{
    class BatchObject
    {
        public int batchID { get; set; }
        public string batchName { get; set; }
        public IEnumerable<BatchLine> batchLines { get; set; }

        public void autoInc()
        {
            this.batchID++;
        }

    }
}
