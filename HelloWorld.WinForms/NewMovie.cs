using HelloWorld.Business;
using HelloWorld.Business.Models;

namespace HelloWorld.WinForms
{
    public partial class NewMovie : Form
    {
        public Movie Current { get; set; }

        public NewMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovieService movieService = new();

            Movie movie = new()
            {
                Plot = txtPlot.Text,
                ReleaseDate = dtpReleaseDate.Value,
                Seen = chkSeen.Checked,
                Title = txtTitle.Text,
            };

            if (Current == null)
                movieService.Create(movie);
            else
            {
                movie.Id = Current.Id;
                movieService.Update(Current);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void NewMovie_Load(object sender, EventArgs e)
        {
            if (Current != null)
            {
                txtPlot.Text = Current.Plot;
                txtTitle.Text = Current.Title;
                chkSeen.Checked = Current.Seen;
                dtpReleaseDate.Value = Current.ReleaseDate;

                button1.Text = "Update";
            }
            else
            {
                button1.Text = "Create";
            }
        }
    }
}
