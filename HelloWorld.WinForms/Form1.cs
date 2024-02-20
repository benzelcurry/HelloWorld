using HelloWorld.Business;

namespace HelloWorld.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int year = dateOfBirthPicker.Value.Year;

            AgeService ageService = new();
            int age = ageService.CalculateAge(year);

            ageResult.Text = age.ToString();
        }
    }
}
