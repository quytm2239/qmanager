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
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.TablePanelLeftMenuContainter = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonOther = new System.Windows.Forms.Button();
            this.ButtonHR = new System.Windows.Forms.Button();
            this.ButtonCloseLeftMenu = new System.Windows.Forms.Button();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.LabelProfileInfo = new System.Windows.Forms.Label();
            this.ButtonSale = new System.Windows.Forms.Button();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.TablePanelStatusBar = new System.Windows.Forms.TableLayoutPanel();
            this.TablePanelRight = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPanel.SuspendLayout();
            this.TablePanelLeftMenuContainter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.TablePanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LeftPanel.Controls.Add(this.TablePanelLeftMenuContainter);
            resources.ApplyResources(this.LeftPanel, "LeftPanel");
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMenu_Paint);
            // 
            // TablePanelLeftMenuContainter
            // 
            this.TablePanelLeftMenuContainter.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.TablePanelLeftMenuContainter, "TablePanelLeftMenuContainter");
            this.TablePanelLeftMenuContainter.Controls.Add(this.ButtonOther, 0, 4);
            this.TablePanelLeftMenuContainter.Controls.Add(this.ButtonHR, 0, 3);
            this.TablePanelLeftMenuContainter.Controls.Add(this.ButtonCloseLeftMenu, 0, 6);
            this.TablePanelLeftMenuContainter.Controls.Add(this.PictureBoxAvatar, 0, 0);
            this.TablePanelLeftMenuContainter.Controls.Add(this.LabelProfileInfo, 0, 1);
            this.TablePanelLeftMenuContainter.Controls.Add(this.ButtonSale, 0, 2);
            this.TablePanelLeftMenuContainter.Name = "TablePanelLeftMenuContainter";
            // 
            // ButtonOther
            // 
            this.ButtonOther.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.ButtonOther, "ButtonOther");
            this.ButtonOther.FlatAppearance.BorderSize = 0;
            this.ButtonOther.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonOther.Name = "ButtonOther";
            this.ButtonOther.UseVisualStyleBackColor = false;
            // 
            // ButtonHR
            // 
            this.ButtonHR.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.ButtonHR, "ButtonHR");
            this.ButtonHR.FlatAppearance.BorderSize = 0;
            this.ButtonHR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonHR.Name = "ButtonHR";
            this.ButtonHR.UseVisualStyleBackColor = false;
            // 
            // ButtonCloseLeftMenu
            // 
            this.ButtonCloseLeftMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.ButtonCloseLeftMenu, "ButtonCloseLeftMenu");
            this.ButtonCloseLeftMenu.FlatAppearance.BorderSize = 0;
            this.ButtonCloseLeftMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonCloseLeftMenu.Name = "ButtonCloseLeftMenu";
            this.ButtonCloseLeftMenu.UseVisualStyleBackColor = false;
            this.ButtonCloseLeftMenu.Click += new System.EventHandler(this.ButtonCloseLeftMenu_Click);
            // 
            // PictureBoxAvatar
            // 
            resources.ApplyResources(this.PictureBoxAvatar, "PictureBoxAvatar");
            this.PictureBoxAvatar.BackgroundImage = global::QManager.Properties.Resources.friendly_for_facebook;
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.TabStop = false;
            // 
            // LabelProfileInfo
            // 
            resources.ApplyResources(this.LabelProfileInfo, "LabelProfileInfo");
            this.LabelProfileInfo.Name = "LabelProfileInfo";
            // 
            // ButtonSale
            // 
            this.ButtonSale.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.ButtonSale, "ButtonSale");
            this.ButtonSale.FlatAppearance.BorderSize = 0;
            this.ButtonSale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSale.Name = "ButtonSale";
            this.ButtonSale.UseVisualStyleBackColor = false;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.TablePanelRight);
            resources.ApplyResources(this.RightPanel, "RightPanel");
            this.RightPanel.Name = "RightPanel";
            // 
            // TablePanelStatusBar
            // 
            this.TablePanelStatusBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.TablePanelStatusBar, "TablePanelStatusBar");
            this.TablePanelStatusBar.Name = "TablePanelStatusBar";
            // 
            // TablePanelRight
            // 
            this.TablePanelRight.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.TablePanelRight, "TablePanelRight");
            this.TablePanelRight.Controls.Add(this.TablePanelStatusBar, 0, 1);
            this.TablePanelRight.Name = "TablePanelRight";
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TablePanelLeftMenuContainter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.TablePanelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button ButtonCloseLeftMenu;
        private System.Windows.Forms.TableLayoutPanel TablePanelLeftMenuContainter;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Label LabelProfileInfo;
        private System.Windows.Forms.Button ButtonOther;
        private System.Windows.Forms.Button ButtonHR;
        private System.Windows.Forms.Button ButtonSale;
        private System.Windows.Forms.TableLayoutPanel TablePanelRight;
        private System.Windows.Forms.TableLayoutPanel TablePanelStatusBar;
    }
}