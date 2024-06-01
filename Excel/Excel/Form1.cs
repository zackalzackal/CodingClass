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

namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        List<string> kor = new List<string>();
        List<string> eng = new List<string>();
        List<string> math = new List<string>();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("C:/hjb/score.csv");
            DataTable table = new DataTable();
            table.Columns.Add("이름");
            table.Columns.Add("국어");
            table.Columns.Add("영어");
            table.Columns.Add("수학");
            table.Columns.Add("총점");
            table.Columns.Add("평균");
            while (!file.EndOfStream)
            {
                string line = file.ReadLine();

                String[] data = line.Split(',');

                int totalScore = int.Parse(data[1]) + int.Parse(data[2]) + int.Parse(data[3]);
                double avgScore = (double)totalScore / 3;
                table.Rows.Add(data[0], data[1], data[2], data[3], totalScore, Math.Round(avgScore, 2));
            }
            grdView.DataSource = table;
            grdView.Columns[4].ReadOnly = true;
            grdView.Columns[5].ReadOnly = true;
            grdView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grdView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
        }

        private void Grd(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int chgRow = e.RowIndex;
            int chgCol = e.ColumnIndex;

            int korScore = int.Parse(grdView.Rows[chgRow].Cells[1].Value.ToString());
            int EngScore = int.Parse(grdView.Rows[chgRow].Cells[2].Value.ToString());
            int mathScore = int.Parse(grdView.Rows[chgRow].Cells[3].Value.ToString());

            int totalScore = korScore + EngScore + mathScore;
            double avgScore = (double)totalScore / 3;

            grdView.Rows[chgRow].Cells[4].Value = totalScore.ToString();
            grdView.Rows[chgRow].Cells[5].Value = Math.Round(avgScore,2).ToString();
        }
    }
}
