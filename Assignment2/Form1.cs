using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lblOutput.Text = "";
            txtname.Focus();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name=txtname.Text;
            int studentid=int.Parse(txtstudentid.Text);
            string department=txtdepartment.Text;
            string semester=txtsemester.Text;
            lblOutput.Text = "Name: " + name + "\n" +
                             "Student ID: " + studentid + "\n" +
                             "Department: " + department + "\n" +
                             "Semester: " + semester;
        }
    }
    }
    
