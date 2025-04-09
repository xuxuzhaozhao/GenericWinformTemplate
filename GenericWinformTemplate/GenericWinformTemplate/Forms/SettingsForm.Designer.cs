namespace GenericWinformTemplate.Forms
{
    partial class SettingsForm
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
            panel1 = new Panel();
            btnSave = new Button();
            label1 = new Label();
            txtName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 166);
            panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(487, 189);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 40);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(94, 16);
            txtName.Name = "txtName";
            txtName.Size = new Size(459, 27);
            txtName.TabIndex = 1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 241);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SettingsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private TextBox txtName;
        private Label label1;
    }
}