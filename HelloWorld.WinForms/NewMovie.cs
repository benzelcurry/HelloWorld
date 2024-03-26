using System.Text;

namespace HelloWorld.WinForms
{
    public partial class NewMovie : Form
    {
        public Movie Current { get; set; }

        public NewMovie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = new()
            {
                Id = Current == null ? 0 : Current.Id,
                Plot = txtPlot.Text,
                ReleaseDate = dtpReleaseDate.Value,
                Seen = chkSeen.Checked,
                Title = txtTitle.Text,
            };

            string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(movie);
            StringContent content = new(jsonData, Encoding.UTF8, "application/json");
            string apiUrl = "https://localhost:7133/api/movies";

            using (HttpClient client = new())
            {
                HttpResponseMessage? response;

                if (Current == null)
                    response = client.PostAsync(apiUrl, content).Result;
                else
                    response = client.PutAsync(apiUrl, content).Result;

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Something went wrong while saving the movie");
                    DialogResult = DialogResult.Cancel;
                }
                else
                    DialogResult = DialogResult.OK;
            }

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
                button1.Text = "Create";
        }
    }
}
