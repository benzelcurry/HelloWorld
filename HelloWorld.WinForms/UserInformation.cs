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
    }
}
