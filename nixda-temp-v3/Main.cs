using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KeyAuth.api;

namespace nixdatempv3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            ExpiryText.Text = ExpiryText.Text = Login.KeyAuthApp.user_data.subscriptions[0].expiration.ToString("dd/MM/yyyy");
        }

        private void SerialsBTN_Click(object sender, EventArgs e)
        {
            Serials serials = new Serials();
            serials.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void cmd(string fileName, string arguments)
        {
            var psi = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                Verb = "runas" 
            };

            using (var process = Process.Start(psi))
            {
                process.WaitForExit();
            }
        }


        private async void SpoofBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SerialsBox.Clear();

                SpoofBTN.Enabled = false;
               
                SerialsBox.AppendText("Starting...");
                

                string fontsPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);
                string sysPath = Path.Combine(fontsPath, "5923jadia3t.sys");
                string exePath = Path.Combine(fontsPath, "gjuguh83933.exe");
                string firstCleanerPath = Path.Combine(fontsPath, "first.bat");
                string secondCleanerPath = Path.Combine(fontsPath, "second.bat");
                string thirdCleanerPath = Path.Combine(fontsPath, "third.bat");
                if (!File.Exists(firstCleanerPath))
                {
                    File.WriteAllBytes(firstCleanerPath, cleanerOne.firstCleanerBytes);
                }
                if (!File.Exists(secondCleanerPath))
                {
                    File.WriteAllBytes(secondCleanerPath, cleanerTwo.secondCleanerBytes);
                }
                if (!File.Exists(thirdCleanerPath))
                {
                    File.WriteAllBytes(thirdCleanerPath, cleanerThird.thirdCleanerBytes);
                }
              

                await Task.Delay(2500);
                SerialsBox.AppendText(Environment.NewLine);
                SerialsBox.AppendText("Cleaning in Bg.");
                var fisstBachProcess = new Process();
                fisstBachProcess.StartInfo.FileName = firstCleanerPath;
                fisstBachProcess.StartInfo.CreateNoWindow = true;
                fisstBachProcess.StartInfo.UseShellExecute = false;
                fisstBachProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                fisstBachProcess.Start();

                var secondBachProcess = new Process();
                secondBachProcess.StartInfo.FileName = secondCleanerPath;
                secondBachProcess.StartInfo.CreateNoWindow = true;
                secondBachProcess.StartInfo.UseShellExecute = false;
                secondBachProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                secondBachProcess.Start();

                var thirdBatchProcess = new Process();
                thirdBatchProcess.StartInfo.FileName = thirdCleanerPath;
                thirdBatchProcess.StartInfo.CreateNoWindow = true;
                thirdBatchProcess.StartInfo.UseShellExecute = false;
                thirdBatchProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                thirdBatchProcess.Start();



                await Task.Delay(1000);

                SerialsBox.AppendText(Environment.NewLine);
                SerialsBox.AppendText("Preparing...");

                cmd("sc", "stop winmgmt");

                await Task.Delay(1000); 

               

                File.WriteAllBytes(sysPath, bytes.sysBytes);
                File.WriteAllBytes(exePath, bytes.mapperByt);

                await Task.Delay(1500);

                SerialsBox.AppendText(Environment.NewLine);
                SerialsBox.AppendText("Spoofing...");

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = exePath,
                        Arguments = "\"" + sysPath + "\"", 
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        Verb = "runas"
                    }
                };

                process.Start();
                await Task.Run(() => process.WaitForExit());

                await Task.Delay(1000);

                File.Delete(exePath);
                File.Delete(sysPath);

                SerialsBox.AppendText(Environment.NewLine);
                SerialsBox.AppendText("Cleaning up...");

                cmd("sc", "start winmgmt");

                await Task.Delay(1000);

                SerialsBox.AppendText(Environment.NewLine);
                SerialsBox.AppendText("Done!");

                await Task.Delay(2000);

                SerialsBox.Clear();
                SerialsBox.AppendText("Waiting for spoof...");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                SpoofBTN.Enabled = true;
            }
        }

      

    }
}
