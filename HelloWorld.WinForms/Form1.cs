using HelloWorld.Business;
using HelloWorld.Business.Models;

namespace HelloWorld.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MovieService movieService = new();

            lbMovies.DataSource = movieService.Get();
            lbMovies.DisplayMember = "Title";
        }
    }
}
