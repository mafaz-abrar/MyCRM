using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCRM
{
    public partial class ContactDetailsForm : Form
    {
        private Contact fContact;
        private bool fNewContact;
        private CRMContext fDbContext;

        public ContactDetailsForm(CRMContext dbContext, Contact? contact = null)
        {
            InitializeComponent();

            fDbContext = dbContext;

            if (contact == null) fNewContact = true;

            fContact = contact ?? new Contact();

            bindData();
        }

        private void bindData()
        {
            textBoxGivenNames.DataBindings.Add(new Binding(
                "Text", fContact, "GivenNames"));

            textBoxFamilyName.DataBindings.Add(new Binding(
                "Text", fContact, "FamilyName"));


            textBoxEmails.DataBindings.Add(new Binding(
                "Text", fContact, "Emails"));

            textBoxPhoneNumbers.DataBindings.Add(new Binding(
                "Text", fContact, "FullyQualifiedPhoneNumbers"));

            textBoxOtherChannels.DataBindings.Add(new Binding(
                "Text", fContact, "OtherChannels"));

            dateTimePickerLastConnectionDate.DataBindings.Add(new Binding(
                "Text", fContact, "LastConnectionDate"));

            richTextBoxRecentNotes.DataBindings.Add(new Binding(
                "Text", fContact, "RecentNotes"));
        }

        private void clearBindings()
        {
            textBoxGivenNames.DataBindings.Clear();
            textBoxFamilyName.DataBindings.Clear();
            textBoxEmails.DataBindings.Clear();
            textBoxPhoneNumbers.DataBindings.Clear();
            textBoxOtherChannels.DataBindings.Clear();
            dateTimePickerLastConnectionDate.DataBindings.Clear();
            richTextBoxRecentNotes.DataBindings.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (fNewContact)
            {
                fDbContext.Contacts.Add(fContact);
            }

            fDbContext.SaveChanges();

            clearBindings();
            Close();
        }

        private void buttonDiscard_Click(object sender, EventArgs e)
        {
            clearBindings();
            Close();
        }
    }
}
