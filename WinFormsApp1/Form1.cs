using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void btnLoadProfiles_Click(object sender, EventArgs e)
        {
            lstNetworks.Items.Clear();

            ProcessStartInfo psi = new ProcessStartInfo("netsh", "wlan show profiles")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Regex regex = new Regex(@"All User Profile\s*:\s*(.+)");
                MatchCollection matches = regex.Matches(output);

                foreach (Match match in matches)
                {
                    lstNetworks.Items.Add(match.Groups[1].Value.Trim());
                }
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
             if (lstNetworks.SelectedItem == null)
              {
                  MessageBox.Show("Lütfen bir að seçin.");
                  return;
              }

              string profileName = lstNetworks.SelectedItem.ToString();
              string password = GetWifiPassword(profileName);

              txtPassword.Text = password ?? "Þifre bulunamadý veya þifrelenmiþ.";
         
         
        }

        private string GetWifiPassword(string profileName)
        {
            string password = GetPasswordFromOutput(profileName, null);
            if (password != null)
            {
                return password;
            }

            return GetPasswordFromOutput(profileName, Encoding.GetEncoding(857));
        }

        private string GetPasswordFromOutput(string profileName, Encoding encoding)
        {
            ProcessStartInfo psi = new ProcessStartInfo("netsh", $"wlan show profile name=\"{profileName}\" key=clear")
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = encoding
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                using (StringReader reader = new StringReader(output))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("Key Content"))
                        {
                            string[] parts = line.Split(':');
                            if (parts.Length > 1)
                            {
                                return parts[1].Trim();
                            }
                        }
                    }
                }
            }
            return null;
        }

        private void txtPassword_ContentChanged(object sender, EventArgs e)
        {

        }
    }
}