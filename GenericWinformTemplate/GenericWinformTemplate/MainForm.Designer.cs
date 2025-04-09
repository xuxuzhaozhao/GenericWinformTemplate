namespace GenericWinformTemplate
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msMainform = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            msMainform.SuspendLayout();
            SuspendLayout();
            // 
            // msMainform
            // 
            msMainform.ImageScalingSize = new Size(20, 20);
            msMainform.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            msMainform.Location = new Point(0, 0);
            msMainform.Name = "msMainform";
            msMainform.Size = new Size(800, 28);
            msMainform.TabIndex = 0;
            msMainform.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountSettingsToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(83, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new Size(224, 26);
            accountSettingsToolStripMenuItem.Text = "AccountSettings";
            accountSettingsToolStripMenuItem.Click += accountSettingsToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(93, 195);
            button1.Name = "button1";
            button1.Size = new Size(612, 124);
            button1.TabIndex = 1;
            button1.Text = "ShowMessage";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(msMainform);
            MainMenuStrip = msMainform;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            msMainform.ResumeLayout(false);
            msMainform.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMainform;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem accountSettingsToolStripMenuItem;
        private Button button1;
    }
}
