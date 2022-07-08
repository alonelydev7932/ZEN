using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    public partial class qHPrx : Form
    {
        public qHPrx()
        {
            // Initializing all form components.
            InitializeComponent();

            // Changes title of window before timer kicks in.
            this.Text = _0x02.mcyAy.RandomString(20);

            // Initialize colors
            Theme();
        }

        private void Theme()
        {
            // Setting up dark theme colors.
            if (STMFa.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);

                Loadx.BackColor = Color.FromArgb(39, 49, 61);
                Loadx.FillColor = Color.FromArgb(172, 176, 180);
                Loadx.ForeColor = Color.FromArgb(39, 49, 61);

                Toggle.BackColor = Color.FromArgb(39, 49, 61);
                Toggle.ForeColor = Color.FromArgb(172, 176, 180);
                Toggle.UncheckedState.BorderColor = Color.FromArgb(172, 176, 180);
                Toggle.UncheckedState.FillColor = Color.FromArgb(39, 49, 61);
                Toggle.CheckedState.FillColor = Color.FromArgb(39, 49, 61);
                Toggle.CheckedState.BorderColor = Color.FromArgb(172, 176, 180);
                Toggle.CheckMarkColor = Color.FromArgb(172, 176, 180);
            }
            // Setting up dark light colors.
            else if (STMFa.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(225, 225, 225);

                Loadx.BackColor = Color.FromArgb(225, 225, 225);
                Loadx.FillColor = Color.FromArgb(138, 144, 149);
                Loadx.ForeColor = Color.FromArgb(225, 225, 225);

                Toggle.BackColor = Color.FromArgb(225, 225, 225);
                Toggle.ForeColor = Color.FromArgb(138, 144, 149);
                Toggle.UncheckedState.BorderColor = Color.FromArgb(138, 144, 149);
                Toggle.UncheckedState.FillColor = Color.FromArgb(225, 225, 225);
                Toggle.CheckedState.FillColor = Color.FromArgb(225, 225, 225);
                Toggle.CheckedState.BorderColor = Color.FromArgb(138, 144, 149);
                Toggle.CheckMarkColor = Color.FromArgb(138, 144, 149);
            }
        }

        private void qHPrx_Load(object sender, EventArgs e)
        {
            if (STMFa.Theme == "Dark")
            {
                Toggle.Checked = true;
            }
            else if (STMFa.Theme == "Light")
            {
                Toggle.Checked = false;
            }
        }

        private void qHPrx_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Sets new name of exe file every time application is closed -> But only on the main form (This One!).
            try { File.Move(_0x02.mcyAy.AppName, _0x02.mcyAy.RandomString(5) + ".exe"); } catch { }

            // Force close application
            try { Application.Exit(); } catch { try { Environment.Exit(0); } catch { } }
        }

        private void title_Tick(object sender, EventArgs e)
        {
            // Changes title of window every 1seconds.
            this.Text = _0x02.mcyAy.RandomString(20);
        }

        private void Toggle_CheckedChanged(object sender, EventArgs e)
        {
            if (Toggle.Checked == true)
            {
                STMFa.Theme = "Dark";
                Theme();

                STMFa.Save();
            }
            else
            {
                STMFa.Theme = "Light";
                Theme();

                STMFa.Save();
            }
        }
    }
}
