using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int firstNumber;
        int secondNumber;
        int returnValue = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);
            AddUp(firstNumber, secondNumber);
            returnValue = AddUp(firstNumber, secondNumber);
            MessageBox.Show(returnValue.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);
            sub(firstNumber, secondNumber);
            returnValue = sub(firstNumber, secondNumber);
            MessageBox.Show(returnValue.ToString());

        }
        private void button3_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);
            div(firstNumber, secondNumber);
            returnValue = div(firstNumber, secondNumber);
            MessageBox.Show(returnValue.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);
            multi(firstNumber, secondNumber);
            returnValue = multi(firstNumber, secondNumber);
            MessageBox.Show(returnValue.ToString());
        }
        //=======================================
        //    Methods              
        //========================================
        int AddUp(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber + secondNumber;
            return answer;
        }

        int sub(int firstNummber, int secondNumber)
        {
            int answer;
            answer = firstNumber - secondNumber;
            return answer;
        }

        int div(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber / secondNumber;
            return answer;
        }

        int multi(int firstNumber, int secondNumber)
        {
            int answer;
            answer = firstNumber * secondNumber;
            return answer;
        }
    }
}
