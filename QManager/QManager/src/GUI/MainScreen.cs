using System.Windows.Forms;
using System;
using System.Drawing;
namespace QManager.GUI
{
    public partial class MainScreen : Form
    {
        private const int leftMenuMinWidth = 50;
        private const int leftMenuMaxWidth = 200;
        private bool isLeftMenuMaxWidth = true;
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

        private void buttonCloseLeftMenu_Click(object sender, EventArgs e)
        {
            Size newSize = new Size(isLeftMenuMaxWidth ? leftMenuMinWidth : leftMenuMaxWidth, this.leftMenu.Size.Height);
            this.buttonCloseLeftMenu.Text = isLeftMenuMaxWidth ? ">>" : "<<";
            isLeftMenuMaxWidth = !isLeftMenuMaxWidth;
            this.leftMenu.Size = newSize;
        }
    }
}
