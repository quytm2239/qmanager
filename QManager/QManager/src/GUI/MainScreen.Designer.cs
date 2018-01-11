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
            this.ButtonCloseLeftMenu = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.TablePanelContainter = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LeftPanel.SuspendLayout();
            this.TablePanelContainter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LeftPanel.Controls.Add(this.TablePanelContainter);
            resources.ApplyResources(this.LeftPanel, "LeftPanel");
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMenu_Paint);
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
            // PanelContent
            // 
            resources.ApplyResources(this.PanelContent, "PanelContent");
            this.PanelContent.Name = "PanelContent";
            // 
            // TablePanelContainter
            // 
            this.TablePanelContainter.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.TablePanelContainter, "TablePanelContainter");
            this.TablePanelContainter.Controls.Add(this.button3, 0, 4);
            this.TablePanelContainter.Controls.Add(this.button2, 0, 3);
            this.TablePanelContainter.Controls.Add(this.ButtonCloseLeftMenu, 0, 6);
            this.TablePanelContainter.Controls.Add(this.pictureBox1, 0, 0);
            this.TablePanelContainter.Controls.Add(this.label1, 0, 1);
            this.TablePanelContainter.Controls.Add(this.button1, 0, 2);
            this.TablePanelContainter.Name = "TablePanelContainter";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::QManager.Properties.Resources.friendly_for_facebook;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.LeftPanel);
            this.IsMdiContainer = true;
            this.Name = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.LeftPanel.ResumeLayout(false);
            this.TablePanelContainter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button ButtonCloseLeftMenu;
        private System.Windows.Forms.TableLayoutPanel TablePanelContainter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}