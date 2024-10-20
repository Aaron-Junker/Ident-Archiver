namespace Ident_Archiver
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;

            RepoTextBox.Text = Properties.Settings.Default.repolocation;
            ytdlpLocationTextBox.Text = Properties.Settings.Default.ytdlplocation;
        }

        public static void CheckSettings(string ytdlpPath, string repoPath)
        {
            if (Properties.Settings.Default.repolocation == "" || Properties.Settings.Default.ytdlplocation == "")
            {
                MessageBox.Show("Please fill in all fields", "Please fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Settings().ShowDialog();
                return;
            }

            if (!File.Exists(ytdlpPath))
            {
                MessageBox.Show("YouTube DLP not found in location", "YouTube DLP not found in location", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Settings().ShowDialog();
                return;
            }

            if (!Directory.Exists(repoPath))
            {
                MessageBox.Show("Repository location not found", "Repository location not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Settings().ShowDialog();
                return;
            }
            else if (!Directory.Exists(repoPath + "/_entries"))
            {
                MessageBox.Show("Repository location does not contain _entries folder", "Repository location does not contain _entries folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Settings().ShowDialog();
                return;
            }
            else if (!Directory.Exists(repoPath + "/media"))
            {
                MessageBox.Show("Repository location does not contain media folder", "Repository location does not contain media folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new Settings().ShowDialog();
                return;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RepoTextBox.Text = RepoTextBox.Text.Replace("/", "\\");
            ytdlpLocationTextBox.Text = ytdlpLocationTextBox.Text.Replace("/", "\\");

            RepoTextBox.Text = RepoTextBox.Text.TrimEnd('\\');
            Properties.Settings.Default.repolocation = RepoTextBox.Text;
            Properties.Settings.Default.ytdlplocation = ytdlpLocationTextBox.Text;

            Properties.Settings.Default.Save();
            Hide();
            Close();

            CheckSettings(Properties.Settings.Default.ytdlplocation, Properties.Settings.Default.repolocation);
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            CheckSettings(Properties.Settings.Default.ytdlplocation, Properties.Settings.Default.repolocation);
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
