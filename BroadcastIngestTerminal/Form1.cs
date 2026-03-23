using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BroadcastIngestTerminal
{
    public partial class Form1 : Form
    {
        private List<string> fileList = new List<string>();
        
        // Holt sich dynamisch den Pfad zum "Eigene Dokumente"-Ordner des Benutzers
        private static string userDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        // Erstellt dort den Haupt-App-Ordner: z.B. "C:\Users\DeinName\Documents\Broadcast Ingest Terminal"
        private string appDataFolder = Path.Combine(userDocs, "Broadcast Ingest Terminal");
        
        // Settings und OUT_MASTERS liegen nun sicher im Dokumente-Ordner
        private string outFolder;
        private string settingsFile;
        
        public static string activeFfmpegPath = "";
        public static bool IsEnglish = false; 

        public Form1()
        {
            // Initialisiere die sicheren Pfade
            outFolder = Path.Combine(appDataFolder, "OUT_MASTERS");
            settingsFile = Path.Combine(appDataFolder, "settings.ini");

            // Erstelle die App-Daten-Ordner in "Dokumente", falls sie fehlen
            if (!Directory.Exists(appDataFolder))
            {
                Directory.CreateDirectory(appDataFolder);
            }
            if (!Directory.Exists(outFolder))
            {
                Directory.CreateDirectory(outFolder);
            }

            InitializeComponent();
            DetectAndSetFfmpegVersion();
            SetProgressBarStyle(); 
            LoadSettings(); 
            
            // Zweiter Sicherheits-Check nach LoadSettings (falls Pfad in der ini ungültig ist)
            try
            {
                if (!Directory.Exists(outFolder))
                {
                    Directory.CreateDirectory(outFolder);
                }
            }
            catch
            {
                // Fallback zurück zum Dokumente-Ordner
                outFolder = Path.Combine(appDataFolder, "OUT_MASTERS");
                Directory.CreateDirectory(outFolder);
            }

            ApplyLanguage(false);
        }

        private void LoadSettings()
        {
            if (File.Exists(settingsFile))
            {
                string[] lines = File.ReadAllLines(settingsFile);
                foreach (string line in lines)
                {
                    if (line.StartsWith("OutputPath="))
                    {
                        outFolder = line.Substring(11);
                        break;
                    }
                }
            }
        }

        private void SaveSettings()
        {
            File.WriteAllText(settingsFile, "OutputPath=" + outFolder);
        }

        private void DetectAndSetFfmpegVersion()
        {
            // FFMPEG sucht er exakt da, wo die .exe liegt (in C:\Programme)
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            Version os = Environment.OSVersion.Version;

            if (os.Major == 5 || (os.Major == 6 && os.Minor == 0))
            {
                activeFfmpegPath = Path.Combine(appDir, "ffmpeglegacy.exe");
            }
            else
            {
                activeFfmpegPath = Path.Combine(appDir, "ffmpeg.exe");
            }
        }

        private void SetProgressBarStyle()
        {
            Version os = Environment.OSVersion.Version;
            if (os.Major == 5)
            {
                progressBar1.Style = ProgressBarStyle.Blocks;
            }
            else
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
            }
        }

        private void ApplyLanguage(bool setEnglish)
        {
            IsEnglish = setEnglish;
            deutschToolStripMenuItem.Checked = !setEnglish;
            englishToolStripMenuItem.Checked = setEnglish;

            int selectedIndex = comboBoxFormat.SelectedIndex;
            if (selectedIndex < 0) selectedIndex = 0;
            comboBoxFormat.Items.Clear();

            if (!setEnglish) // DEUTSCH
            {
                this.Text = "Broadcast Ingest Terminal";
                dateiToolStripMenuItem.Text = "Datei";
                dateiHinzufügenToolStripMenuItem.Text = "Dateien hinzufügen...";
                listeLeerenToolStripMenuItem.Text = "Liste leeren";
                beendenToolStripMenuItem.Text = "Beenden";
                
                pfadToolStripMenuItem.Text = "Pfad";
                ausgabeordnerÄndernToolStripMenuItem.Text = "Ausgabeordner ändern...";
                ausgabeordnerZuruecksetzenToolStripMenuItem.Text = "Ausgabeordner zurücksetzen";
                
                spracheToolStripMenuItem.Text = "Sprache";
                infoToolStripMenuItem1.Text = "Info";
                infoCreditsToolStripMenuItem.Text = "Info / Credits";
                
                entfernenToolStripMenuItem.Text = "Datei entfernen";

                lblInfoSource.Text = "WICHTIG: Quellmaterial muss 16:9 sein!";
                lblInfoOutput.Text = "Output: Erzeugt zwei .mov Dateien (v210 Uncompressed 10-bit, 576i, PCM 48kHz Stereo):\n1x 16:9 FHA (Full Height Anamorphic) Master\n1x 4:3 LB (Letterbox) Master";

                btnAddFiles.Text = "Dateien hinzufügen (oder per Drag && Drop)";
                buttonClear.Text = "Liste leeren";
                buttonStart.Text = "Verarbeitung starten";
                if (labelStatus.Text == "Ready.") labelStatus.Text = "Bereit.";
                else if (labelStatus.Text == "Done!") labelStatus.Text = "Fertig!";

                comboBoxFormat.Items.Add("25p (Nativ PAL - Kein Speedup)");
                comboBoxFormat.Items.Add("25i (Nativ Interlaced - Intelligentes Deinterlacing)");
                comboBoxFormat.Items.Add("23.976p (Web/NTSC - 4% Speedup inkl. Pitch)");
                comboBoxFormat.Items.Add("24.000p (Kino - 4% Speedup inkl. Pitch)");
                comboBoxFormat.Items.Add("29.97i (HDCAM/Telecine - IVTC Pulldown + 4% Speedup inkl. Pitch)");
            }
            else // ENGLISCH
            {
                this.Text = "Broadcast Ingest Terminal";
                dateiToolStripMenuItem.Text = "File";
                dateiHinzufügenToolStripMenuItem.Text = "Add Files...";
                listeLeerenToolStripMenuItem.Text = "Clear List";
                beendenToolStripMenuItem.Text = "Exit";
                
                pfadToolStripMenuItem.Text = "Path";
                ausgabeordnerÄndernToolStripMenuItem.Text = "Change Output Folder...";
                ausgabeordnerZuruecksetzenToolStripMenuItem.Text = "Reset Output Folder";
                
                spracheToolStripMenuItem.Text = "Language";
                infoToolStripMenuItem1.Text = "Info";
                infoCreditsToolStripMenuItem.Text = "Info / Credits";
                
                entfernenToolStripMenuItem.Text = "Remove File";

                lblInfoSource.Text = "IMPORTANT: Source material must be 16:9!";
                lblInfoOutput.Text = "Output: Creates two .mov files (v210 Uncompressed 10-bit, 576i, PCM 48kHz Stereo):\n1x 16:9 FHA (Full Height Anamorphic) Master\n1x 4:3 LB (Letterbox) Master";

                btnAddFiles.Text = "Add Files (or Drag && Drop)";
                buttonClear.Text = "Clear List";
                buttonStart.Text = "Start Processing";
                if (labelStatus.Text == "Bereit.") labelStatus.Text = "Ready.";
                else if (labelStatus.Text == "Fertig!") labelStatus.Text = "Done!";

                comboBoxFormat.Items.Add("25p (Native PAL - No Speedup)");
                comboBoxFormat.Items.Add("25i (Native Interlaced - Smart Deinterlacing)");
                comboBoxFormat.Items.Add("23.976p (Web/NTSC - 4% Speedup incl. Pitch)");
                comboBoxFormat.Items.Add("24.000p (Cinema - 4% Speedup incl. Pitch)");
                comboBoxFormat.Items.Add("29.97i (HDCAM/Telecine - IVTC Pulldown + 4% Speedup incl. Pitch)");
            }

            comboBoxFormat.SelectedIndex = selectedIndex;
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e) { ApplyLanguage(false); }
        private void englishToolStripMenuItem_Click(object sender, EventArgs e) { ApplyLanguage(true); }

        private void dateiHinzufügenToolStripMenuItem_Click(object sender, EventArgs e) { btnAddFiles_Click(sender, e); }
        private void listeLeerenToolStripMenuItem_Click(object sender, EventArgs e) { buttonClear_Click(sender, e); }
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
        private void infoCreditsToolStripMenuItem_Click(object sender, EventArgs e) { new InfoForm().ShowDialog(); }

        private void ausgabeordnerÄndernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = IsEnglish ? "Select custom output folder:" : "Wähle einen eigenen Ausgabeordner:";
            fbd.SelectedPath = outFolder;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                outFolder = fbd.SelectedPath;
                SaveSettings();
            }
        }

        private void ausgabeordnerZuruecksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            outFolder = Path.Combine(appDataFolder, "OUT_MASTERS");
            if (File.Exists(settingsFile)) File.Delete(settingsFile);
            MessageBox.Show(IsEnglish ? "Output path reset to default." : "Ausgabepfad wurde auf Standard zurückgesetzt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Video Dateien|*.mp4;*.mov;*.mxf;*.avi;*.mkv;*.mpg;*.mpeg;*.wmv;*.ts|Alle Dateien|*.*";
            ofd.Title = IsEnglish ? "Select Videos" : "Wähle Videos";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!fileList.Contains(file))
                    {
                        fileList.Add(file);
                        listBoxFiles.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            List<string> validExts = new List<string> { ".mp4", ".mov", ".mxf", ".avi", ".mkv", ".mpg", ".mpeg", ".wmv", ".ts" };
            
            foreach (string file in files)
            {
                string ext = Path.GetExtension(file).ToLower();
                if (validExts.Contains(ext) && !fileList.Contains(file))
                {
                    fileList.Add(file);
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
        }

        private void listBoxFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxFiles.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    listBoxFiles.SelectedIndex = index;
                    contextMenuStrip1.Show(listBoxFiles, e.Location);
                }
            }
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = listBoxFiles.SelectedIndex;
            if (index >= 0 && index < fileList.Count)
            {
                fileList.RemoveAt(index);
                listBoxFiles.Items.RemoveAt(index);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            listBoxFiles.Items.Clear();
            labelStatus.Text = IsEnglish ? "Ready." : "Bereit.";
            progressBar1.Value = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (fileList.Count == 0) return;

            buttonStart.Enabled = false;
            buttonClear.Enabled = false;
            btnAddFiles.Enabled = false;
            comboBoxFormat.Enabled = false;
            menuStrip1.Enabled = false;

            string v_mod = "";
            string a_mod = "";

            switch (comboBoxFormat.SelectedIndex)
            {
                case 1: v_mod = "bwdif=0,"; break;
                case 2: v_mod = "setpts=N/(25*TB),"; a_mod = "atempo=25/(24000/1001),"; break;
                case 3: v_mod = "setpts=N/(25*TB),"; a_mod = "atempo=25/24,"; break;
                case 4: v_mod = "fieldmatch,decimate,setpts=N/(25*TB),"; a_mod = "atempo=25/(24000/1001),"; break;
            }

            string fcomplex = string.Format("[0:v]{0}colorspace=all=bt601-6-625:iall=bt709:fast=1,split=2[v_b1][v_b2]; [v_b1]scale=704:432:flags=spline,pad=720:576:8:72:black,setfield=tff[v_out_43]; [v_b2]scale=704:576:flags=spline,pad=720:576:8:0:black,setfield=tff[v_out_169]; [0:a]{1}loudnorm=I=-23:LRA=15:TP=-1,pan=4c|c0=FL|c1=FR|c2=FL|c3=FR,aresample=48000,asplit=2[a_o1][a_o2]", v_mod, a_mod);

            progressBar1.Maximum = 100;

            for (int i = 0; i < fileList.Count; i++)
            {
                progressBar1.Value = 0;
                string inputFile = fileList[i];
                string fileNameNoExt = Path.GetFileNameWithoutExtension(inputFile);
                
                labelStatus.Text = (IsEnglish ? "Processing " : "Verarbeite ") + (i + 1) + "/" + fileList.Count + ": " + Path.GetFileName(inputFile);
                Application.DoEvents();

                string args = string.Format("-i \"{0}\" -filter_complex \"{1}\" -map \"[v_out_43]\" -map \"[a_o1]\" -r 25 -c:v v210 -c:a pcm_s16le -ar 48000 -aspect 4:3 -color_primaries bt470bg -color_trc bt709 -colorspace bt470bg -y \"{2}\" -map \"[v_out_169]\" -map \"[a_o2]\" -r 25 -c:v v210 -c:a pcm_s16le -ar 48000 -aspect 16:9 -color_primaries bt470bg -color_trc bt709 -colorspace bt470bg -y \"{3}\"", inputFile, fcomplex, Path.Combine(outFolder, fileNameNoExt + "_4x3_LB.mov"), Path.Combine(outFolder, fileNameNoExt + "_16x9_FHA.mov"));

                ProcessStartInfo startInfo = new ProcessStartInfo(activeFfmpegPath, args);
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardError = true;
                
                if (!File.Exists(activeFfmpegPath))
                {
                    MessageBox.Show(IsEnglish ? "Engine missing!" : "Die Engine fehlt!", "Fehler / Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                double totalDuration = 0;
                Process process = new Process();
                process.StartInfo = startInfo;

                process.ErrorDataReceived += delegate(object senderProcess, DataReceivedEventArgs ev)
                {
                    if (ev.Data != null)
                    {
                        string line = ev.Data;
                        if (line.Contains("Duration:"))
                        {
                            int start = line.IndexOf("Duration: ") + 10;
                            int end = line.IndexOf(",", start);
                            if (start >= 10 && end > start)
                            {
                                string durationStr = line.Substring(start, end - start);
                                try
                                {
                                    string[] p = durationStr.Split(':', '.');
                                    if (p.Length >= 3) totalDuration = int.Parse(p[0]) * 3600 + int.Parse(p[1]) * 60 + int.Parse(p[2]);
                                }
                                catch { }
                            }
                        }
                        if (line.Contains("time="))
                        {
                            int start = line.IndexOf("time=") + 5;
                            int end = line.IndexOf(" ", start);
                            if (end == -1) end = line.Length;
                            string timeStr = line.Substring(start, end - start).Replace("-", "");
                            try
                            {
                                string[] p = timeStr.Split(':', '.');
                                if (p.Length >= 3)
                                {
                                    double currentSecs = int.Parse(p[0]) * 3600 + int.Parse(p[1]) * 60 + int.Parse(p[2]);
                                    if (totalDuration > 0)
                                    {
                                        int percent = (int)((currentSecs / totalDuration) * 100);
                                        if (percent > 100) percent = 100;
                                        if (percent < 0) percent = 0;
                                        
                                        this.Invoke((MethodInvoker)delegate { progressBar1.Value = percent; });
                                    }
                                }
                            }
                            catch { }
                        }
                    }
                };

                process.Start();
                process.BeginErrorReadLine();

                while (!process.HasExited)
                {
                    Application.DoEvents();
                    Thread.Sleep(20);
                }
                process.Close();
                
                progressBar1.Value = 100; 
            }

            labelStatus.Text = IsEnglish ? "Done!" : "Fertig!";
            buttonStart.Enabled = true;
            buttonClear.Enabled = true;
            btnAddFiles.Enabled = true;
            comboBoxFormat.Enabled = true;
            menuStrip1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
