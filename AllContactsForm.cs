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
using Microsoft.EntityFrameworkCore;

namespace MyCRM
{
    public partial class AllContactsForm : Form
    {
        private CRMContext fDbContext;

        public AllContactsForm()
        {
            InitializeComponent();

            fDbContext = new CRMContext();

            GetData();
        }

        private void GetData()
        {
            var contacts = fDbContext.Contacts.ToList();

            dataGridViewContacts.DataSource = contacts;

            dataGridViewContacts.AutoResizeColumns();
            dataGridViewContacts.AutoResizeRows();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ContactDetailsForm detailForm = new ContactDetailsForm(fDbContext);
            detailForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ContactDetailsForm detailForm = new ContactDetailsForm(
                fDbContext, dataGridViewContacts.CurrentRow.DataBoundItem as Contact
            );

            detailForm.Show();
        }
    }
}
