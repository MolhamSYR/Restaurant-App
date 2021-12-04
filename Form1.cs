using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_OS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_DragOver(object sender, DragEventArgs e)
        {
           
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '*';
            }

            else if (!checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((textBox1.Text == "Admin") && (textBox2.Text == "123"))
            {
                Admin d = new Admin();
                d.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
          
            
        }
    }
}
