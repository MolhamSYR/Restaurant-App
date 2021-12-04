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
    public partial class ResturantWin : Form
    {
        public ResturantWin()
        {
            InitializeComponent();
            
        }
        string newL = Environment.NewLine;
        private int price;
        private int amount = 1;
        private int finalprice;

        private void ResturantWin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox3.SelectedItem.ToString())
            {
                case "Chicken Nuggets - 10$":
                    price += 10;
                    break;
                case "Burger - 5$":
                    price += 5;
                    break;
                case "Cheese Burger - 7$":
                    price += 7;
                    break;

                default:
                    break;

            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Fried Potato - 3$":
                    price += 3;
                    break;
                case "Rice - 5$":
                    price += 5;
                    break;
                default:
                    break;

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "The Total Cost is:" + newL + "" + price * amount+ "$" + newL + "Press Submit to submit your order!";
            MessageBox.Show("The final cost has been calculated!" + newL + "Feel free press Submit to submit your order!");
            finalprice = price * amount;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            amount = Convert.ToInt16(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mainMeal = comboBox3.SelectedItem.ToString();
            string secondMeal = comboBox1.SelectedItem.ToString();

            listBox1.Items.Add(mainMeal);
            listBox1.Items.Add(secondMeal);
            listBox1.Items.Add(newL);
            listBox1.Items.Add("Number of times to make this meal: " + newL + " " + amount);
            listBox1.Items.Add(newL);
            listBox1.Items.Add("Total Cost:" + newL + " " + finalprice + "$");

            listBox1.Items.Add("Press Send To Kitchen to submit");
            listBox1.Items.Add("your order to the restaurant!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                string mainMeal = comboBox3.SelectedItem.ToString();
                string secondMeal = comboBox1.SelectedItem.ToString();

                Admin.kitWin.Items.Add(mainMeal);
                Admin.kitWin.Items.Add(secondMeal);
                Admin.kitWin.Items.Add(newL);
                Admin.kitWin.Items.Add("Number of times to make this meal: " + newL + " " + amount);
                Admin.kitWin.Items.Add(newL);
                Admin.kitWin.Items.Add("Total Cost:" + newL + " " + finalprice + "$");
                MessageBox.Show("Your Order has been delivered to the kitchen" + newL + "Please Be patient and wait for your food to be ready!");
            
            
        }
    }
}
