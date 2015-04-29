using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileMig;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using FileMig.FileObjects;

namespace FileMig
{
    class FileIO
    {
        private helper h = new helper();
        private BatchLine batLine = new BatchLine();
        private BatchObject batObj = new BatchObject();

        public FileIO(BatchLine bl, BatchObject bo)
        {
            this.batLine = bl;
            this.batObj = bo;
        }

        public FileIO(BatchLine bl)
        {
            this.batLine = bl;
        }

        public bool validate()
        {
            return checkFile();
        }

        public void save()
        {
            string location = prepSave();
            saveBatch(location);
        }


        private bool checkFile()
        {
            string s;
            int len = 0;

            if (!File.Exists(batLine.from))
            {
                h.alert("Source path doesn't exist. Please check your information and try again.", "File Error");
                return false;
            }

            s = batLine.to;
            len = s.Length - (batLine.fileName.Length + 1);
            s = s.Substring(0, len);

            if (Directory.Exists(s))
            {
                if (File.Exists(batLine.to))
                {
                    h.alert("Destination path doesn't exist. Please check your information and try again.", "File Error");
                    return false;
                }
            }

            return true;
        }


        private string prepSave()
        {
            
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string saveDir = string.Format(@"{0}\res\", appPath);

            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }

            saveDir = string.Format(@"{0}{1}", saveDir, "batsf.txt");

            return saveDir;
        }

        private void saveBatch(string dir)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            using (StreamWriter sw = new StreamWriter(dir))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, batLine);
            }
        }

    }
}
