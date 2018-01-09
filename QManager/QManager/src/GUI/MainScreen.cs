using System.Windows.Forms;
using System;
using System.Drawing;
namespace QManager.GUI
{
    public partial class MainScreen : Form
    {
        private const int LeftMenuMinWidth = 50;
        private const int LeftMenuMaxWidth = 200;
        private bool IsLeftMenuMaxWidth = true;
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
        }

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
            this.ButtonCloseLeftMenu.Text = this.IsLeftMenuMaxWidth ? ">>" : "<<";
            this.PictureBoxAvatar.Visible = this.IsLeftMenuMaxWidth ? false : true;
            this.IsLeftMenuMaxWidth = !this.IsLeftMenuMaxWidth;
            this.LeftPanel.Size = newSize;
        }

        private void PictureBoxAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
