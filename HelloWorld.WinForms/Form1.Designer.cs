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
            lbMovies = new ListBox();
            createButton = new Button();
            deleteButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // lbMovies
            // 
            lbMovies.FormattingEnabled = true;
            lbMovies.ItemHeight = 37;
            lbMovies.Location = new Point(33, 34);
            lbMovies.Name = "lbMovies";
            lbMovies.Size = new Size(816, 633);
            lbMovies.TabIndex = 0;
            lbMovies.DoubleClick += lbMovies_DoubleClick;
            // 
            // createButton
            // 
            createButton.Location = new Point(908, 34);
            createButton.Name = "createButton";
            createButton.Size = new Size(200, 56);
            createButton.TabIndex = 1;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(908, 111);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(200, 52);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(908, 282);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 52);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 705);
            Controls.Add(exitButton);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(lbMovies);
            Name = "Form1";
            Text = "Movies Library";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMovies;
        private Button createButton;
        private Button deleteButton;
        private Button exitButton;
    }
}
