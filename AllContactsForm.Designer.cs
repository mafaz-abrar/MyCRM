namespace MyCRM
{
    partial class AllContactsForm
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
            components = new System.ComponentModel.Container();
            labelTitle = new Label();
            dataGridViewMain = new DataGridView();
            buttonAdd = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            bindingSourceContactsSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceContactsSource).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(12, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(71, 15);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "All Contacts";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(12, 49);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.Size = new Size(939, 233);
            dataGridViewMain.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(714, 288);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add New";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(876, 288);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(795, 288);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // AllContactsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 323);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewMain);
            Controls.Add(labelTitle);
            Name = "AllContactsForm";
            Text = "AllContactsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceContactsSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private DataGridView dataGridViewMain;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonEdit;
        private BindingSource bindingSourceContactsSource;
    }
}