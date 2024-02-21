namespace HelloWorld.WinForms
{
    partial class UserInformation
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
            name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(66, 58);
            name.Name = "name";
            name.Size = new Size(94, 37);
            name.TabIndex = 0;
            name.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 122);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 1;
            label1.Text = "E-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 184);
            label2.Name = "label2";
            label2.Size = new Size(110, 37);
            label2.TabIndex = 2;
            label2.Text = "Gender:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 242);
            label3.Name = "label3";
            label3.Size = new Size(117, 37);
            label3.TabIndex = 3;
            label3.Text = "Country:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 43);
            textBox1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(461, 43);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(219, 242);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(461, 43);
            textBox4.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(219, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(461, 45);
            comboBox1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(319, 344);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(511, 344);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 10;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserInformation
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(name);
            Name = "UserInformation";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}