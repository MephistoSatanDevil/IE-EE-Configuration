using EEConfig.Properties;

namespace EEConfig.UI
{
    partial class AboutWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            panelAboutContent = new Panel();
            panelText = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelAboutHeader = new Panel();
            roundPictureBox1 = new EEConfig.UI.Controls.RoundPictureBox();
            label1 = new Label();
            label_Version = new Label();
            panel1.SuspendLayout();
            panelAboutContent.SuspendLayout();
            panelText.SuspendLayout();
            panelAboutHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelAboutContent);
            panel1.Controls.Add(panelAboutHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 256);
            panel1.TabIndex = 0;
            // 
            // panelAboutContent
            // 
            panelAboutContent.Controls.Add(panelText);
            panelAboutContent.Controls.Add(label4);
            panelAboutContent.Dock = DockStyle.Fill;
            panelAboutContent.Location = new Point(0, 89);
            panelAboutContent.Margin = new Padding(2);
            panelAboutContent.Name = "panelAboutContent";
            panelAboutContent.Size = new Size(488, 167);
            panelAboutContent.TabIndex = 4;
            // 
            // panelText
            // 
            panelText.Controls.Add(label2);
            panelText.Controls.Add(label3);
            panelText.Dock = DockStyle.Top;
            panelText.Location = new Point(0, 0);
            panelText.Margin = new Padding(2);
            panelText.Name = "panelText";
            panelText.Size = new Size(488, 113);
            panelText.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(488, 82);
            label2.TabIndex = 0;
            label2.Text = Resources.About_Description;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(0, 72);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(488, 50);
            label3.TabIndex = 1;
            label3.Text = Resources.AboutText_CreatedBy;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(0, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(488, 45);
            label4.TabIndex = 2;
            label4.Text = Resources.AboutText_SpecialThanks;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAboutHeader
            // 
            panelAboutHeader.Controls.Add(roundPictureBox1);
            panelAboutHeader.Controls.Add(label1);
            panelAboutHeader.Dock = DockStyle.Top;
            panelAboutHeader.Location = new Point(0, 0);
            panelAboutHeader.Margin = new Padding(2);
            panelAboutHeader.Name = "panelAboutHeader";
            panelAboutHeader.Size = new Size(488, 89);
            panelAboutHeader.TabIndex = 3;
            // 
            // roundPictureBox1
            // 
            roundPictureBox1.BackColor = Color.White;
            roundPictureBox1.Dock = DockStyle.Left;
            roundPictureBox1.Image = Resources.config_gear;
            roundPictureBox1.Location = new Point(0, 0);
            roundPictureBox1.Margin = new Padding(2);
            roundPictureBox1.Name = "roundPictureBox1";
            roundPictureBox1.Size = new Size(102, 89);
            roundPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            roundPictureBox1.TabIndex = 1;
            roundPictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Cascadia Mono", 11.25F);
            label1.Location = new Point(108, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 89);
            label1.TabIndex = 2;
            label1.Text = Resources.AppTitle;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Version
            // 
            label_Version.Dock = DockStyle.Bottom;
            label_Version.Font = new Font("Calibri", 9.75F);
            label_Version.Location = new Point(10, 251);
            label_Version.Margin = new Padding(2, 0, 2, 0);
            label_Version.Name = "label_Version";
            label_Version.Size = new Size(488, 15);
            label_Version.TabIndex = 3;
            label_Version.Text = "v1.0.0";
            label_Version.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AboutWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 276);
            Controls.Add(label_Version);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "AboutWindow";
            Padding = new Padding(10);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = Resources.MenuItem_About;
            Load += AboutWindow_Load;
            panel1.ResumeLayout(false);
            panelAboutContent.ResumeLayout(false);
            panelText.ResumeLayout(false);
            panelAboutHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)roundPictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Controls.RoundPictureBox roundPictureBox1;
        private Panel panelAboutContent;
        private Label label4;
        private Label label2;
        private Panel panelAboutHeader;
        private Label label1;
        private Panel panelText;
        private Label label_Version;
        private Label label3;
    }
}
