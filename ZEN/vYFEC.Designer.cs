namespace ZEN
{
    partial class vYFEC
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
            this.components = new System.ComponentModel.Container();
            this.webControl1 = new EO.WinForm.WebControl();
            this.webView = new EO.WebBrowser.WebView();
            this.RegisterBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Key = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.kill = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Name = "webControl1";
            this.webControl1.Size = new System.Drawing.Size(484, 311);
            this.webControl1.TabIndex = 0;
            this.webControl1.Text = "webControl1";
            this.webControl1.WebView = this.webView;
            // 
            // webView
            // 
            this.webView.AllowDropLoad = false;
            this.webView.InputMsgFilter = null;
            this.webView.ObjectForScripting = null;
            this.webView.Title = null;
            this.webView.UnloadDelay = 1;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Animated = true;
            this.RegisterBtn.AnimatedGIF = true;
            this.RegisterBtn.BorderRadius = 6;
            this.RegisterBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.RegisterBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.RegisterBtn.Location = new System.Drawing.Point(262, 199);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(78, 29);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Animated = true;
            this.LoginBtn.AnimatedGIF = true;
            this.LoginBtn.BorderRadius = 6;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.LoginBtn.Location = new System.Drawing.Point(140, 199);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(78, 29);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Key
            // 
            this.Key.Animated = true;
            this.Key.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Key.BorderRadius = 3;
            this.Key.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Key.DefaultText = "";
            this.Key.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Key.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Key.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Key.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Key.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Key.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Key.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Key.Location = new System.Drawing.Point(140, 159);
            this.Key.Name = "Key";
            this.Key.PasswordChar = '\0';
            this.Key.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Key.PlaceholderText = "Key";
            this.Key.SelectedText = "";
            this.Key.Size = new System.Drawing.Size(200, 29);
            this.Key.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.Animated = true;
            this.Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Password.BorderRadius = 3;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.DefaultText = "";
            this.Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Password.Location = new System.Drawing.Point(140, 119);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Password.PlaceholderText = "Password";
            this.Password.SelectedText = "";
            this.Password.Size = new System.Drawing.Size(200, 29);
            this.Password.TabIndex = 8;
            // 
            // Username
            // 
            this.Username.Animated = true;
            this.Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Username.BorderRadius = 3;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.DefaultText = "";
            this.Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Username.Location = new System.Drawing.Point(140, 79);
            this.Username.Name = "Username";
            this.Username.PasswordChar = '\0';
            this.Username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Username.PlaceholderText = "Username";
            this.Username.SelectedText = "";
            this.Username.Size = new System.Drawing.Size(200, 29);
            this.Username.TabIndex = 7;
            // 
            // kill
            // 
            this.kill.Enabled = true;
            this.kill.Interval = 1000;
            this.kill.Tick += new System.EventHandler(this.kill_Tick);
            // 
            // vYFEC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.webControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vYFEC";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private EO.WinForm.WebControl webControl1;
        private Guna.UI2.WinForms.Guna2Button RegisterBtn;
        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private Guna.UI2.WinForms.Guna2TextBox Key;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Guna.UI2.WinForms.Guna2TextBox Username;
        private EO.WebBrowser.WebView webView;
        private System.Windows.Forms.Timer kill;
    }
}

