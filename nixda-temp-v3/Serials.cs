using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nixdatempv3
{
    public partial class Serials : Form
    {
        public Serials()
        {
            InitializeComponent();
        }

        private void Serials_Load(object sender, EventArgs e)
        {


            TimeText.Text = "Time: " + DateTime.Now.ToString("HH:mm | dd/MM/yyyy");

            var sb = new System.Text.StringBuilder();

    
            sb.AppendLine("DISK SERIALS");
            foreach (var disk in new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive").Get())
            {
                var serial = disk["SerialNumber"]?.ToString()?.Trim();
                if (!string.IsNullOrWhiteSpace(serial))
                    sb.AppendLine(serial);
            }
            sb.AppendLine();


            sb.AppendLine("UUID");
            foreach (var cs in new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct").Get())
            {
                var uuid = cs["UUID"]?.ToString()?.Trim();
                if (!string.IsNullOrWhiteSpace(uuid))
                    sb.AppendLine(uuid);
            }
            sb.AppendLine();

            sb.AppendLine("BASEBOARD");
            foreach (var board in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
            {
                var serial = board["SerialNumber"]?.ToString()?.Trim();
                if (!string.IsNullOrWhiteSpace(serial))
                    sb.AppendLine(serial);
            }
            sb.AppendLine();

            sb.AppendLine("MAC");
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = "getmac";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();

                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();

                var lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 0 && parts[0].Contains("-"))
                    {
                        sb.AppendLine(parts[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine("Failed to get addresses");
            }


            SerialsBox.Text = sb.ToString();
        }
    }
}
