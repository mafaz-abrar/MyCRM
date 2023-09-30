namespace MyCRM
{
    partial class ContactDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelGivenNames = new Label();
            labelEmails = new Label();
            labelFamilyName = new Label();
            labelFullyQualifiedPhoneNumbers = new Label();
            labelOtherChannels = new Label();
            labelRecentNotes = new Label();
            textBoxFamilyName = new TextBox();
            labelLastConnectionDate = new Label();
            textBoxGivenNames = new TextBox();
            richTextBoxRecentNotes = new RichTextBox();
            buttonDiscard = new Button();
            buttonSave = new Button();
            dateTimePickerLastConnectionDate = new DateTimePicker();
            textBoxEmails = new TextBox();
            textBoxPhoneNumbers = new TextBox();
            textBoxOtherChannels = new TextBox();
            SuspendLayout();
            // 
            // labelGivenNames
            // 
            labelGivenNames.AutoSize = true;
            labelGivenNames.Location = new Point(12, 9);
            labelGivenNames.Name = "labelGivenNames";
            labelGivenNames.Size = new Size(80, 15);
            labelGivenNames.TabIndex = 1;
            labelGivenNames.Text = "Given Names:";
            // 
            // labelEmails
            // 
            labelEmails.AutoSize = true;
            labelEmails.Location = new Point(12, 115);
            labelEmails.Name = "labelEmails";
            labelEmails.Size = new Size(41, 15);
            labelEmails.TabIndex = 2;
            labelEmails.Text = "Emails";
            // 
            // labelFamilyName
            // 
            labelFamilyName.AutoSize = true;
            labelFamilyName.Location = new Point(12, 62);
            labelFamilyName.Name = "labelFamilyName";
            labelFamilyName.Size = new Size(77, 15);
            labelFamilyName.TabIndex = 3;
            labelFamilyName.Text = "Family Name";
            // 
            // labelFullyQualifiedPhoneNumbers
            // 
            labelFullyQualifiedPhoneNumbers.AutoSize = true;
            labelFullyQualifiedPhoneNumbers.Location = new Point(12, 176);
            labelFullyQualifiedPhoneNumbers.Name = "labelFullyQualifiedPhoneNumbers";
            labelFullyQualifiedPhoneNumbers.Size = new Size(93, 15);
            labelFullyQualifiedPhoneNumbers.TabIndex = 4;
            labelFullyQualifiedPhoneNumbers.Text = "Phone Numbers";
            // 
            // labelOtherChannels
            // 
            labelOtherChannels.AutoSize = true;
            labelOtherChannels.Location = new Point(12, 234);
            labelOtherChannels.Name = "labelOtherChannels";
            labelOtherChannels.Size = new Size(89, 15);
            labelOtherChannels.TabIndex = 5;
            labelOtherChannels.Text = "Other Channels";
            // 
            // labelRecentNotes
            // 
            labelRecentNotes.AutoSize = true;
            labelRecentNotes.Location = new Point(12, 350);
            labelRecentNotes.Name = "labelRecentNotes";
            labelRecentNotes.Size = new Size(77, 15);
            labelRecentNotes.TabIndex = 6;
            labelRecentNotes.Text = "Recent Notes";
            // 
            // textBoxFamilyName
            // 
            textBoxFamilyName.Location = new Point(12, 80);
            textBoxFamilyName.Name = "textBoxFamilyName";
            textBoxFamilyName.Size = new Size(481, 23);
            textBoxFamilyName.TabIndex = 7;
            // 
            // labelLastConnectionDate
            // 
            labelLastConnectionDate.AutoSize = true;
            labelLastConnectionDate.Location = new Point(12, 293);
            labelLastConnectionDate.Name = "labelLastConnectionDate";
            labelLastConnectionDate.Size = new Size(120, 15);
            labelLastConnectionDate.TabIndex = 8;
            labelLastConnectionDate.Text = "Last Connection Date";
            // 
            // textBoxGivenNames
            // 
            textBoxGivenNames.Location = new Point(12, 27);
            textBoxGivenNames.Name = "textBoxGivenNames";
            textBoxGivenNames.Size = new Size(481, 23);
            textBoxGivenNames.TabIndex = 9;
            // 
            // richTextBoxRecentNotes
            // 
            richTextBoxRecentNotes.Location = new Point(12, 368);
            richTextBoxRecentNotes.Name = "richTextBoxRecentNotes";
            richTextBoxRecentNotes.Size = new Size(481, 96);
            richTextBoxRecentNotes.TabIndex = 10;
            richTextBoxRecentNotes.Text = "";
            // 
            // buttonDiscard
            // 
            buttonDiscard.Location = new Point(418, 470);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(75, 23);
            buttonDiscard.TabIndex = 11;
            buttonDiscard.Text = "Discard";
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(337, 470);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // dateTimePickerLastConnectionDate
            // 
            dateTimePickerLastConnectionDate.Location = new Point(12, 311);
            dateTimePickerLastConnectionDate.Name = "dateTimePickerLastConnectionDate";
            dateTimePickerLastConnectionDate.Size = new Size(481, 23);
            dateTimePickerLastConnectionDate.TabIndex = 13;
            // 
            // textBoxEmails
            // 
            textBoxEmails.Location = new Point(12, 133);
            textBoxEmails.Name = "textBoxEmails";
            textBoxEmails.Size = new Size(481, 23);
            textBoxEmails.TabIndex = 14;
            // 
            // textBoxPhoneNumbers
            // 
            textBoxPhoneNumbers.Location = new Point(12, 194);
            textBoxPhoneNumbers.Name = "textBoxPhoneNumbers";
            textBoxPhoneNumbers.Size = new Size(481, 23);
            textBoxPhoneNumbers.TabIndex = 15;
            // 
            // textBoxOtherChannels
            // 
            textBoxOtherChannels.Location = new Point(12, 252);
            textBoxOtherChannels.Name = "textBoxOtherChannels";
            textBoxOtherChannels.Size = new Size(481, 23);
            textBoxOtherChannels.TabIndex = 16;
            // 
            // ContactDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 505);
            Controls.Add(textBoxOtherChannels);
            Controls.Add(textBoxPhoneNumbers);
            Controls.Add(textBoxEmails);
            Controls.Add(dateTimePickerLastConnectionDate);
            Controls.Add(buttonSave);
            Controls.Add(buttonDiscard);
            Controls.Add(richTextBoxRecentNotes);
            Controls.Add(textBoxGivenNames);
            Controls.Add(labelLastConnectionDate);
            Controls.Add(textBoxFamilyName);
            Controls.Add(labelRecentNotes);
            Controls.Add(labelOtherChannels);
            Controls.Add(labelFullyQualifiedPhoneNumbers);
            Controls.Add(labelFamilyName);
            Controls.Add(labelEmails);
            Controls.Add(labelGivenNames);
            Name = "ContactDetailsForm";
            Text = "ContactDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelGivenNames;
        private Label labelEmails;
        private Label labelFamilyName;
        private Label labelFullyQualifiedPhoneNumbers;
        private Label labelOtherChannels;
        private Label labelRecentNotes;
        private TextBox textBoxFamilyName;
        private Label labelLastConnectionDate;
        private TextBox textBoxGivenNames;
        private RichTextBox richTextBoxRecentNotes;
        private Button buttonDiscard;
        private Button buttonSave;
        private DateTimePicker dateTimePickerLastConnectionDate;
        private TextBox textBoxEmails;
        private TextBox textBoxPhoneNumbers;
        private TextBox textBoxOtherChannels;
    }
}