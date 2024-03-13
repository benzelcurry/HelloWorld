namespace HelloWorld.WinForms
{
    partial class NewMovie
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
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtPlot = new TextBox();
            label3 = new Label();
            dtpReleaseDate = new DateTimePicker();
            chkSeen = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 61);
            label1.Name = "label1";
            label1.Size = new Size(74, 37);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 153);
            label2.Name = "label2";
            label2.Size = new Size(70, 37);
            label2.TabIndex = 1;
            label2.Text = "Plot:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(309, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(1035, 43);
            txtTitle.TabIndex = 2;
            // 
            // txtPlot
            // 
            txtPlot.Location = new Point(309, 147);
            txtPlot.Multiline = true;
            txtPlot.Name = "txtPlot";
            txtPlot.Size = new Size(1035, 246);
            txtPlot.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 441);
            label3.Name = "label3";
            label3.Size = new Size(172, 37);
            label3.TabIndex = 4;
            label3.Text = "Release date:";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(309, 435);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(450, 43);
            dtpReleaseDate.TabIndex = 5;
            // 
            // chkSeen
            // 
            chkSeen.AutoSize = true;
            chkSeen.Location = new Point(114, 620);
            chkSeen.Name = "chkSeen";
            chkSeen.Size = new Size(309, 41);
            chkSeen.TabIndex = 6;
            chkSeen.Text = "I have seen this movie";
            chkSeen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(984, 777);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 7;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1175, 777);
            button2.Name = "button2";
            button2.Size = new Size(169, 52);
            button2.TabIndex = 8;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NewMovie
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 887);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(chkSeen);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label3);
            Controls.Add(txtPlot);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewMovie";
            Text = "NewMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtPlot;
        private Label label3;
        private DateTimePicker dtpReleaseDate;
        private CheckBox chkSeen;
        private Button button1;
        private Button button2;
    }
}