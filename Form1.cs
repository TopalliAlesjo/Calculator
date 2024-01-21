using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string Optional = ""; 
        int Num1, Num2, Result = 0;

        private void textBox1_TextChanged(object sender, EventArgs e) // text box
        {
            // nothing
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ChatBox.Text += btn1.Text; // print in textbox number of btn name
        }
        
        private void button2_Click(object sender, EventArgs e) // numero 2
        {
            ChatBox.Text += btn2.Text; // print in textbox number of btn name
        }

        private void btn3_Click(object sender, EventArgs e) // numero 3
        {
            ChatBox.Text += btn3.Text; // print in textbox number of btn name
        }

        private void btn4_Click(object sender, EventArgs e) // numero 4
        {
            ChatBox.Text += btn4.Text; // print in textbox number of btn name
        }

        private void btn5_Click(object sender, EventArgs e) // numero 5
        {
            ChatBox.Text += btn5.Text; // print in textbox number of btn name
        } 

        private void btn6_Click(object sender, EventArgs e) // numero 6
        {
            ChatBox.Text += btn6.Text; // print in textbox number of btn name
        }

        private void btn7_Click(object sender, EventArgs e) // numero 7
        {
            ChatBox.Text += btn7.Text; // print in textbox number of btn name
        }

        private void btn8_Click(object sender, EventArgs e) // numero 8
        {
            ChatBox.Text += btn8.Text; // print in textbox number of btn name
        }

        private void btn9_Click(object sender, EventArgs e) // numero 9
        {
            ChatBox.Text += btn9.Text; // print in textbox number of btn name
        }


        private void btn0_Click(object sender, EventArgs e) // numero 0
        {
            ChatBox.Text += btn0.Text; // print in textbox number of btn name
        }

        private void btnPlus_Click(object sender, EventArgs e) // plus
        {
            Optional = "+"; // add operator 
            Num1 = int.Parse(ChatBox.Text); // take first number
            ChatBox.Clear();
        }


        private void btnMin_Click(object sender, EventArgs e) // minus
        {
            Optional = "-"; // add operator 
            Num1 = int.Parse(ChatBox.Text); // take first number
            ChatBox.Clear();
        }


        private void btnMult_Click(object sender, EventArgs e) // multiplicator
        {
            Optional = "*"; // add operator 
            Num1 = int.Parse(ChatBox.Text); // take first number
            ChatBox.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e) // divisor
        {
            Optional = "/"; // add operator 
            Num1 = int.Parse(ChatBox.Text); // take first number
            ChatBox.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e) // equals
        {
            try { 
                
                Num2 = int.Parse(ChatBox.Text); // take second number 

                ChatBox.Clear(); 

                switch (Optional) // select operator
                {
                    case "+":
                        Result = Num1 + Num2;
                        break;
                    case "-":
                        Result = Num1 - Num2;
                        break;
                    case "*":
                        Result = Num1 * Num2;
                        break;
                    case "/":
                        Result = Num1 / Num2;
                        break;
                    default:
                        MessageBox.Show("Calculator Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                ChatBox.Text = Result + "";
            
            }
            catch {

                MessageBox.Show("Error Try again, click CLEAR" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) ; // seconda stringa titolo

            }

        }

        private void btnClear_Click(object sender, EventArgs e) // refresh all
        {
            ChatBox.Clear();
            Num1 = 0;
            Num2 = 0;
            Result = 0;
            Optional = "";
        }

    }
}
