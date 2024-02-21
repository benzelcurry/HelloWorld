using HelloWorld.Business;

namespace HelloWorld.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showDetails(object sender, EventArgs e)
        {
            UserInformation userInformation = new();
            userInformation.StartPosition = FormStartPosition.CenterParent;
            userInformation.ShowDialog();
        }
    }
}
