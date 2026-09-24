using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace homework_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            // create variable of initial
            string dayOfWeek = dayOfWeekTextBox.Text;
            string monthName = monthTextBox.Text;
            string dayOfMonth = dayOfMonthTextBox.Text;
            int year = int.Parse(yearPromptLabel.Text);

            // concatinating the vraibles
            string full_data = dayOfWeek + monthName + dayOfMonth + year;

            // displaying the output
            dateOutputLabel.Text = full_data;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing the inputs and outputs
            dayOfWeekTextBox.Clear();
            monthTextBox.Clear();
            dayOfMonthTextBox.Clear();
            yearTextBox.Clear();

            dateOutputLabel.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
