using System;
using System.Windows.Forms;

namespace QManager
{
    public partial class Form1 : Form
    {
        private Form form2 = new Form();
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            form2.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("File is clicked!");
        }

        private void openForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            if (form2.Visible)
            {
                return;
            }
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }
    }
}
