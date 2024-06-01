using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormApp
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

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = Convert.ToDouble(txt_kor.Text);
                double score2 = Convert.ToDouble(txt_eng.Text);
                double score3 = Convert.ToDouble(txt_math.Text);
                double score4 = Convert.ToDouble(txt_music.Text);
                double score5 = Convert.ToDouble(txt_paint.Text);

                double totalScore = score1 + score2 + score3 + score4 + score5;
                double averageScore = totalScore / 5;

                txt_total.Text = totalScore.ToString();
                txt_avg.Text = averageScore.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("점수를 올바르게 입력해주세요", "제발 쫌");
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_kor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
