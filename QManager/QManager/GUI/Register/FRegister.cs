using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QManager.GUI.Register
{
    public partial class FRegister : Form
    {
        public FRegister()
        {
            InitializeComponent();
        }

        private void Register()
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            string email = TextBoxEmail.Text;
            int role = ComboBoxRole.SelectedIndex;

            string fullname = TextBoxFullName.Text;
            int gender = ComboBoxGender.SelectedIndex;
            string dobDay = TextBoxDoBDay.Text;
            string dobMonth = TextBoxDoBMonth.Text;
            string dobYear = TextBoxDoBYear.Text;
            string address = TextBoxAddress.Text;
            string phone = TextBoxPhoneNo.Text;
            int department_id = ComboBoxDepartment.SelectedIndex;
            string job_title = TextBoxJobTitle.Text;
        }



        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDoBDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDoBMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxDoBYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
