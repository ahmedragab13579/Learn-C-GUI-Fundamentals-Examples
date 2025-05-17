using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Station
{
    public partial class MainMenu : Form
    {
        private string TotalToppings;
        public MainMenu()
        {
            InitializeComponent();

        }

        
        //======================================================================
        private void textBox1TextChanged()
        {
            if(radioButton1.Checked)
            {
                textBox2.Text = radioButton1.Text;
            }
            
            else if(radioButton2.Checked)
            {
                textBox2.Text = radioButton2.Text;

            }
            else if(radioButton3.Checked)
            {
                textBox2.Text = radioButton3.Text;

            }
        }
        //======================================================================
        private void textBox4TextChanged()
        {

            if (radioButton4.Checked)
            {
                textBox4.Text = radioButton4.Text;
            }

            if (radioButton5.Checked)
            {
                textBox4.Text = radioButton5.Text;

            }
        }
        //======================================================================
        private void textBox3TextChanged()
        {

            if (radioButton7.Checked)
            {
                textBox3.Text = radioButton7.Text;
            }

            if (radioButton8.Checked)
            {
                textBox3.Text = radioButton8.Text;

            }
        }

        //======================================================================
        private int Calculate_Size_Price()
        {
            if (radioButton1.Checked)
            {
                return int.Parse(radioButton1.Tag.ToString());
            }  
            if (radioButton2.Checked)
            {
                return int.Parse(radioButton2.Tag.ToString());
            }
            if (radioButton3.Checked)
            {
                return int.Parse(radioButton3.Tag.ToString());
            }

            return 0;


        } 
      
        private int Calculate_Crust_Price()
        {
            if (radioButton4.Checked)
            {
                return int.Parse( radioButton4.Tag.ToString());
            }  
            if (radioButton5.Checked)
            {
                return int.Parse(radioButton5.Tag.ToString());
            }

            return 0;


        }
      
        private int Calculate_Toppings_Price()
        {
        
            int total = 0;
            if (checkBox1.Checked) total += int.Parse(checkBox1.Tag.ToString());
            if (checkBox2.Checked) total += int.Parse(checkBox2.Tag.ToString());
            if (checkBox3.Checked) total += int.Parse(checkBox3.Tag.ToString());
            if (checkBox4.Checked) total += int.Parse(checkBox4.Tag.ToString());
            if (checkBox5.Checked) total += int.Parse(checkBox5.Tag.ToString());
            if (checkBox6.Checked) total += int.Parse(checkBox6.Tag.ToString());

            return total;
        }

        private int Calculate_Total_Price()
        {
            int TotalPrice = 0;
            TotalPrice += (Calculate_Size_Price());
            TotalPrice += (Calculate_Crust_Price());
            TotalPrice += (Calculate_Toppings_Price());
            return TotalPrice*(int)numericUpDown1.Value;

        }

        private void Show_Total_Price()
        {
            int Price = Calculate_Total_Price();
            label8.Text = Price.ToString();
        }

        //======================================================================
        private string Calculate_Total_Toppings()
        {
            string total = "";
            if (checkBox1.Checked) total += checkBox1.Text.ToString()+",";
            if (checkBox2.Checked) total += checkBox2.Text.ToString()+",";
            if (checkBox3.Checked) total += checkBox3.Text.ToString()+",";
            if (checkBox4.Checked) total += checkBox4.Text.ToString()+",";
            if (checkBox5.Checked) total += checkBox5.Text.ToString()+",";
            if (checkBox6.Checked) total += checkBox6.Text.ToString();
                                                     
            return total.ToString();


        }
        private void Show_Total_Toppings()
        {
            label9.ForeColor = Color.Red;
            label9.Text = Calculate_Total_Toppings();

        }

        //======================================================================
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            textBox1TextChanged();
            Show_Total_Price();
        } 
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            textBox1TextChanged();
            Show_Total_Price();
        } 
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            textBox1TextChanged();
            Show_Total_Price();
        }

        //======================================================================
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox4TextChanged();
            Show_Total_Price();
        }  
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox4TextChanged();
            Show_Total_Price();
        }


        //======================================================================
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Show_Total_Toppings();
            Show_Total_Price();
        } 
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

          
            Show_Total_Toppings();
          
            Show_Total_Price();
        } 
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

          
            Show_Total_Toppings();
          
            Show_Total_Price();
        } 
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

          
            Show_Total_Toppings();
          
            Show_Total_Price();
        } 
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

          
            Show_Total_Toppings();
          
            Show_Total_Price();
        } 
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

          
            Show_Total_Toppings();
          
            Show_Total_Price();
        }

        //======================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you shure","Finish Message ",MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
                {
                ATM form3 = new ATM();
                form3.ShowDialog();
                Close();
                }
        }

        //======================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            radioButton4.Checked = false;
            radioButton5.Checked = false;

            radioButton7.Checked = false;
            radioButton8.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label8.Text = "0";
            label9.Text = "No Toppings";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Show_Total_Price();
        }

        //======================================================================

    }
}
