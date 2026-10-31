using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter writes;

            writes = File.CreateText("output.txt");

            writes.WriteLine("Hello World");
            writes.WriteLine("Welcome to C#");
            writes.WriteLine("My name is Ahmed");
            writes.WriteLine("This is my Test file");

            writes.Close();

            MessageBox.Show("File Created");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (File.Exists("output.txt"))
            {
                File.Delete("output.txt");
                listBox1.Items.Clear();

                MessageBox.Show("File Deleted");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("output.txt"))
            {
                StreamReader reads;

                reads = File.OpenText("output.txt");

                while (!reads.EndOfStream)
                {
                    string line = reads.ReadLine();
                    listBox1.Items.Add(line);
                }

                reads.Close();
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter writes;

            writes = File.AppendText("output.txt");

            writes.WriteLine("New Text Added");

            writes.Close();

            MessageBox.Show("Text Added");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if (File.Exists("output.txt"))
            {
                MessageBox.Show("File Exists");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (File.Exists("output.txt"))
            {
                File.Copy("output.txt", "copy.txt", true);

                MessageBox.Show("File Copied");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (File.Exists("output.txt"))
            {
                if (!File.Exists("newfile.txt"))
                {
                    File.Move("output.txt", "newfile.txt");

                    MessageBox.Show("File Renamed");
                }
                else
                {
                    MessageBox.Show("New File Already Exists");
                }
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }
    }
    }
    
    
    