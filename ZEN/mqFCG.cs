using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    public partial class mqFCG : Form
    {
        public mqFCG(string title, string message, int sizex, int sizey)
        {
            InitializeComponent();

            Theme();

            this.Text = title;
            label1.Text = message;
            this.Width = sizex;
            this.Height = sizey;
        }

        private void Theme()
        {
            if (STMFa.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);

                label1.BackColor = Color.FromArgb(39, 49, 61);
                label1.ForeColor = Color.FromArgb(172, 176, 180);
            }
            else if (STMFa.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(225, 225, 225);

                label1.BackColor = Color.FromArgb(225, 225, 225);
                label1.ForeColor = Color.FromArgb(138, 144, 149);
            }
        }

        private void mqFCG_Load(object sender, EventArgs e)
        {

        }
    }
}
