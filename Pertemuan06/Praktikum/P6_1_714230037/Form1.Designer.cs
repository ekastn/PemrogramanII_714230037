namespace P6_1_714230037
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
            label1 = new Label();
            vbButton = new Button();
            csButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 65);
            label1.Name = "label1";
            label1.Size = new Size(657, 38);
            label1.TabIndex = 0;
            label1.Text = "Which do you think is better, Visual Basic  or C#?";
            // 
            // vbButton
            // 
            vbButton.Location = new Point(235, 165);
            vbButton.Name = "vbButton";
            vbButton.Size = new Size(94, 29);
            vbButton.TabIndex = 1;
            vbButton.Text = "Visual Basic";
            vbButton.UseVisualStyleBackColor = true;
            vbButton.MouseMove += vbButton_MouseMove;
            // 
            // csButton
            // 
            csButton.Location = new Point(472, 165);
            csButton.Name = "csButton";
            csButton.Size = new Size(94, 29);
            csButton.TabIndex = 2;
            csButton.Text = "C#";
            csButton.UseVisualStyleBackColor = true;
            csButton.Click += csButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(68, 360);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(csButton);
            Controls.Add(vbButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button vbButton;
        private Button csButton;
        private Button closeButton;
    }
}
