using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MyCRM
{
    internal class Contact
    {
        private string fName;
        private DateTime fLastContactDate;
        private string fNotes;

        public Contact(string Name) {
            fName = Name;
        }

        public string Name { 
            get => fName;
            set => fName = value;  
        }

        public void SetLastContactDate(int year, int month, int day) {
            fLastContactDate = new DateTime(year, month, day);  
        }

    }
}
