using System.Diagnostics;
using System.Reflection;

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
            sourceurl: {6}
            source: {7}
            ---
            """;

        public Form1()
        {
            new WelcomeForm().ShowDialog();
            if (Properties.Settings.Default.repolocation == "" || Properties.Settings.Default.ytdlplocation == "")
            {
                new Settings().ShowDialog();
            }

            Settings.CheckSettings(Properties.Settings.Default.ytdlplocation, Properties.Settings.Default.repolocation);

            CheckForFfmpeg();
            InitializeComponent();

            label9.Text = "Ident Archiver v" + Assembly.GetExecutingAssembly().GetName().Version!.Major + "." + Assembly.GetExecutingAssembly().GetName().Version!.Minor;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MainMenuStrip = new MenuStrip();

            // ReSharper disable once RedundantExplicitParamsArrayCreation
            MainMenuStrip.Items.Add(new ToolStripMenuItem("File", null, 
                [
                    new ToolStripMenuItem("Settings", null, static (_, _) => new Settings().ShowDialog()),
                    new ToolStripMenuItem("Start screen", null, static (_, _) => new WelcomeForm().ShowDialog()),
                ]));
            MainMenuStrip.Items.Add(new ToolStripMenuItem("Categories", null, 
                [
                    new ToolStripMenuItem("Add new language", null, static (_, _) => new NewLanguageForm().ShowDialog()),
                    new ToolStripMenuItem("Add new organization", null, static (_, _) => new NewOrgForm().ShowDialog()),
                ]));
            MainMenuStrip.Items.Add(new ToolStripMenuItem("Help", null,
                [
                    new ToolStripMenuItem("About", null, static (_, _) => MessageBox.Show("Created by Aaron Junker\n\nLicensed from Aaron Junker Technologies under the MIT license.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)),
                    new ToolStripMenuItem("GitHub", null, static (_, _) => Process.Start(new ProcessStartInfo("https://github.com/aaron-junker/ident-archiver") { UseShellExecute = true })),
                ]));
            MainMenuStrip.RenderMode = ToolStripRenderMode.System;

            MainMenuStrip.Location = new Point(0, 0);

            MainMenuStrip.Margin = Padding.Empty;
            MainMenuStrip.Padding = Padding.Empty;

            Controls.Add(MainMenuStrip);

            LangTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            DateTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            OrganizationTextBox.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            OrganizationTextBox.AutoCompleteCustomSource.AddRange(OrganizationDropdown);
            OrganizationTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            WatermarkTextBox.AutoCompleteCustomSource = OrganizationTextBox.AutoCompleteCustomSource;
            WatermarkTextBox.AutoCompleteCustomSource.Add("None");
            WatermarkTextBox.AutoCompleteCustomSource.Remove("Source");
            WatermarkTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private static string[] OrganizationDropdown =
        [
            "SRF",
            "RTS",
            "RSI",
            "RTR",
            "Disney Channel",
            "Schweizerische Eidgenossenschaft",
            "Source",
            "ABC",
            "BBC",
            "ZDF",
            "ARD",
        ];
        private static void CheckForFfmpeg()
        {
            Process p = new()
            {
                StartInfo = new()
                {
                    FileName = "ffmpeg.exe",
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            try
            {
                p.Start();
            }
            catch
            {
                MessageBox.Show(Properties.Resources.Error_FFMPEG_Not_Found_Content, Properties.Resources.Error_FFMPEG_Not_Found_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            p.WaitForExit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!CheckFilledOutRequiredFields())
            {
                MessageBox.Show(Properties.Resources.Error_Required_Fields_Content, Properties.Resources.Error_Required_Fields_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            toolStripStatusLabel1.Text = Properties.Resources.Status_Busy;

            string currentFileName = OrganizationTextBox.Text + "-" + ShortNameTextBox.Text + "-" + WatermarkTextBox.Text + "-" + LangTextBox.Text + "-" + DateTextBox.Text;

            // Download video using youtube-dl
            ProcessStartInfo startInfo = new()
            {
                FileName = Properties.Settings.Default.ytdlplocation,
                Arguments = (TrimCheckBox.Checked ? "--download-sections \"*" + FromTextBox.Text + "-" + ToTextBox.Text + "\" " : "") + "-f mp4 -P \"" + Properties.Settings.Default.repolocation + "\\media\" -o \"" + currentFileName + ".mp4\" \"" + UrlTextBox.Text + "\"",
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            CmdTextBox.Text = startInfo.Arguments;

            Process p = new()
            {
                StartInfo = startInfo
            };
            try
            {
                p.Start();
            }
            catch
            {
                MessageBox.Show(Properties.Resources.Error_Ytdlp_Not_Found_Content, Properties.Resources.Error_Ytdlp_Not_Found_Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            File.WriteAllText(Properties.Settings.Default.repolocation + "/_entries/" + currentFileName + ".md", markdown);
            toolStripStatusLabel1.Text = Properties.Resources.Status_Ready;
        }

        private bool CheckFilledOutRequiredFields()
        {
            return OrganizationTextBox.Text != "" && ShortNameTextBox.Text != "" && LangTextBox.Text != "" && DateTextBox.Text != "" && LongNameTextBox.Text != "" && WatermarkTextBox.Text != "" && UrlTextBox.Text != "";
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

        private void TrimCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TrimCheckBox.Checked)
            {
                FromTextBox.Enabled = true;
                ToTextBox.Enabled = true;
            }
            else
            {
                FromTextBox.Enabled = false;
                ToTextBox.Enabled = false;
            }
        }
    }
}
