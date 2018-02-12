using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QManager.BaseClass;
using QManager.Services.HTTP_API;
using QManager.Model;

namespace QManager.GUI.Login
{
    public partial class FLogin : BaseChildForm
    {
        public FLogin() : base()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxUsername.Text == null || TextBoxUsername.Text.Length == 0
                || TextBoxPassword.Text == null || TextBoxPassword.Text.Length == 0) {
                ErrorDialog errorDialog = new ErrorDialog("Lỗi đăng nhập", "Vui lòng nhập tài khoản và mật khẩu!");
                errorDialog.ShowDialog();
                return;
            }
            var response = await HTTPClientManager.Shared().Login(TextBoxUsername.Text, TextBoxPassword.Text);
            if (response.success) {
                // process to profile screen
            } else {
                // show error dialog
                ErrorDialog errorDialog = new ErrorDialog("Lỗi đăng nhập", response.message);
                errorDialog.ShowDialog();
            }
        }
    }
}
