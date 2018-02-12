using System;
using System.Windows.Forms;

namespace QManager.GUI
{
    public partial class ErrorDialog : Form
    {
        private string Title = "";
        private string Message = "";
        public ErrorDialog()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        public ErrorDialog(string title, string message) : this()
        {
            Title = title;
            Message = message;
        }

        private void ErrorDialog_Load(object sender, EventArgs e)
        {
            Text = Title;
            LabelMessage.Text = Message;
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
    }
}
