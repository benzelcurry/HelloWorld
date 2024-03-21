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
            lbMovies=new ListBox();
            button1=new Button();
            btnDelete=new Button();
            button3=new Button();
            SuspendLayout();
            // 
            // lbMovies
            // 
            lbMovies.FormattingEnabled=true;
            lbMovies.ItemHeight=25;
            lbMovies.Location=new Point(12, 12);
            lbMovies.Name="lbMovies";
            lbMovies.Size=new Size(546, 479);
            lbMovies.TabIndex=0;
            lbMovies.SelectedIndexChanged+=lbMovies_SelectedIndexChanged;
            lbMovies.DoubleClick+=lbMovies_DoubleClick;
            // 
            // button1
            // 
            button1.Location=new Point(564, 12);
            button1.Name="button1";
            button1.Size=new Size(112, 34);
            button1.TabIndex=1;
            button1.Text="Create";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled=false;
            btnDelete.Location=new Point(564, 52);
            btnDelete.Name="btnDelete";
            btnDelete.Size=new Size(112, 34);
            btnDelete.TabIndex=2;
            btnDelete.Text="Delete";
            btnDelete.UseVisualStyleBackColor=true;
            btnDelete.Click+=btnDelete_Click;
            // 
            // button3
            // 
            button3.Location=new Point(564, 144);
            button3.Name="button3";
            button3.Size=new Size(112, 34);
            button3.TabIndex=3;
            button3.Text="Exit";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(691, 512);
            Controls.Add(button3);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(lbMovies);
            Name="Form1";
            Text="Movies Library";
            Load+=Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMovies;
        private Button button1;
        private Button btnDelete;
        private Button button3;
    }
}