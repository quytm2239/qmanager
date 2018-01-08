namespace QManager.GUI
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.leftMenu = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.buttonCloseLeftMenu = new System.Windows.Forms.Button();
            this.leftMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenu
            // 
            this.leftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.leftMenu.Controls.Add(this.buttonCloseLeftMenu);
            resources.ApplyResources(this.leftMenu, "leftMenu");
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMenu_Paint);
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            // 
            // buttonCloseLeftMenu
            // 
            resources.ApplyResources(this.buttonCloseLeftMenu, "buttonCloseLeftMenu");
            this.buttonCloseLeftMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCloseLeftMenu.Name = "buttonCloseLeftMenu";
            this.buttonCloseLeftMenu.UseVisualStyleBackColor = true;
            this.buttonCloseLeftMenu.Click += new System.EventHandler(this.buttonCloseLeftMenu_Click);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.leftMenu);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.leftMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonCloseLeftMenu;
    }
}