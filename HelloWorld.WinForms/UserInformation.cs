using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld.WinForms
{
    public partial class UserInformation : Form
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

        public UserInformation()
        {
            InitializeComponent();
        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            gender.Items.Clear();
            gender.Items.Add("Male");
            gender.Items.Add("Female");
            gender.Items.Add("Nonbinary");
            gender.Items.Add("Other");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            Name = name.Text;
            Gender = gender.Text;
            Country = country.Text;
            Email = email.Text;

            this.Close();
        }
    }
}
