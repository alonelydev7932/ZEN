using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GBJcc; // Keyauth api

namespace ZEN
{
    public partial class vYFEC : Form
    {
        // Define your apps information below if unsure do as the api info stats and follow the video...
        // WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=RfDTdiBq4_o

        public static Api whLOn = new Api(name: "Zen", ownerid: "5MbLmPH4pX", secret: "46ce1ac7ef18378e9d31e9c221d32390352be0a59b9dd6cc653aa60617b4f2c9", version: "1.0");

        public vYFEC()
        {
            // Adds license for eo browser this component is used to show html particles
            EO.WebBrowser.Runtime.AddLicense("6A+frfD09uihfsay4Q/lW5f69h3youbyzs2xaqW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaaW0s8uud7Pl9Q+frfD09uihfsay6BvlW5f69h3youbyzs2xaqW0s8uud7Oz8hfrqO7CzRrxndz22hnlqJfo8h/kdpm1wNyuaae0ws2frOzm1iPvounpBOzzdpm1wNyucrC9ys2fr9z2BBTup7Smw82faLXABBTmp9j4Bh3kd+T20tbFiajL4fPRoenW2RX4ksbS4hK8drOzBBTmp9j4Bh3kd7Oz/RTinuX39ul14+30EO2s3MLNF+ic3PIEEMidtbXE3rZ1pvD6DuSn6unaD7112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy/We6ff6Gu12mbbB2a9bl7PP5+Cd26QFJO+etKbW+q183/YAGORbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFppbSzy653s+X1D5+t8PT26KF+xrLoEOFbl/r2HfKi5vLOzbFqpbSzy653s+X1D5+t8PT26KF+xrLhD+Vbl/r2HfKi5vLOzbFppbSzy653s+X1");

            // Load all component within form ect...
            InitializeComponent();

            // Erase PE Header
            _0x03.cbEDo.Dump();

            // Converts lower case string to uppsercase
            _0x02.mcyAy.UpperCase(_0x02.mcyAy.RandomString(5));

            // Changes title of window to below info
            this.Text = "ZEN: - SESSION ID: " + _0x02.mcyAy.UpperReturn;

            // Load theme settings
            Theme();
        }

        private void Theme()
        {
            // Sets applications colors for dark style theme
            if (STMFa.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);

                webControl1.BackColor = Color.FromArgb(39, 49, 61);
                webView.Url = "https://alonelydev7932.github.io/particles-dark.github.io/";

                Username.ForeColor = Color.FromArgb(172, 176, 180);
                Username.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Username.FillColor = Color.FromArgb(39, 49, 61);
                Username.BorderColor = Color.FromArgb(172, 176, 180);
                Username.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Username.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                Password.ForeColor = Color.FromArgb(172, 176, 180);
                Password.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Password.FillColor = Color.FromArgb(39, 49, 61);
                Password.BorderColor = Color.FromArgb(172, 176, 180);
                Password.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Password.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                Key.ForeColor = Color.FromArgb(172, 176, 180);
                Key.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Key.FillColor = Color.FromArgb(39, 49, 61);
                Key.BorderColor = Color.FromArgb(172, 176, 180);
                Key.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Key.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                LoginBtn.FillColor = Color.FromArgb(172, 176, 180);
                LoginBtn.ForeColor = Color.FromArgb(39, 49, 61);

                RegisterBtn.FillColor = Color.FromArgb(172, 176, 180);
                RegisterBtn.ForeColor = Color.FromArgb(39, 49, 61);
            }
            // Sets applications colors for light style theme
            else if (STMFa.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(225, 225, 225);

                webControl1.BackColor = Color.FromArgb(225, 225, 225);
                webView.Url = "https://alonelydev7932.github.io/particles-light.github.io/";

                Username.ForeColor = Color.FromArgb(138, 144, 149);
                Username.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Username.FillColor = Color.FromArgb(225, 225, 225);
                Username.BorderColor = Color.FromArgb(138, 144, 149);
                Username.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Username.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                Password.ForeColor = Color.FromArgb(138, 144, 149);
                Password.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Password.FillColor = Color.FromArgb(225, 225, 225);
                Password.BorderColor = Color.FromArgb(138, 144, 149);
                Password.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Password.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                Key.ForeColor = Color.FromArgb(138, 144, 149);
                Key.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Key.FillColor = Color.FromArgb(225, 225, 225);
                Key.BorderColor = Color.FromArgb(138, 144, 149);
                Key.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Key.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                LoginBtn.FillColor = Color.FromArgb(138, 144, 149);
                LoginBtn.ForeColor = Color.FromArgb(225, 225, 225);

                RegisterBtn.FillColor = Color.FromArgb(138, 144, 149);
                RegisterBtn.ForeColor = Color.FromArgb(225, 225, 225);
            }
        }

        private void CloseBrowser()
        {
            // Shut down web control on exit.

            webView.Dispose();
            webControl1.Dispose();

            webView.Close(true);
            webView.Engine.Stop(true);
            webView.Destroy();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Focus webcontrol rather than other controls such as textbox ect...
            this.ActiveControl = webControl1;

            // Initialize Keyauth on load as usual...
            whLOn.init();

            // Splash screen while controls load to prevent lag some users pcs may not be the best eo browser can sometimes load with a heafty delay.
            xwYjw xw = new xwYjw();
            xw.ShowDialog();

            // Here during the invalid response we will check version information before continuing... 
            if (!whLOn.response.success)
            {
                //Check app version above with our panel version if error found we update

                if (whLOn.app_data.version != whLOn.version)
                {
                    whLOn.CheckUpdate(); // Auto update application.
                }
                else
                {
                    // If the version matchs and an error is still found then will display invalid msg and exit.

                    mqFCG msg = new mqFCG("ERROR", whLOn.response.message, 235, 75);
                    msg.Show();
                    Environment.Exit(0);
                }
            }

            // Load username and password for config builder
            Username.Text = STMFa.Username;
            Password.Text = STMFa.Password;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Perform login function within keyauth api.
            whLOn.login(Username.Text, Password.Text);

            // Check to see if the reponse after attempting to login is not invalid.
            if (whLOn.response.success)
            {
                // If reponse is successfull we then can contiune, then we will display our main gui.
                qHPrx uI = new qHPrx();
                uI.Show();

                // Once main gui is shown hide this one
                this.Hide();

                // Update username and password if login was a go
                STMFa.Username = Username.Text;
                STMFa.Password = Password.Text;

                // After we set our new creds above we can then save them to our config file.
                STMFa.Save();

                // Shut down eo to prevent cpu / ram usage.
                CloseBrowser();
            }
            else
            {
                // Display error message, well that's if an error is found after logging in...
                mqFCG msg = new mqFCG("LOGIN ERROR", whLOn.response.message.ToUpper(), 235, 75);
                msg.ShowDialog();
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            // Perform register function within keyauth api.
            whLOn.register(Username.Text, Password.Text, Key.Text);

            // Check to see if the reponse after attempting to register is not invalid.
            if (whLOn.response.success)
            {
                // Show response message if login successfull -> Note you may remove this if you like its not needed
                mqFCG msg = new mqFCG("REGISTER SUCCESSFULL", whLOn.response.message.ToUpper(), 245, 75);
                msg.ShowDialog();

                // After response message above show main form where your tool / cheat is
                qHPrx uI = new qHPrx();
                uI.Show();

                // Once main gui is shown hide this one
                this.Hide();

                // Update username and password if register was a go
                STMFa.Username = Username.Text;
                STMFa.Password = Password.Text;

                // After we set our new creds above we can then save them to our config file.
                STMFa.Save();

                // Shut down eo to prevent cpu / ram usage.
                CloseBrowser();
            }
            else
            {
                // Display error message, well that's if an error is found after logging in...
                mqFCG msg = new mqFCG("REGISTER ERROR", whLOn.response.message.ToUpper(), 250, 75);
                msg.ShowDialog();
            }
        }

        private void kill_Tick(object sender, EventArgs e)
        {
            // Anti debug thread you can create a thread but I cba so change this if you want to...
            _0x03.QCzDw.ScanAndKill();
        }
    }
}
