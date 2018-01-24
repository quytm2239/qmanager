using System.Windows.Forms;
using System;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using QManager.Model;

namespace QManager.GUI
{
    public partial class MainScreen : Form
    {
        private const int LeftMenuMinWidth = 80;
        private const int LeftMenuMaxWidth = 180;
        private bool IsLeftMenuMaxWidth = true;
        public static DisconnectedDialog dialog = new DisconnectedDialog();
        public MainScreen()
        {
            InitializeComponent();
            /*panel.Controls.Clear();
            form2 myForm = new form2();
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel.Controls.Add(myForm);
            myForm.Show();
        */
            this.FormClosing += MainScreen_FormClosing;
            DBConnection.GetInstance().NetworkError += NetworkError_Handler;
            //int rowaffect = DAOAccount.AddAccount("quytm2239","123456","quytm2239@gmail.com",0,0);
            List<Account> list = DAOAccount.GetAll();
            Console.WriteLine(list);
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e) => Program.IsAppClosed = true;

        private void MainScreen_Load(object sender, System.EventArgs e)
        {
            Console.WriteLine("MainScreen Loaded!");
        }

        private void LeftMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonCloseLeftMenu_Click(object sender, EventArgs e)
        {
            this.UpdateLeftMenu();
        }

        private void UpdateLeftMenu()
        {
            Size newSize = new Size(this.IsLeftMenuMaxWidth ? LeftMenuMinWidth : LeftMenuMaxWidth, this.LeftPanel.Size.Height);
            this.ButtonCloseLeftMenu.Text = this.IsLeftMenuMaxWidth ? "Mở rộng" : "Thu nhỏ";
            this.PictureBoxAvatar.Visible = this.IsLeftMenuMaxWidth ? false : true;
            this.IsLeftMenuMaxWidth = !this.IsLeftMenuMaxWidth;
            this.LeftPanel.Size = newSize;
        }

        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void NetworkError_Handler(object sender, EventArgs e)
        {
            ConnectionState state = ((MySqlConnection)sender).State;
            if (state == ConnectionState.Closed)
            {
                if (dialog.Visible == false)
                    dialog.ShowDialog();
            } else
            {
                if (dialog.Visible == true)
                {
                    dialog.Invoke((MethodInvoker)delegate
                    {
                        dialog.Close();
                    });
                }
            }
        }
    }
}
