using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyCRM
{
    public partial class AllContactsForm : Form
    {
        public AllContactsForm()
        {
            InitializeComponent();

            StreamReader sr = SetupReader();

            string? line = sr.ReadLine();

            labelTitle.Text = line;

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }

        private StreamReader SetupReader()
        {
            StreamReader sr = new StreamReader($"C:\\Users\\{Environment.UserName}\\Documents\\Sample.txt");
            return sr;
        } 
    }
}
