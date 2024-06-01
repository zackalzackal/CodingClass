using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
            
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_eql_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if(currentOperator == Operators.Add)
            {
                firstOperand = secondOperand;
                display.Text = firstOperand.ToString();
            } else if(currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            } else if(currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            } else if(currentOperator == Operators.Divide)
            {
                if(secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                } else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {

        }

        private void btn_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {

        }

        private void btn_6_Click(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {

        }

        private void btn_8_Click(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {

        }

        private void btn_pls_Click(object sender, EventArgs e)
        {

        }

        private void btn_mns_Click(object sender, EventArgs e)
        {

        }

        private void btn_mlty_Click(object sender, EventArgs e)
        {

        }

        private void btn_dvd_Click(object sender, EventArgs e)
        {

        }

        private void btn_pnt_Click(object sender, EventArgs e)
        {

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {

        }
    }
}
