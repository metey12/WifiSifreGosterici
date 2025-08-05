namespace WinFormsApp1
{
    partial class Form1
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
            lstNetworks = new CuoreUI.Controls.cuiListbox();
            btnLoadProfiles = new CuoreUI.Controls.cuiButton();
            btnShowPassword = new CuoreUI.Controls.cuiButton();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lstNetworks
            // 
            lstNetworks.BackgroundColor = Color.White;
            lstNetworks.BorderStyle = BorderStyle.None;
            lstNetworks.DrawMode = DrawMode.OwnerDrawFixed;
            lstNetworks.Font = new Font("Microsoft YaHei UI", 9F);
            lstNetworks.ForeColor = Color.FromArgb(84, 84, 84);
            lstNetworks.ForegroundColor = Color.DimGray;
            lstNetworks.FormattingEnabled = true;
            lstNetworks.ItemBackgroundColor = Color.Empty;
            lstNetworks.ItemHeight = 34;
            lstNetworks.ItemHoverBackgroundColor = Color.FromArgb(32, 128, 128, 128);
            lstNetworks.ItemHoverForegroundColor = Color.DimGray;
            lstNetworks.ItemRounding = 8;
            lstNetworks.ItemSelectedBackgroundColor = Color.FromArgb(255, 106, 0);
            lstNetworks.Location = new Point(12, 12);
            lstNetworks.Name = "lstNetworks";
            lstNetworks.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            lstNetworks.Rounding = new Padding(8);
            lstNetworks.SelectedForegroundColor = Color.White;
            lstNetworks.Size = new Size(241, 136);
            lstNetworks.TabIndex = 0;
            // 
            // btnLoadProfiles
            // 
            btnLoadProfiles.CheckButton = false;
            btnLoadProfiles.Checked = false;
            btnLoadProfiles.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLoadProfiles.CheckedForeColor = Color.White;
            btnLoadProfiles.CheckedImageTint = Color.White;
            btnLoadProfiles.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLoadProfiles.Content = "WiFi Ağlarını Yükle";
            btnLoadProfiles.DialogResult = DialogResult.None;
            btnLoadProfiles.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnLoadProfiles.ForeColor = Color.Black;
            btnLoadProfiles.HoverBackground = Color.White;
            btnLoadProfiles.HoverForeColor = Color.Black;
            btnLoadProfiles.HoverImageTint = Color.White;
            btnLoadProfiles.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLoadProfiles.Image = null;
            btnLoadProfiles.ImageAutoCenter = true;
            btnLoadProfiles.ImageExpand = new Point(0, 0);
            btnLoadProfiles.ImageOffset = new Point(0, 0);
            btnLoadProfiles.Location = new Point(12, 193);
            btnLoadProfiles.Name = "btnLoadProfiles";
            btnLoadProfiles.NormalBackground = Color.White;
            btnLoadProfiles.NormalForeColor = Color.Black;
            btnLoadProfiles.NormalImageTint = Color.White;
            btnLoadProfiles.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLoadProfiles.OutlineThickness = 1F;
            btnLoadProfiles.PressedBackground = Color.WhiteSmoke;
            btnLoadProfiles.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLoadProfiles.PressedImageTint = Color.White;
            btnLoadProfiles.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLoadProfiles.Rounding = new Padding(8);
            btnLoadProfiles.Size = new Size(122, 45);
            btnLoadProfiles.TabIndex = 1;
            btnLoadProfiles.TextAlignment = StringAlignment.Center;
            btnLoadProfiles.TextOffset = new Point(0, 0);
            btnLoadProfiles.Click += btnLoadProfiles_Click;
            // 
            // btnShowPassword
            // 
            btnShowPassword.CheckButton = false;
            btnShowPassword.Checked = false;
            btnShowPassword.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnShowPassword.CheckedForeColor = Color.White;
            btnShowPassword.CheckedImageTint = Color.White;
            btnShowPassword.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnShowPassword.Content = "Şifreyi Göster";
            btnShowPassword.DialogResult = DialogResult.None;
            btnShowPassword.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnShowPassword.ForeColor = Color.Black;
            btnShowPassword.HoverBackground = Color.White;
            btnShowPassword.HoverForeColor = Color.Black;
            btnShowPassword.HoverImageTint = Color.White;
            btnShowPassword.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnShowPassword.Image = null;
            btnShowPassword.ImageAutoCenter = true;
            btnShowPassword.ImageExpand = new Point(0, 0);
            btnShowPassword.ImageOffset = new Point(0, 0);
            btnShowPassword.Location = new Point(140, 193);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NormalBackground = Color.White;
            btnShowPassword.NormalForeColor = Color.Black;
            btnShowPassword.NormalImageTint = Color.White;
            btnShowPassword.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.OutlineThickness = 1F;
            btnShowPassword.PressedBackground = Color.WhiteSmoke;
            btnShowPassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowPassword.PressedImageTint = Color.White;
            btnShowPassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.Rounding = new Padding(8);
            btnShowPassword.Size = new Size(113, 45);
            btnShowPassword.TabIndex = 2;
            btnShowPassword.TextAlignment = StringAlignment.Center;
            btnShowPassword.TextOffset = new Point(0, 0);
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 23);
            txtPassword.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 250);
            Controls.Add(txtPassword);
            Controls.Add(btnShowPassword);
            Controls.Add(btnLoadProfiles);
            Controls.Add(lstNetworks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiListbox lstNetworks;
        private CuoreUI.Controls.cuiButton btnLoadProfiles;
        private CuoreUI.Controls.cuiButton btnShowPassword;
        private TextBox txtPassword;
    }
}
