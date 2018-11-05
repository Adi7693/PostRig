using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Input;

namespace PostRig
{
    public class Document
    {
        public InputData Input { get; set; }

        public string FileName { get; private set; }

        public Document()
        {
            Input = new InputData();
        }


        public Document(string fileName) : this()
        {
            FileName = fileName;
        }


        private void LoadCarData(BinaryReader reader)
        {

        }


        public void Open()
        {

        }


        public void Save()
        {

        }

        public void SaveAs(string fileName)
        {

        }



    }
}
