namespace WinFormApp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_paint = new System.Windows.Forms.MaskedTextBox();
            this.txt_music = new System.Windows.Forms.MaskedTextBox();
            this.txt_math = new System.Windows.Forms.MaskedTextBox();
            this.txt_kor = new System.Windows.Forms.TextBox();
            this.txt_eng = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_avg = new System.Windows.Forms.MaskedTextBox();
            this.txt_total = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_paint);
            this.groupBox1.Controls.Add(this.txt_music);
            this.groupBox1.Controls.Add(this.txt_math);
            this.groupBox1.Controls.Add(this.txt_kor);
            this.groupBox1.Controls.Add(this.txt_eng);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "과목별 성적";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_paint
            // 
            this.txt_paint.Location = new System.Drawing.Point(126, 168);
            this.txt_paint.Name = "txt_paint";
            this.txt_paint.Size = new System.Drawing.Size(282, 21);
            this.txt_paint.TabIndex = 9;
            // 
            // txt_music
            // 
            this.txt_music.Location = new System.Drawing.Point(126, 135);
            this.txt_music.Name = "txt_music";
            this.txt_music.Size = new System.Drawing.Size(282, 21);
            this.txt_music.TabIndex = 8;
            // 
            // txt_math
            // 
            this.txt_math.Location = new System.Drawing.Point(126, 104);
            this.txt_math.Name = "txt_math";
            this.txt_math.Size = new System.Drawing.Size(282, 21);
            this.txt_math.TabIndex = 7;
            // 
            // txt_kor
            // 
            this.txt_kor.Location = new System.Drawing.Point(126, 40);
            this.txt_kor.Name = "txt_kor";
            this.txt_kor.Size = new System.Drawing.Size(282, 21);
            this.txt_kor.TabIndex = 6;
            this.txt_kor.Tag = "";
            this.txt_kor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_kor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kor_KeyPress);
            // 
            // txt_eng
            // 
            this.txt_eng.Location = new System.Drawing.Point(126, 72);
            this.txt_eng.Name = "txt_eng";
            this.txt_eng.Size = new System.Drawing.Size(282, 21);
            this.txt_eng.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "미술";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "음악";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "수학";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "영어";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "계산";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_avg);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 113);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_avg
            // 
            this.txt_avg.Location = new System.Drawing.Point(71, 73);
            this.txt_avg.Name = "txt_avg";
            this.txt_avg.ReadOnly = true;
            this.txt_avg.Size = new System.Drawing.Size(130, 21);
            this.txt_avg.TabIndex = 14;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(71, 30);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(130, 21);
            this.txt_total.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "평균";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "총점";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "성적계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_paint;
        private System.Windows.Forms.MaskedTextBox txt_music;
        private System.Windows.Forms.MaskedTextBox txt_math;
        private System.Windows.Forms.TextBox txt_kor;
        private System.Windows.Forms.MaskedTextBox txt_eng;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txt_avg;
        private System.Windows.Forms.MaskedTextBox txt_total;
    }
}

