using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nixdatempv3
{
    public partial class Login : Form
    {

        public static api KeyAuthApp = new api(
             name: "TestApp", 
             ownerid: "zFxb0tlNzz",
             version: "1.0" 
                          
         );

        public Login()
        {
            InitializeComponent();
        }

      

        private async void Login_Load(object sender, EventArgs e)
        {
            await KeyAuthApp.init();
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            LoginBTN.Enabled = false;
            await KeyAuthApp.license(LicenseBox.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                LoginBTN.Enabled = true;
                MessageBox.Show("Status: " + KeyAuthApp.response.message);
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
