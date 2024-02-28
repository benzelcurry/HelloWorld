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
            DialogResult result = userInformation.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBox1.Text = $"Hello {userInformation.Name}, {Environment.NewLine}" +
                    $"How nice of you to join us! I will send you some information to {userInformation.Email}.";
            }
            else if (result == DialogResult.Cancel)
            {
                textBox1.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enterDetails.Click += showMoreInfo;
            enterDetails.Click += showDetails;
        }

        private void showMoreInfo(object? sender, EventArgs e)
        {
            MessageBox.Show("Please enter some more information");
        }
    }
}
