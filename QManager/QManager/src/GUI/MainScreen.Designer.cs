﻿namespace QManager.GUI
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
            this.PanelProfileInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.PanelMenuItems = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonCloseLeftMenu = new System.Windows.Forms.Button();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            this.PanelProfileInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).BeginInit();
            this.PanelMenuItems.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.LeftPanel.Controls.Add(this.PanelProfileInfo);
            this.LeftPanel.Controls.Add(this.PanelMenuItems);
            this.LeftPanel.Controls.Add(this.ButtonCloseLeftMenu);
            resources.ApplyResources(this.LeftPanel, "LeftPanel");
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftMenu_Paint);
            // 
            // PanelProfileInfo
            // 
            this.PanelProfileInfo.BackColor = System.Drawing.SystemColors.Info;
            this.PanelProfileInfo.Controls.Add(this.panel1);
            this.PanelProfileInfo.Controls.Add(this.PictureBoxAvatar);
            resources.ApplyResources(this.PanelProfileInfo, "PanelProfileInfo");
            this.PanelProfileInfo.Name = "PanelProfileInfo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // PictureBoxAvatar
            // 
            this.PictureBoxAvatar.Image = global::QManager.Properties.Resources.friendly_for_facebook;
            resources.ApplyResources(this.PictureBoxAvatar, "PictureBoxAvatar");
            this.PictureBoxAvatar.Name = "PictureBoxAvatar";
            this.PictureBoxAvatar.TabStop = false;
            this.PictureBoxAvatar.Click += new System.EventHandler(this.PictureBoxAvatar_Click);
            // 
            // PanelMenuItems
            // 
            this.PanelMenuItems.BackColor = System.Drawing.SystemColors.Info;
            this.PanelMenuItems.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.PanelMenuItems, "PanelMenuItems");
            this.PanelMenuItems.Name = "PanelMenuItems";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButtonCloseLeftMenu
            // 
            this.ButtonCloseLeftMenu.BackColor = System.Drawing.Color.YellowGreen;
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            this.PanelProfileInfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAvatar)).EndInit();
            this.PanelMenuItems.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.Button ButtonCloseLeftMenu;
        private System.Windows.Forms.PictureBox PictureBoxAvatar;
        private System.Windows.Forms.Panel PanelMenuItems;
        private System.Windows.Forms.Panel PanelProfileInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}