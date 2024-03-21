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
            button1=new Button();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            txtTitle=new TextBox();
            txtPlot=new TextBox();
            dtpReleaseDate=new DateTimePicker();
            chkSeen=new CheckBox();
            button2=new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location=new Point(553, 378);
            button1.Name="button1";
            button1.Size=new Size(112, 34);
            button1.TabIndex=0;
            button1.Text="Create";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(30, 26);
            label1.Name="label1";
            label1.Size=new Size(48, 25);
            label1.TabIndex=1;
            label1.Text="Title:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(30, 234);
            label2.Name="label2";
            label2.Size=new Size(114, 25);
            label2.TabIndex=2;
            label2.Text="Release date:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(30, 77);
            label3.Name="label3";
            label3.Size=new Size(47, 25);
            label3.TabIndex=3;
            label3.Text="Plot:";
            // 
            // txtTitle
            // 
            txtTitle.Location=new Point(151, 23);
            txtTitle.Name="txtTitle";
            txtTitle.Size=new Size(514, 31);
            txtTitle.TabIndex=4;
            // 
            // txtPlot
            // 
            txtPlot.Location=new Point(151, 74);
            txtPlot.Multiline=true;
            txtPlot.Name="txtPlot";
            txtPlot.Size=new Size(514, 140);
            txtPlot.TabIndex=5;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location=new Point(151, 234);
            dtpReleaseDate.Name="dtpReleaseDate";
            dtpReleaseDate.Size=new Size(300, 31);
            dtpReleaseDate.TabIndex=6;
            // 
            // chkSeen
            // 
            chkSeen.AutoSize=true;
            chkSeen.Location=new Point(30, 295);
            chkSeen.Name="chkSeen";
            chkSeen.Size=new Size(213, 29);
            chkSeen.TabIndex=7;
            chkSeen.Text="I have seen this movie";
            chkSeen.UseVisualStyleBackColor=true;
            // 
            // button2
            // 
            button2.Location=new Point(435, 378);
            button2.Name="button2";
            button2.Size=new Size(112, 34);
            button2.TabIndex=8;
            button2.Text="Cancel";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // NewMovie
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(681, 423);
            Controls.Add(button2);
            Controls.Add(chkSeen);
            Controls.Add(dtpReleaseDate);
            Controls.Add(txtPlot);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name="NewMovie";
            Text="Create New Movie";
            Load+=NewMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtPlot;
        private DateTimePicker dtpReleaseDate;
        private CheckBox chkSeen;
        private Button button2;
    }
}