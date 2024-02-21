namespace HelloWorld.WinForms
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
            enterDetails = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // enterDetails
            // 
            enterDetails.Location = new Point(80, 95);
            enterDetails.Name = "enterDetails";
            enterDetails.Size = new Size(241, 52);
            enterDetails.TabIndex = 0;
            enterDetails.Text = "Enter Details";
            enterDetails.UseVisualStyleBackColor = true;
            enterDetails.Click += showDetails;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 216);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1029, 430);
            textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 705);
            Controls.Add(textBox1);
            Controls.Add(enterDetails);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterDetails;
        private TextBox textBox1;
    }
}
