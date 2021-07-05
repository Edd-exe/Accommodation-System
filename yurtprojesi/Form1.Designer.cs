namespace yurtprojesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcbExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuImageButton();
            this.ddList = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.tbEmail = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bunifuGradientPanel1.Controls.Add(this.panel2);
            bunifuGradientPanel1.Controls.Add(this.panel1);
            bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Navy;
            bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SeaGreen;
            bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            bunifuGradientPanel1.Quality = 10;
            bunifuGradientPanel1.Size = new System.Drawing.Size(788, 447);
            bunifuGradientPanel1.TabIndex = 0;
            bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pcbExit);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 447);
            this.panel2.TabIndex = 9;
            // 
            // pcbExit
            // 
            this.pcbExit.BackColor = System.Drawing.Color.Transparent;
            this.pcbExit.Image = ((System.Drawing.Image)(resources.GetObject("pcbExit.Image")));
            this.pcbExit.ImageActive = null;
            this.pcbExit.Location = new System.Drawing.Point(460, 11);
            this.pcbExit.Margin = new System.Windows.Forms.Padding(2);
            this.pcbExit.Name = "pcbExit";
            this.pcbExit.Size = new System.Drawing.Size(19, 20);
            this.pcbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbExit.TabIndex = 2;
            this.pcbExit.TabStop = false;
            this.pcbExit.Zoom = 10;
            this.pcbExit.Click += new System.EventHandler(this.pcbExit_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(488, 447);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.ddList);
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 447);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageActive = null;
            this.btnLogin.Location = new System.Drawing.Point(122, 349);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(57, 58);
            this.btnLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogin.TabIndex = 15;
            this.btnLogin.TabStop = false;
            this.btnLogin.Zoom = 10;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_2);
            // 
            // ddList
            // 
            this.ddList.BackColor = System.Drawing.Color.Transparent;
            this.ddList.BorderRadius = 3;
            this.ddList.DisabledColor = System.Drawing.Color.Gray;
            this.ddList.ForeColor = System.Drawing.Color.White;
            this.ddList.items = new string[] {
        "Manager",
        "Security"};
            this.ddList.Location = new System.Drawing.Point(46, 276);
            this.ddList.Margin = new System.Windows.Forms.Padding(4);
            this.ddList.Name = "ddList";
            this.ddList.NomalColor = System.Drawing.Color.DarkRed;
            this.ddList.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddList.selectedIndex = -1;
            this.ddList.Size = new System.Drawing.Size(210, 35);
            this.ddList.TabIndex = 14;
            this.ddList.onItemSelected += new System.EventHandler(this.ddList_onItemSelected);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(43, 138);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(36, 17);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "       ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(40)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(63, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Accommodation System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbPassword
            // 
            this.tbPassword.AcceptsReturn = false;
            this.tbPassword.AcceptsTab = false;
            this.tbPassword.AnimationSpeed = 200;
            this.tbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbPassword.BackColor = System.Drawing.Color.Transparent;
            this.tbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPassword.BackgroundImage")));
            this.tbPassword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbPassword.BorderRadius = 20;
            this.tbPassword.BorderThickness = 1;
            this.tbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tbPassword.DefaultText = "";
            this.tbPassword.FillColor = System.Drawing.SystemColors.Control;
            this.tbPassword.HideSelection = true;
            this.tbPassword.IconLeft = null;
            this.tbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.IconPadding = 10;
            this.tbPassword.IconRight = ((System.Drawing.Image)(resources.GetObject("tbPassword.IconRight")));
            this.tbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(46, 214);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbPassword.Modified = false;
            this.tbPassword.Multiline = false;
            this.tbPassword.Name = "tbPassword";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbPassword.OnIdleState = stateProperties4;
            this.tbPassword.PasswordChar = '●';
            this.tbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbPassword.PlaceholderText = "....";
            this.tbPassword.ReadOnly = false;
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(210, 38);
            this.tbPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbPassword.TabIndex = 10;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMarginBottom = 0;
            this.tbPassword.TextMarginLeft = 5;
            this.tbPassword.TextMarginTop = 0;
            this.tbPassword.TextPlaceholder = "....";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.WordWrap = true;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbEmail
            // 
            this.tbEmail.AcceptsReturn = false;
            this.tbEmail.AcceptsTab = false;
            this.tbEmail.AnimationSpeed = 200;
            this.tbEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbEmail.BackColor = System.Drawing.Color.Transparent;
            this.tbEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEmail.BackgroundImage")));
            this.tbEmail.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.tbEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbEmail.BorderRadius = 20;
            this.tbEmail.BorderThickness = 1;
            this.tbEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.tbEmail.DefaultText = "";
            this.tbEmail.FillColor = System.Drawing.SystemColors.Control;
            this.tbEmail.HideSelection = true;
            this.tbEmail.IconLeft = null;
            this.tbEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.IconPadding = 10;
            this.tbEmail.IconRight = ((System.Drawing.Image)(resources.GetObject("tbEmail.IconRight")));
            this.tbEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.Lines = new string[0];
            this.tbEmail.Location = new System.Drawing.Point(46, 158);
            this.tbEmail.MaxLength = 32767;
            this.tbEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbEmail.Modified = false;
            this.tbEmail.Multiline = false;
            this.tbEmail.Name = "tbEmail";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.SystemColors.Control;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbEmail.OnIdleState = stateProperties8;
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbEmail.PlaceholderText = "Email...";
            this.tbEmail.ReadOnly = false;
            this.tbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbEmail.SelectedText = "";
            this.tbEmail.SelectionLength = 0;
            this.tbEmail.SelectionStart = 0;
            this.tbEmail.ShortcutsEnabled = true;
            this.tbEmail.Size = new System.Drawing.Size(210, 38);
            this.tbEmail.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.tbEmail.TabIndex = 9;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbEmail.TextMarginBottom = 0;
            this.tbEmail.TextMarginLeft = 5;
            this.tbEmail.TextMarginTop = 0;
            this.tbEmail.TextPlaceholder = "Email...";
            this.tbEmail.UseSystemPasswordChar = false;
            this.tbEmail.WordWrap = true;
            this.tbEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEmail_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 447);
            this.Controls.Add(bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            bunifuGradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton pcbExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnLogin;
        private Bunifu.Framework.UI.BunifuDropdown ddList;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbPassword;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox tbEmail;
    }
}

