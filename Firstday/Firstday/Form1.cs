using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firstday
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
            MessageBox.Show("Not found.", "「Error 404」");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("박정섭 남친은(는) 백정주 입니다.", "「CODE:GAY」");
        }
    }
}
