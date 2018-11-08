using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Input;

namespace PostRig
{
    public class Document
    {
        public InputData Input { get; set; }

        public int Version
        {
            get;
            private set;
        }

        public string FileName { get; private set; }

        public string Name
        {
            get
            {
                if (FileName != null)
                {
                    return Path.GetFileName(FileName);
                }

                return null;
            }
        }

        public Document()
        {
            Input = new InputData();

            Version = 0;
        }


        public Document(string fileName) : this()
        {
            FileName = fileName;

            Open();
        }


        private void LoadCarData(BinaryReader reader)
        {

        }


        public void Open()
        {
            BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open));

            string method = reader.ReadString();

            Type type = Type.GetType("PostRig.Document");

            PropertyInfo info = type.GetProperty(method);

            MethodInfo mi = info.SetMethod;

            mi.Invoke(this, new object[] { reader.ReadInt32() });

            method = reader.ReadString();
            info = type.GetProperty(method);

            mi = info.SetMethod;
            mi.Invoke(this, new object[] { reader.ReadDouble() });
            reader.Close();
        }


        public void Save()
        {
            SaveAs(FileName);
        }

        public void SaveAs(string fileName)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create));

            writer.Write("Version");
            if (Version == 0)
            {
                Version = 1;
            }
            writer.Write(Version);

            Input.SaveAs

            writer.Close();
        }



    }
}
