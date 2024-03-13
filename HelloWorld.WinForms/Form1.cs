using HelloWorld.Business;
using HelloWorld.Business.Models;

namespace HelloWorld.WinForms
{
    public partial class Form1 : Form
    {
        private MovieService movieService;

        public Form1()
        {
            movieService = new();

            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbMovies.DisplayMember = "Title";
            LoadMovies();
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

        private void LoadMovies()
        {
            lbMovies.DataSource = movieService.Get();
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMovies.SelectedItems.Count > 0)
                deleteButton.Enabled = true;
            else
                deleteButton.Enabled = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Movie selected = (Movie) lbMovies.SelectedItem;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete the movie {selected.Title}?");

            if (confirm == DialogResult.Yes )
            {
                movieService.Delete(selected.Id);
                LoadMovies();
            }
        }
    }
}
