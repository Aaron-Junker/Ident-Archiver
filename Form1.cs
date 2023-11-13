using System.Diagnostics;
using System.Text;

namespace Ident_Archiver
{
    public partial class Form1 : Form
    {
        private const string MarkdownTemplate =
            """
            ---
            layout: entry
            title: {0}
            organization: {1}
            usagedate: {2}
            language: {3}
            fulltitle: {4}
            watermark: {5}
            ---
            """;

        private const string MarkdownTemplateWithSource =
            """
            ---
            layout: entry
            title: {0}
            organization: {1}
            usagedate: {2}
            language: {3}
            fulltitle: {4}
            watermark: {5}
            source: {6}
            sourcetext: {7}
            ---
            """;

        public Form1()
        {
            checkForFfmpeg();
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MainMenuStrip = new MenuStrip();

            MainMenuStrip.Items.Add(new ToolStripMenuItem("File", null, new[] { new ToolStripMenuItem("Settings", null, (_, _) => new Settings().ShowDialog()), new ToolStripMenuItem("Start screen") }));

            MainMenuStrip.RenderMode = ToolStripRenderMode.System;

            MainMenuStrip.Location = new Point(0, 0);

            MainMenuStrip.Margin = Padding.Empty;
            MainMenuStrip.Padding = Padding.Empty;

            Controls.Add(MainMenuStrip);

            LangTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DateTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OrganizationTextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            OrganizationTextBox.AutoCompleteCustomSource.AddRange(new string[]
            {
                "SRF",
                "RTS",
                "RSI",
                "RTR",
                "Disney Channel",
                "Schweizerische Eidgenossenschaft",
                "Source",
                "ABC",
                "BBC"
            });
            OrganizationTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            WatermarkTextBox.AutoCompleteCustomSource = OrganizationTextBox.AutoCompleteCustomSource;
            WatermarkTextBox.AutoCompleteCustomSource.Add("None");
            WatermarkTextBox.AutoCompleteCustomSource.Remove("Source");
            WatermarkTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void checkForFfmpeg()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            Process p = new Process();
            p.StartInfo = startInfo;
            try
            {
                p.Start();
            }
            catch
            {
                MessageBox.Show("ffmpeg was not found. Please install ffmpeg and add its location in the PATH environment variable.", "ffmpeg not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            p.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Busy...";

            string currentFileName = OrganizationTextBox.Text + "-" + ShortNameTextBox.Text + "-" + WatermarkTextBox.Text + "-" + LangTextBox.Text + "-" + DateTextBox.Text;

            // Download video using youtube-dl
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.ytdlplocation,
                Arguments = "--download-sections \"*" + FromTextBox.Text + "-" + ToTextBox.Text + "\" -P \"" + Properties.Settings.Default.repolocation + "\\media\" -o \"" + currentFileName + ".mp4\" \"" + UrlTextBox.Text + "\"",
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            CmdTextBox.Text = startInfo.Arguments;

            Process p = new Process();
            p.StartInfo = startInfo;
            try
            {
                p.Start();
            }
            catch
            {
                MessageBox.Show("yt-dlp was not found. Please install yt-dlp and add its location in the settings.", "yt-dlp not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            p.Start();
            p.WaitForExit();

            string markdown = STextBox.Text != ""
                ? string.Format(MarkdownTemplateWithSource, ShortNameTextBox.Text, OrganizationTextBox.Text,
                    DateTextBox.Text, LangTextBox.Text, LongNameTextBox.Text, WatermarkTextBox.Text,
                    STextBox.Text, STTextBox.Text)
                : string.Format(MarkdownTemplate, ShortNameTextBox.Text, OrganizationTextBox.Text, DateTextBox.Text,
                    LangTextBox.Text, LongNameTextBox.Text, WatermarkTextBox.Text);

            CmdOutTextBox.Text = p.StandardError.ReadToEnd();

            File.WriteAllText("K:/ident-archive/_entries/" + currentFileName + ".md", markdown);
            toolStripStatusLabel1.Text = "Ready";
        }


        private void CleanButton_Click(object sender, EventArgs e)
        {
            OrganizationTextBox.Text = "";
            ShortNameTextBox.Text = "";
            LangTextBox.Text = "";
            DateTextBox.Text = "";
            LongNameTextBox.Text = "";
            WatermarkTextBox.Text = "";
            UrlTextBox.Text = @"https://";
            FromTextBox.Text = @"0:00";
            ToTextBox.Text = @"10:00";
            STextBox.Text = "";
            STTextBox.Text = "";
        }
    }
}
