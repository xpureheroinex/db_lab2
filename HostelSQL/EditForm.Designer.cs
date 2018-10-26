namespace HostelSQL
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.comboBox_Room = new System.Windows.Forms.ComboBox();
            this.comboBox_Benefit = new System.Windows.Forms.ComboBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ColonizeDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_Passport = new System.Windows.Forms.TextBox();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.hostelDataSet = new HostelSQL.HostelDataSet();
            this.benefitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benefitsTableAdapter = new HostelSQL.HostelDataSetTableAdapters.BenefitsTableAdapter();
            this.hostelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new HostelSQL.HostelDataSetTableAdapters.RoomsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new HostelSQL.HostelDataSetTableAdapters.StudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Комната";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Паспорт";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Тип льготы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Группа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Пол";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Дата заселения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ФИО";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(210, 390);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(171, 23);
            this.button_Cancel.TabIndex = 27;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(32, 390);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(149, 23);
            this.button_OK.TabIndex = 26;
            this.button_OK.Text = "Ок";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // comboBox_Room
            // 
            this.comboBox_Room.DataSource = this.roomsBindingSource;
            this.comboBox_Room.DisplayMember = "Id";
            this.comboBox_Room.FormattingEnabled = true;
            this.comboBox_Room.Location = new System.Drawing.Point(210, 333);
            this.comboBox_Room.Name = "comboBox_Room";
            this.comboBox_Room.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Room.TabIndex = 25;
            this.comboBox_Room.ValueMember = "Id";
            // 
            // comboBox_Benefit
            // 
            this.comboBox_Benefit.DataSource = this.benefitsBindingSource;
            this.comboBox_Benefit.DisplayMember = "Type";
            this.comboBox_Benefit.FormattingEnabled = true;
            this.comboBox_Benefit.Location = new System.Drawing.Point(210, 237);
            this.comboBox_Benefit.Name = "comboBox_Benefit";
            this.comboBox_Benefit.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Benefit.TabIndex = 24;
            this.comboBox_Benefit.ValueMember = "Id";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "мужской",
            "женский"});
            this.comboBox_Gender.Location = new System.Drawing.Point(210, 92);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Gender.TabIndex = 23;
            // 
            // dateTimePicker_ColonizeDate
            // 
            this.dateTimePicker_ColonizeDate.Location = new System.Drawing.Point(209, 49);
            this.dateTimePicker_ColonizeDate.Name = "dateTimePicker_ColonizeDate";
            this.dateTimePicker_ColonizeDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ColonizeDate.TabIndex = 22;
            // 
            // textBox_Passport
            // 
            this.textBox_Passport.Location = new System.Drawing.Point(210, 288);
            this.textBox_Passport.Name = "textBox_Passport";
            this.textBox_Passport.Size = new System.Drawing.Size(200, 20);
            this.textBox_Passport.TabIndex = 21;
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(210, 187);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(200, 20);
            this.textBox_Group.TabIndex = 20;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(211, 138);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(200, 20);
            this.textBox_Address.TabIndex = 19;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(210, 13);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(200, 20);
            this.textBox_Name.TabIndex = 18;
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "HostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // benefitsBindingSource
            // 
            this.benefitsBindingSource.DataMember = "Benefits";
            this.benefitsBindingSource.DataSource = this.hostelDataSet;
            // 
            // benefitsTableAdapter
            // 
            this.benefitsTableAdapter.ClearBeforeFill = true;
            // 
            // hostelDataSetBindingSource
            // 
            this.hostelDataSetBindingSource.DataSource = this.hostelDataSet;
            this.hostelDataSetBindingSource.Position = 0;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hostelDataSetBindingSource;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Students";
            this.bindingSource1.DataSource = this.hostelDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 427);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.comboBox_Room);
            this.Controls.Add(this.comboBox_Benefit);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.dateTimePicker_ColonizeDate);
            this.Controls.Add(this.textBox_Passport);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Name);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benefitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ComboBox comboBox_Room;
        private System.Windows.Forms.ComboBox comboBox_Benefit;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ColonizeDate;
        private System.Windows.Forms.TextBox textBox_Passport;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Name;
        private HostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource benefitsBindingSource;
        private HostelDataSetTableAdapters.BenefitsTableAdapter benefitsTableAdapter;
        private System.Windows.Forms.BindingSource hostelDataSetBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HostelDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private HostelDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
    }
}