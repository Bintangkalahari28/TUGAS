namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradient1 = new Kalkulator.Gradient();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.btnHasil = new System.Windows.Forms.Button();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnJumlah = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.gradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient1
            // 
            this.gradient1.Angle = 90F;
            this.gradient1.BackColor = System.Drawing.Color.MidnightBlue;
            this.gradient1.BottomColor = System.Drawing.Color.GreenYellow;
            this.gradient1.Controls.Add(this.btn0);
            this.gradient1.Controls.Add(this.btnKali);
            this.gradient1.Controls.Add(this.txtDisplay2);
            this.gradient1.Controls.Add(this.btnHasil);
            this.gradient1.Controls.Add(this.btnKoma);
            this.gradient1.Controls.Add(this.btnClear);
            this.gradient1.Controls.Add(this.btnBagi);
            this.gradient1.Controls.Add(this.btnKurang);
            this.gradient1.Controls.Add(this.btnJumlah);
            this.gradient1.Controls.Add(this.btn9);
            this.gradient1.Controls.Add(this.btn8);
            this.gradient1.Controls.Add(this.btn7);
            this.gradient1.Controls.Add(this.btn6);
            this.gradient1.Controls.Add(this.btn5);
            this.gradient1.Controls.Add(this.btn4);
            this.gradient1.Controls.Add(this.btn3);
            this.gradient1.Controls.Add(this.btn2);
            this.gradient1.Controls.Add(this.btn1);
            this.gradient1.Controls.Add(this.txtDisplay);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient1.ForeColor = System.Drawing.Color.Black;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(604, 450);
            this.gradient1.TabIndex = 0;
            this.gradient1.TopColor = System.Drawing.Color.Aqua;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(101, 367);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(73, 71);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKali
            // 
            this.btnKali.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnKali.Location = new System.Drawing.Point(285, 367);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(73, 71);
            this.btnKali.TabIndex = 17;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = false;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Location = new System.Drawing.Point(295, 46);
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(33, 15);
            this.txtDisplay2.TabIndex = 16;
            // 
            // btnHasil
            // 
            this.btnHasil.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHasil.Location = new System.Drawing.Point(386, 254);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(196, 158);
            this.btnHasil.TabIndex = 15;
            this.btnHasil.Text = "=";
            this.btnHasil.UseVisualStyleBackColor = false;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // btnKoma
            // 
            this.btnKoma.BackColor = System.Drawing.Color.SkyBlue;
            this.btnKoma.Location = new System.Drawing.Point(386, 191);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(196, 46);
            this.btnKoma.TabIndex = 14;
            this.btnKoma.Text = ",";
            this.btnKoma.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Location = new System.Drawing.Point(386, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(196, 47);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBagi.Location = new System.Drawing.Point(285, 277);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(73, 71);
            this.btnBagi.TabIndex = 12;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = false;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnKurang.Location = new System.Drawing.Point(285, 191);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(73, 71);
            this.btnKurang.TabIndex = 11;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = false;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnJumlah
            // 
            this.btnJumlah.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnJumlah.Location = new System.Drawing.Point(285, 111);
            this.btnJumlah.Name = "btnJumlah";
            this.btnJumlah.Size = new System.Drawing.Size(73, 71);
            this.btnJumlah.TabIndex = 10;
            this.btnJumlah.Text = "+";
            this.btnJumlah.UseVisualStyleBackColor = false;
            this.btnJumlah.Click += new System.EventHandler(this.btnJumlah_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(190, 277);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(73, 71);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(101, 277);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 71);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(12, 277);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(73, 71);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(190, 191);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(73, 71);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(101, 191);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 71);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(12, 191);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 71);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(190, 111);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(73, 71);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(101, 111);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 71);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(12, 111);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(73, 71);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(285, 34);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(297, 53);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.gradient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient gradient1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button btnKoma;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnJumlah;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.TextBox txtDisplay2;
    }
}

