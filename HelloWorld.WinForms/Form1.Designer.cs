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
            SuspendLayout();
            // 
            // enterDetails
            // 
            enterDetails.Location = new Point(452, 496);
            enterDetails.Name = "enterDetails";
            enterDetails.Size = new Size(241, 52);
            enterDetails.TabIndex = 0;
            enterDetails.Text = "Enter Details";
            enterDetails.UseVisualStyleBackColor = true;
            enterDetails.Click += showDetails;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 705);
            Controls.Add(enterDetails);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button enterDetails;
    }
}
