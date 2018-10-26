using System;
using System.Windows.Forms;
namespace HostelSQL
{
    public partial class EditForm : Form
    {
        /// <summary>
        /// Id студента
        /// </summary>
        private readonly int id;
        /// <summary>
        /// true - если запись модифицируется, false - если создаѐтся новая
        /// </summary>
        readonly bool edit;
        /// <summary>
        /// конструктор формы, для создания новой записи
        /// </summary>
        public EditForm()
        {
            InitializeComponent();
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            edit = false;
        }
        /// <summary>
        /// конструктор формы, для модификации уже существующей записи
        /// </summary>
        /// <param name="name">ФИО</param>
        /// <param name="colonizeDate">Дата заселения</param>
        /// <param name="gender">Пол</param>
        /// <param name="address">Адрес</param>
        /// <param name="group">Группа</param>
        /// <param name="benefitCode">Тип льготы</param>
        /// <param name="passport">Паспорт</param>
        /// <param name="roomNumber">Номер комнаты</param>
        /// <param name="id">ID студента</param>
        public EditForm(int id, String name, string gender, string address, string group, string passport,
       int benefitCode, int roomNumber, DateTime colonizeDate)
        : this()
        {
            roomsTableAdapter.Fill(hostelDataSet.Rooms);
            benefitsTableAdapter.Fill(hostelDataSet.Benefits);
            edit = true;
            this.id = id;
            textBox_Name.Text = name;
            dateTimePicker_ColonizeDate.Value = colonizeDate;
            switch (gender.ToUpper())
            {
                case "мужской":
                    comboBox_Gender.SelectedIndex = 0;
                    break;
                case "женский":
                    comboBox_Gender.SelectedIndex = 1;
                    break;
                default:
                    comboBox_Gender.SelectedIndex = 0;
                    break;
            }
            textBox_Address.Text = address;
            textBox_Group.Text = group;
            comboBox_Benefit.SelectedValue = benefitCode;
            textBox_Passport.Text = passport;
            comboBox_Room.SelectedValue = roomNumber;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (comboBox_Gender.SelectedIndex == 0)
            {
                gender = "мужской";
            }
            else if (comboBox_Gender.SelectedIndex == 1)
            {
                gender = "женский";
            }
            if (edit)
            {
                studentsTableAdapter.UpdateQuery(textBox_Name.Text, gender, textBox_Address.Text,
               textBox_Group.Text, textBox_Passport.Text, Convert.ToInt32(comboBox_Benefit.SelectedValue),
               Convert.ToInt32(comboBox_Room.SelectedValue), dateTimePicker_ColonizeDate.Value.ToString(),
               id);
            }
            else
            {
                studentsTableAdapter.Insert(textBox_Name.Text, gender, textBox_Address.Text,
               textBox_Group.Text, textBox_Passport.Text, Convert.ToInt32(comboBox_Benefit.SelectedValue),
               Convert.ToInt32(comboBox_Room.SelectedValue), dateTimePicker_ColonizeDate.Value);
            }
            Close();
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}