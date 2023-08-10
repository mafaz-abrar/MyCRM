using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCRM
{
    internal class DataModel
    {
        private string _filePath;
            
        public DataModel(string filePath) { 
            _filePath = filePath;
        }

        // TODO: Figure out how DataTables work
        public void WriteToFile(DataTable dt)
        {
            StreamWriter sw = new StreamWriter(_filePath);
        }
    }
}
