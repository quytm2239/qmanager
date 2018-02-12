using System;
using System.Windows.Forms;

namespace QManager.BaseClass
{
    public class BaseChildForm : Form
    {
        public BaseChildForm()
        {
            Load += new EventHandler(BaseChildForm_Load);
            TopLevel = false;
            Anchor = AnchorStyles.None;
        }

        private void BaseChildForm_Load(object sender, EventArgs e)
        {

        }
    }
}
