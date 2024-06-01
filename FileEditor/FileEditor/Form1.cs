using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                txtFilePath.Text = file_path;

            }
            Console.WriteLine(file_path);
            string[] textvalue = System.IO.File.ReadAllLines(file_path);
            rchTxtBox.Clear();
            if (textvalue.Length > 0)
            {
                for (int i = 0; i < textvalue.Length; i++)
                {
                    string line = i + "번째줄";
                    string svalue = textvalue[i];
                    rchTxtBox.AppendText(line + svalue + "\n");
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
