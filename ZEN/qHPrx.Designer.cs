namespace ZEN
{
    partial class qHPrx
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
            this.title = new System.Windows.Forms.Timer(this.components);
            this.Loadx = new Guna.UI2.WinForms.Guna2Button();
            this.Toggle = new Guna.UI2.WinForms.Guna2CheckBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Enabled = true;
            this.title.Interval = 1000;
            this.title.Tick += new System.EventHandler(this.title_Tick);
            // 
            // Loadx
            // 
            this.Loadx.Animated = true;
            this.Loadx.AnimatedGIF = true;
            this.Loadx.BorderRadius = 3;
            this.Loadx.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loadx.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loadx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loadx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loadx.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Loadx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Loadx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Loadx.Location = new System.Drawing.Point(456, 316);
            this.Loadx.Name = "Loadx";
            this.Loadx.Size = new System.Drawing.Size(112, 29);
            this.Loadx.TabIndex = 11;
            this.Loadx.Text = "LOAD CHEAT";
            // 
            // Toggle
            // 
            this.Toggle.AutoSize = true;
            this.Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Toggle.CheckedState.BorderRadius = 1;
            this.Toggle.CheckedState.BorderThickness = 1;
            this.Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Toggle.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Toggle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Toggle.Location = new System.Drawing.Point(12, 12);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(99, 19);
            this.Toggle.TabIndex = 2;
            this.Toggle.Text = "DARK THEME";
            this.Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(176)))), ((int)(((byte)(180)))));
            this.Toggle.UncheckedState.BorderRadius = 1;
            this.Toggle.UncheckedState.BorderThickness = 1;
            this.Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.Toggle.CheckedChanged += new System.EventHandler(this.Toggle_CheckedChanged);
            // 
            // qHPrx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(49)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.Loadx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "qHPrx";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.qHPrx_FormClosing);
            this.Load += new System.EventHandler(this.qHPrx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer title;
        private Guna.UI2.WinForms.Guna2Button Loadx;
        private Guna.UI2.WinForms.Guna2CheckBox Toggle;
    }
}