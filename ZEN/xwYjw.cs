using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    public partial class xwYjw : Form
    {
        #region Imports
        [DllImport("user32")]
        public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32")]
        public static extern bool EnableMenuItem(IntPtr hMenu, uint itemId, uint uEnable);
        #endregion

        //  Initializing pBar
        public Guna.UI2.WinForms.Guna2WinProgressIndicator pbar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();

        public xwYjw()
        {
            // Initializing all form components for example lbs ect...
            InitializeComponent();

            this.Text = _0x02.mcyAy.UpperReturn;

            // Disable close button on splash form
            EnableMenuItem(GetSystemMenu(this.Handle, false), 0xF060, 1);

            // Load theme settings
            Theme();
        }

        private void Theme()
        {
            // Settings up background for dark gui look
            if (STMFa.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);
            }
            // Settings up background for light gui look.
            else if (STMFa.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(225, 225, 225);
            }
        }

        private void wait_Tick(object sender, EventArgs e)
        {
            // Stop our timer at the end of our interval pause.
            wait.Stop();

            // Exit once it was stopped.
            this.Close();
        }

        private void xwYjw_Shown(object sender, EventArgs e)
        {
            // Start sleep / wait thread.
            wait.Start();

            // Set the location of our pbar.
            pbar.Location = new Point(45, 33);

            // Set the pbar to run.
            pbar.Start();

            // Setting up theming / colors for the pbar.
            if (STMFa.Theme == "Dark")
            {
                pbar.BackColor = Color.FromArgb(39, 49, 61);
                pbar.ProgressColor = Color.FromArgb(172, 176, 180);
            }
            else if (STMFa.Theme == "Light")
            {
                pbar.BackColor = Color.FromArgb(225, 225, 225);
                pbar.ProgressColor = Color.FromArgb(138, 144, 149);
            }

            // Once complete we will then add our pbar to the form.
            this.Controls.Add(pbar);
        }

        private void xwYjw_Load(object sender, EventArgs e)
        {

        }
    }
}
