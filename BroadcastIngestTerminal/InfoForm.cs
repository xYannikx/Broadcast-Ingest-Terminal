using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BroadcastIngestTerminal
{
    public partial class InfoForm : Form
    {
        private const string ProgramVersion = "1.0";

        public InfoForm()
        {
            InitializeComponent();
            
            string osInfo = Environment.OSVersion.VersionString;
            lblOSValue.Text = osInfo;

            string engineInfo = GetFfmpegVersion();
            lblEngineValue.Text = engineInfo;

            if (engineInfo == "Nicht gefunden!" || engineInfo == "Not found!" || engineInfo.Contains("Fehler") || engineInfo.Contains("Error"))
            {
                lblEngineValue.ForeColor = Color.Red;
            }
            else
            {
                lblEngineValue.ForeColor = Color.Green;
            }

            if (Form1.IsEnglish)
            {
                this.Text = "About / Credits";
                lblTitle.Text = "Broadcast Ingest Terminal";

                groupSystem.Text = "System Information";
                lblOS.Text = "OS:";
                lblVersion.Text = "Program Version:";
                lblVersionValue.Text = ProgramVersion;
                lblEngine.Text = "Engine:";

                groupCredits.Text = "Credits";
                lblCreator.Text = "Creator: xYannikx";
                linkCreator.Text = "GitHub Profile";

                lblIcon.Text = "Icon Creator: Trisii";
                linkIcon.Text = "GitHub Profile";
            }
            else
            {
                this.Text = "Info / Credits";
                lblTitle.Text = "Broadcast Ingest Terminal";

                groupSystem.Text = "System-Informationen";
                lblOS.Text = "Betriebssystem:";
                lblVersion.Text = "Programmversion:";
                lblVersionValue.Text = ProgramVersion;
                lblEngine.Text = "Engine:";

                groupCredits.Text = "Credits";
                lblCreator.Text = "Ersteller: xYannikx";
                linkCreator.Text = "GitHub Profil";

                lblIcon.Text = "Icon Ersteller: Trisii";
                linkIcon.Text = "GitHub Profil";
            }
        }

        private string GetFfmpegVersion()
        {
            if (!File.Exists(Form1.activeFfmpegPath))
            {
                return Form1.IsEnglish ? "Not found!" : "Nicht gefunden!";
            }

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = Form1.activeFfmpegPath;
                psi.Arguments = "-version";
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadLine();
                    process.WaitForExit();

                    if (!string.IsNullOrEmpty(output))
                    {
                        string[] parts = output.Split(' ');
                        if (parts.Length >= 3)
                            return parts[0] + " " + parts[1] + " " + parts[2];

                        return output;
                    }
                }
            }
            catch
            {
                return Form1.IsEnglish ? "Error" : "Fehler";
            }

            return Form1.IsEnglish ? "Unknown" : "Unbekannt";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkCreator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/xYannikx");
        }

        private void linkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Trisii");
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
