using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthCalendar_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.BoldedDates = new DateTime[]
            {
                new DateTime(2023,2,21),
                DateTime.Today.AddDays(5)
            };
        }

        private void buttonData_Click(object sender, EventArgs e)
        {
            DateTime inici = monthCalendar1.SelectionStart;
            DateTime final = monthCalendar1.SelectionEnd;

            labelInici.Text = inici.ToString();
            labelFinal.Text = final.ToString();
        }
    }
}
