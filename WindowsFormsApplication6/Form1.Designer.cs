namespace WindowsFormsApplication6
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.Q1A = new System.Windows.Forms.RadioButton();
            this.Q1B = new System.Windows.Forms.RadioButton();
            this.Q1C = new System.Windows.Forms.RadioButton();
            this.Q2A = new System.Windows.Forms.RadioButton();
            this.Q2B = new System.Windows.Forms.RadioButton();
            this.Q2C = new System.Windows.Forms.RadioButton();
            this.Q2D = new System.Windows.Forms.RadioButton();
            this.Q3A = new System.Windows.Forms.RadioButton();
            this.Q3B = new System.Windows.Forms.RadioButton();
            this.Q3C = new System.Windows.Forms.RadioButton();
            this.Q3D = new System.Windows.Forms.RadioButton();
            this.Q4A = new System.Windows.Forms.RadioButton();
            this.Q4B = new System.Windows.Forms.RadioButton();
            this.Q4C = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Q1D = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Q4D = new System.Windows.Forms.RadioButton();
            this.LoadExam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(273, 400);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit Exam";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Q1A
            // 
            this.Q1A.AutoSize = true;
            this.Q1A.Location = new System.Drawing.Point(6, 36);
            this.Q1A.Name = "Q1A";
            this.Q1A.Size = new System.Drawing.Size(14, 13);
            this.Q1A.TabIndex = 2;
            this.Q1A.TabStop = true;
            this.Q1A.UseVisualStyleBackColor = true;
            this.Q1A.CheckedChanged += new System.EventHandler(this.Q1A_CheckedChanged);
            // 
            // Q1B
            // 
            this.Q1B.AutoSize = true;
            this.Q1B.Location = new System.Drawing.Point(6, 60);
            this.Q1B.Name = "Q1B";
            this.Q1B.Size = new System.Drawing.Size(14, 13);
            this.Q1B.TabIndex = 3;
            this.Q1B.TabStop = true;
            this.Q1B.UseVisualStyleBackColor = true;
            this.Q1B.CheckedChanged += new System.EventHandler(this.Q1B_CheckedChanged);
            // 
            // Q1C
            // 
            this.Q1C.AutoSize = true;
            this.Q1C.Location = new System.Drawing.Point(6, 84);
            this.Q1C.Name = "Q1C";
            this.Q1C.Size = new System.Drawing.Size(14, 13);
            this.Q1C.TabIndex = 4;
            this.Q1C.TabStop = true;
            this.Q1C.UseVisualStyleBackColor = true;
            this.Q1C.CheckedChanged += new System.EventHandler(this.Q1C_CheckedChanged);
            // 
            // Q2A
            // 
            this.Q2A.AutoSize = true;
            this.Q2A.Location = new System.Drawing.Point(6, 54);
            this.Q2A.Name = "Q2A";
            this.Q2A.Size = new System.Drawing.Size(14, 13);
            this.Q2A.TabIndex = 7;
            this.Q2A.TabStop = true;
            this.Q2A.UseVisualStyleBackColor = true;
            this.Q2A.CheckedChanged += new System.EventHandler(this.Q2A_CheckedChanged);
            // 
            // Q2B
            // 
            this.Q2B.AutoSize = true;
            this.Q2B.Location = new System.Drawing.Point(6, 78);
            this.Q2B.Name = "Q2B";
            this.Q2B.Size = new System.Drawing.Size(14, 13);
            this.Q2B.TabIndex = 8;
            this.Q2B.TabStop = true;
            this.Q2B.UseVisualStyleBackColor = true;
            this.Q2B.CheckedChanged += new System.EventHandler(this.Q2B_CheckedChanged);
            // 
            // Q2C
            // 
            this.Q2C.AutoSize = true;
            this.Q2C.Location = new System.Drawing.Point(6, 102);
            this.Q2C.Name = "Q2C";
            this.Q2C.Size = new System.Drawing.Size(14, 13);
            this.Q2C.TabIndex = 9;
            this.Q2C.TabStop = true;
            this.Q2C.UseVisualStyleBackColor = true;
            this.Q2C.CheckedChanged += new System.EventHandler(this.Q2C_CheckedChanged);
            // 
            // Q2D
            // 
            this.Q2D.AutoSize = true;
            this.Q2D.Location = new System.Drawing.Point(6, 125);
            this.Q2D.Name = "Q2D";
            this.Q2D.Size = new System.Drawing.Size(14, 13);
            this.Q2D.TabIndex = 10;
            this.Q2D.TabStop = true;
            this.Q2D.UseVisualStyleBackColor = true;
            this.Q2D.CheckedChanged += new System.EventHandler(this.Q2D_CheckedChanged);
            // 
            // Q3A
            // 
            this.Q3A.AutoSize = true;
            this.Q3A.Location = new System.Drawing.Point(6, 54);
            this.Q3A.Name = "Q3A";
            this.Q3A.Size = new System.Drawing.Size(14, 13);
            this.Q3A.TabIndex = 12;
            this.Q3A.TabStop = true;
            this.Q3A.UseVisualStyleBackColor = true;
            this.Q3A.CheckedChanged += new System.EventHandler(this.Q3A_CheckedChanged);
            // 
            // Q3B
            // 
            this.Q3B.AutoSize = true;
            this.Q3B.Location = new System.Drawing.Point(6, 77);
            this.Q3B.Name = "Q3B";
            this.Q3B.Size = new System.Drawing.Size(14, 13);
            this.Q3B.TabIndex = 13;
            this.Q3B.TabStop = true;
            this.Q3B.UseVisualStyleBackColor = true;
            this.Q3B.CheckedChanged += new System.EventHandler(this.Q3B_CheckedChanged);
            // 
            // Q3C
            // 
            this.Q3C.AutoSize = true;
            this.Q3C.Location = new System.Drawing.Point(6, 100);
            this.Q3C.Name = "Q3C";
            this.Q3C.Size = new System.Drawing.Size(14, 13);
            this.Q3C.TabIndex = 14;
            this.Q3C.TabStop = true;
            this.Q3C.UseVisualStyleBackColor = true;
            this.Q3C.CheckedChanged += new System.EventHandler(this.Q3C_CheckedChanged);
            // 
            // Q3D
            // 
            this.Q3D.AutoSize = true;
            this.Q3D.Location = new System.Drawing.Point(6, 123);
            this.Q3D.Name = "Q3D";
            this.Q3D.Size = new System.Drawing.Size(14, 13);
            this.Q3D.TabIndex = 15;
            this.Q3D.TabStop = true;
            this.Q3D.UseVisualStyleBackColor = true;
            this.Q3D.CheckedChanged += new System.EventHandler(this.Q3D_CheckedChanged);
            // 
            // Q4A
            // 
            this.Q4A.AutoSize = true;
            this.Q4A.Location = new System.Drawing.Point(6, 34);
            this.Q4A.Name = "Q4A";
            this.Q4A.Size = new System.Drawing.Size(14, 13);
            this.Q4A.TabIndex = 17;
            this.Q4A.TabStop = true;
            this.Q4A.UseVisualStyleBackColor = true;
            this.Q4A.CheckedChanged += new System.EventHandler(this.Q4A_CheckedChanged);
            // 
            // Q4B
            // 
            this.Q4B.AutoSize = true;
            this.Q4B.Location = new System.Drawing.Point(6, 57);
            this.Q4B.Name = "Q4B";
            this.Q4B.Size = new System.Drawing.Size(14, 13);
            this.Q4B.TabIndex = 18;
            this.Q4B.TabStop = true;
            this.Q4B.UseVisualStyleBackColor = true;
            this.Q4B.CheckedChanged += new System.EventHandler(this.Q4B_CheckedChanged);
            // 
            // Q4C
            // 
            this.Q4C.AutoSize = true;
            this.Q4C.Location = new System.Drawing.Point(6, 80);
            this.Q4C.Name = "Q4C";
            this.Q4C.Size = new System.Drawing.Size(14, 13);
            this.Q4C.TabIndex = 19;
            this.Q4C.TabStop = true;
            this.Q4C.UseVisualStyleBackColor = true;
            this.Q4C.CheckedChanged += new System.EventHandler(this.Q4C_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(544, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 209);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Q1A);
            this.groupBox1.Controls.Add(this.Q1B);
            this.groupBox1.Controls.Add(this.Q1C);
            this.groupBox1.Controls.Add(this.Q1D);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // Q1D
            // 
            this.Q1D.AutoSize = true;
            this.Q1D.Location = new System.Drawing.Point(6, 108);
            this.Q1D.Name = "Q1D";
            this.Q1D.Size = new System.Drawing.Size(14, 13);
            this.Q1D.TabIndex = 5;
            this.Q1D.TabStop = true;
            this.Q1D.UseVisualStyleBackColor = true;
            this.Q1D.CheckedChanged += new System.EventHandler(this.Q1D_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Q2A);
            this.groupBox2.Controls.Add(this.Q2B);
            this.groupBox2.Controls.Add(this.Q2C);
            this.groupBox2.Controls.Add(this.Q2D);
            this.groupBox2.Location = new System.Drawing.Point(18, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 139);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Q3A);
            this.groupBox3.Controls.Add(this.Q3B);
            this.groupBox3.Controls.Add(this.Q3C);
            this.groupBox3.Controls.Add(this.Q3D);
            this.groupBox3.Location = new System.Drawing.Point(251, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 139);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Q4A);
            this.groupBox4.Controls.Add(this.Q4B);
            this.groupBox4.Controls.Add(this.Q4C);
            this.groupBox4.Controls.Add(this.Q4D);
            this.groupBox4.Location = new System.Drawing.Point(251, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 124);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            // 
            // Q4D
            // 
            this.Q4D.AutoSize = true;
            this.Q4D.Location = new System.Drawing.Point(6, 105);
            this.Q4D.Name = "Q4D";
            this.Q4D.Size = new System.Drawing.Size(14, 13);
            this.Q4D.TabIndex = 27;
            this.Q4D.TabStop = true;
            this.Q4D.UseVisualStyleBackColor = true;
            this.Q4D.CheckedChanged += new System.EventHandler(this.Q4D_CheckedChanged);
            // 
            // LoadExam
            // 
            this.LoadExam.Location = new System.Drawing.Point(18, 20);
            this.LoadExam.Name = "LoadExam";
            this.LoadExam.Size = new System.Drawing.Size(106, 38);
            this.LoadExam.TabIndex = 28;
            this.LoadExam.Text = "Load Exam";
            this.LoadExam.UseVisualStyleBackColor = true;
            this.LoadExam.Click += new System.EventHandler(this.LoadExam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.LoadExam);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.RadioButton Q1A;
        private System.Windows.Forms.RadioButton Q1B;
        private System.Windows.Forms.RadioButton Q1C;
        private System.Windows.Forms.RadioButton Q2A;
        private System.Windows.Forms.RadioButton Q2B;
        private System.Windows.Forms.RadioButton Q2C;
        private System.Windows.Forms.RadioButton Q2D;
        private System.Windows.Forms.RadioButton Q3A;
        private System.Windows.Forms.RadioButton Q3B;
        private System.Windows.Forms.RadioButton Q3C;
        private System.Windows.Forms.RadioButton Q3D;
        private System.Windows.Forms.RadioButton Q4A;
        private System.Windows.Forms.RadioButton Q4B;
        private System.Windows.Forms.RadioButton Q4C;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton Q1D;
        private System.Windows.Forms.RadioButton Q4D;
        private System.Windows.Forms.Button LoadExam;

    }
}

