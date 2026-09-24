using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Àssignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            // create variable of initial
            string std_name = txtname.Text;
            string std_id = txtstudentid.Text;
            string std_dept = txtdepartment.Text;
            string std_semester = txtsemester.Text;

            // concatinating the vraibles
            string student = std_name + std_id + std_dept + std_semester;

            // displaying the output
            lbloutput.Text = student;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // clearing the inputs and outputs
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            lbloutput.Text = "";


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
