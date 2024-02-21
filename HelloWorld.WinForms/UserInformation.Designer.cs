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
            nameLabel = new Label();
            emailLabel = new Label();
            genderLabel = new Label();
            countryLabel = new Label();
            name = new TextBox();
            email = new TextBox();
            country = new TextBox();
            gender = new ComboBox();
            submit = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(66, 58);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(94, 37);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(66, 122);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(99, 37);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "E-mail:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(66, 184);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(110, 37);
            genderLabel.TabIndex = 2;
            genderLabel.Text = "Gender:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(66, 242);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(117, 37);
            countryLabel.TabIndex = 3;
            countryLabel.Text = "Country:";
            // 
            // name
            // 
            name.Location = new Point(219, 55);
            name.Name = "name";
            name.Size = new Size(461, 43);
            name.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(219, 119);
            email.Name = "email";
            email.Size = new Size(461, 43);
            email.TabIndex = 6;
            // 
            // country
            // 
            country.Location = new Point(219, 242);
            country.Name = "country";
            country.Size = new Size(461, 43);
            country.TabIndex = 7;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female", "Nonbinary", "Other" });
            gender.Location = new Point(219, 181);
            gender.Name = "gender";
            gender.Size = new Size(461, 45);
            gender.TabIndex = 8;
            // 
            // submit
            // 
            submit.Location = new Point(319, 344);
            submit.Name = "submit";
            submit.Size = new Size(169, 52);
            submit.TabIndex = 9;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
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
            Controls.Add(submit);
            Controls.Add(gender);
            Controls.Add(country);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(countryLabel);
            Controls.Add(genderLabel);
            Controls.Add(emailLabel);
            Controls.Add(nameLabel);
            Name = "UserInformation";
            Text = "Form2";
            Load += UserInformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label emailLabel;
        private Label genderLabel;
        private Label countryLabel;
        private TextBox name;
        private TextBox email;
        private TextBox country;
        private ComboBox gender;
        private Button submit;
        private Button button2;
    }
}