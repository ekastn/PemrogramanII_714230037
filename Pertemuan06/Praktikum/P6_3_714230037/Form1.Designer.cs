namespace P6_3_714230037
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHuruf = new TextBox();
            epWarning = new ErrorProvider(components);
            epWrong = new ErrorProvider(components);
            epCorrect = new ErrorProvider(components);
            txtAngka = new TextBox();
            txtEmail = new TextBox();
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)epWarning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epWrong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)epCorrect).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(45, 47);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Huruf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(45, 137);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(45, 95);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Angka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(45, 182);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 3;
            label4.Text = "*Angka 1 > Angka 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(45, 237);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Angka 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(45, 286);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 5;
            label6.Text = "Angka 2";
            // 
            // txtHuruf
            // 
            txtHuruf.Location = new Point(227, 44);
            txtHuruf.Name = "txtHuruf";
            txtHuruf.Size = new Size(125, 27);
            txtHuruf.TabIndex = 6;
            txtHuruf.Leave += txtHuruf_Leave;
            // 
            // epWarning
            // 
            epWarning.ContainerControl = this;
            epWarning.Icon = (Icon)resources.GetObject("epWarning.Icon");
            // 
            // epWrong
            // 
            epWrong.ContainerControl = this;
            epWrong.Icon = (Icon)resources.GetObject("epWrong.Icon");
            // 
            // epCorrect
            // 
            epCorrect.ContainerControl = this;
            epCorrect.Icon = (Icon)resources.GetObject("epCorrect.Icon");
            // 
            // txtAngka
            // 
            txtAngka.Location = new Point(227, 92);
            txtAngka.Name = "txtAngka";
            txtAngka.Size = new Size(125, 27);
            txtAngka.TabIndex = 7;
            txtAngka.TextChanged += txtAngka_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(227, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(227, 234);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(125, 27);
            txtAngka1.TabIndex = 9;
            txtAngka1.TextChanged += txtAngka1_TextChanged;
            txtAngka1.Leave += txtAngka1_Leave;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(227, 283);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(125, 27);
            txtAngka2.TabIndex = 10;
            txtAngka2.TextChanged += txtAngka2_TextChanged;
            txtAngka2.Leave += txtAngka2_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 354);
            Controls.Add(txtAngka2);
            Controls.Add(txtAngka1);
            Controls.Add(txtEmail);
            Controls.Add(txtAngka);
            Controls.Add(txtHuruf);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)epWarning).EndInit();
            ((System.ComponentModel.ISupportInitialize)epWrong).EndInit();
            ((System.ComponentModel.ISupportInitialize)epCorrect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHuruf;
        private ErrorProvider epWarning;
        private ErrorProvider epWrong;
        private ErrorProvider epCorrect;
        private TextBox txtEmail;
        private TextBox txtAngka;
        private TextBox txtAngka2;
        private TextBox txtAngka1;
    }
}
