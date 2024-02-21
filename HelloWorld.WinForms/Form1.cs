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

            string text = $"Hello {userInformation.Name}, {Environment.NewLine}" +
                $"How nice of you to join us! I will send you some information to {userInformation.Email}.";

            textBox1.Text = text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
