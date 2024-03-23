using HelloWorld.Business;
using HelloWorld.Business.Models;
using System.Text.Json;

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

        private void button3_Click(object sender, EventArgs e)
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

            NewMovie newMovie = new();
            newMovie.Current = selected;
            newMovie.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = newMovie.ShowDialog();

            if(result == DialogResult.OK)
                LoadMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMovie newMovie = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            DialogResult result = newMovie.ShowDialog();

            if (result == DialogResult.OK)
                LoadMovies();
        }

        private void LoadMovies()
        {
            List<Movie> movies = new();

            using (HttpClient client = new())
            {
                HttpResponseMessage response = client.GetAsync("https://localhost:7086/api/movies").Result;

                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result;
                    movies = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Movie>>(content);
                }
                else
                    Console.WriteLine("Error while getting the information from the API.");
            }
        }

        private void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMovies.SelectedItems.Count > 0)
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Movie selected = (Movie)lbMovies.SelectedItem;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete the movie {selected.Title}?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                movieService.Delete(selected.Id);
                LoadMovies();
            }
        }
    }
}