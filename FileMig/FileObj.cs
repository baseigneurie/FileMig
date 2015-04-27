using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileMig;
using System.IO;

namespace FileMig
{
    class FileObj
    {
        private helper h = new helper();

        public string from { get; set; }
        public string to { get; set; }
        public string name { get; set; }
        public int opt { get; set; }
        public int ftp { get; set; }
        public string fileName { get; set; }
        public string batchName { get; set; }


        public bool validate()
        {
            return checkFile(this);
        }


        private bool checkFile(FileObj fo)
        {
            string s;
            int len = 0;

            if (!File.Exists(fo.from))
            {
                h.alert("Source path doesn't exist. Please check your information and try again.", "File Error");
                return false;
            }

            s = fo.to;
            len = s.Length - (fo.fileName.Length + 1);
            s = s.Substring(0, len);

            if (Directory.Exists(s))
            {
                if (File.Exists(fo.to))
                {
                    h.alert("Destination path doesn't exist. Please check your information and try again.", "File Error");
                    return false;
                }
            }

            return true;
        }


    }
}
