namespace WindowsFormsApplication5
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
            this.GoBtn = new System.Windows.Forms.Button();
            this.firstNumtxtBox = new System.Windows.Forms.TextBox();
            this.secNumTxtBox = new System.Windows.Forms.TextBox();
            this.clrBtn = new System.Windows.Forms.Button();
            this.addRdBtn = new System.Windows.Forms.RadioButton();
            this.subtRdBtn = new System.Windows.Forms.RadioButton();
            this.divRdBtn = new System.Windows.Forms.RadioButton();
            this.multRdBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ansTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBtn
            // 
            this.GoBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBtn.Location = new System.Drawing.Point(35, 405);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(106, 26);
            this.GoBtn.TabIndex = 0;
            this.GoBtn.Text = "Calculate";
            this.GoBtn.UseVisualStyleBackColor = true;
            this.GoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNumtxtBox
            // 
            this.firstNumtxtBox.Location = new System.Drawing.Point(176, 29);
            this.firstNumtxtBox.Name = "firstNumtxtBox";
            this.firstNumtxtBox.Size = new System.Drawing.Size(88, 26);
            this.firstNumtxtBox.TabIndex = 1;
            this.firstNumtxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // secNumTxtBox
            // 
            this.secNumTxtBox.Location = new System.Drawing.Point(176, 68);
            this.secNumTxtBox.Name = "secNumTxtBox";
            this.secNumTxtBox.Size = new System.Drawing.Size(88, 26);
            this.secNumTxtBox.TabIndex = 2;
            this.secNumTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clrBtn
            // 
            this.clrBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.Location = new System.Drawing.Point(208, 404);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(105, 27);
            this.clrBtn.TabIndex = 5;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // addRdBtn
            // 
            this.addRdBtn.AutoSize = true;
            this.addRdBtn.Location = new System.Drawing.Point(33, 25);
            this.addRdBtn.Name = "addRdBtn";
            this.addRdBtn.Size = new System.Drawing.Size(53, 22);
            this.addRdBtn.TabIndex = 6;
            this.addRdBtn.TabStop = true;
            this.addRdBtn.Text = "add";
            this.addRdBtn.UseVisualStyleBackColor = true;
            // 
            // subtRdBtn
            // 
            this.subtRdBtn.AutoSize = true;
            this.subtRdBtn.Location = new System.Drawing.Point(33, 68);
            this.subtRdBtn.Name = "subtRdBtn";
            this.subtRdBtn.Size = new System.Drawing.Size(81, 22);
            this.subtRdBtn.TabIndex = 7;
            this.subtRdBtn.TabStop = true;
            this.subtRdBtn.Text = "subtract";
            this.subtRdBtn.UseVisualStyleBackColor = true;
            // 
            // divRdBtn
            // 
            this.divRdBtn.AutoSize = true;
            this.divRdBtn.Location = new System.Drawing.Point(128, 25);
            this.divRdBtn.Name = "divRdBtn";
            this.divRdBtn.Size = new System.Drawing.Size(68, 22);
            this.divRdBtn.TabIndex = 8;
            this.divRdBtn.TabStop = true;
            this.divRdBtn.Text = "divide";
            this.divRdBtn.UseVisualStyleBackColor = true;
            // 
            // multRdBtn
            // 
            this.multRdBtn.AutoSize = true;
            this.multRdBtn.Location = new System.Drawing.Point(128, 68);
            this.multRdBtn.Name = "multRdBtn";
            this.multRdBtn.Size = new System.Drawing.Size(77, 22);
            this.multRdBtn.TabIndex = 9;
            this.multRdBtn.TabStop = true;
            this.multRdBtn.Text = "multiply";
            this.multRdBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simple Calculator";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ansTxtBox
            // 
            this.ansTxtBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansTxtBox.Location = new System.Drawing.Point(136, 343);
            this.ansTxtBox.Name = "ansTxtBox";
            this.ansTxtBox.Size = new System.Drawing.Size(83, 26);
            this.ansTxtBox.TabIndex = 11;
            this.ansTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ansTxtBox.TextChanged += new System.EventHandler(this.ansTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Answer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.multRdBtn);
            this.groupBox1.Controls.Add(this.divRdBtn);
            this.groupBox1.Controls.Add(this.subtRdBtn);
            this.groupBox1.Controls.Add(this.addRdBtn);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 105);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select an operation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.secNumTxtBox);
            this.groupBox2.Controls.Add(this.firstNumtxtBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 120);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Please enter a number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "first number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "second number";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 443);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ansTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.GoBtn);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox firstNumtxtBox;
        private System.Windows.Forms.TextBox secNumTxtBox;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.RadioButton addRdBtn;
        private System.Windows.Forms.RadioButton subtRdBtn;
        private System.Windows.Forms.RadioButton divRdBtn;
        private System.Windows.Forms.RadioButton multRdBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ansTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}

