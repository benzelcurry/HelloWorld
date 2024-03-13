using HelloWorld.Business;
using HelloWorld.Business.Models;

namespace HelloWorld.WinForms
{
    public partial class NewMovie : Form
    {
        public NewMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie movie = new()
            {
                Plot = txtPlot.Text,
                ReleaseDate = dtpReleaseDate.Value,
                Seen = chkSeen.Checked,
                Title = txtTitle.Text,
            };

            MovieService movieService = new();
            movieService.Create(movie);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
