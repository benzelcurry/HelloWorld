﻿namespace HelloWorld.WinForms
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
            label2 = new Label();
            ageResult = new Label();
            button1 = new Button();
            dateOfBirthPicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 92);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "Year of birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 319);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 1;
            label2.Text = "Result:";
            // 
            // ageResult
            // 
            ageResult.AutoSize = true;
            ageResult.Location = new Point(285, 319);
            ageResult.Name = "ageResult";
            ageResult.Size = new Size(0, 37);
            ageResult.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(285, 211);
            button1.Name = "button1";
            button1.Size = new Size(203, 52);
            button1.TabIndex = 4;
            button1.Text = "Calculate Age";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(285, 86);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(450, 43);
            dateOfBirthPicker.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 705);
            Controls.Add(dateOfBirthPicker);
            Controls.Add(button1);
            Controls.Add(ageResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label ageResult;
        private Button button1;
        private DateTimePicker dateOfBirthPicker;
    }
}