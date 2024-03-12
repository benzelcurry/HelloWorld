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

        private void lbMovies_DoubleClick(object sender, EventArgs e)
        {
            Movie selected = (Movie)lbMovies.SelectedItem;

            MessageBox.Show(
                $"{selected.Title}{Environment.NewLine}{selected.ReleaseDate}" +
                $"{Environment.NewLine}{Environment.NewLine}{selected.Plot}"
            );
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            NewMovie newMovie = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            newMovie.ShowDialog();
        }
    }
}
