﻿using System;
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
            //var obj = await HTTPClientManager.Shared().Login("admin", "thucgu");
            //Console.WriteLine(obj);
            var obj2 = await HTTPClientManager.Shared().GetAllDepartment();
        }
    }
}
