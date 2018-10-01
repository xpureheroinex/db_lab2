using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Benefits". При необходимости она может быть перемещена или удалена.
            this.benefitsTableAdapter.Fill(this.hostelDataSet.Benefits);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            roomsTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
            benefitsTableAdapter.Update(hostelDataSet);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
