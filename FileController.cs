using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_8
{
    class FileController
    {
        public string FileName { get; set; }

        public FileController(string FileName)
        {
            this.FileName = FileName;
        }

        public string[] ReadFile()
        {
            List<string> list = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(FileName, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch(Exception exp)
            {

            }

            return list.ToArray();
        }

        public void WriteInFile(ISerializable[] serializables)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FileName, false, System.Text.Encoding.Default))
                {
                    foreach (var obj in serializables)
                    {
                        sw.WriteLine(obj.objectToString());
                    }
                }
            }
            catch (Exception exp)
            {

            }
        }
    }
}
