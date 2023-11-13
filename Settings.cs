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

        private void button1_Click(object sender, EventArgs e)
        {
            RepoTextBox.Text = RepoTextBox.Text.Replace("/", "\\");
            ytdlpLocationTextBox.Text = ytdlpLocationTextBox.Text.Replace("/", "\\");

            RepoTextBox.Text = RepoTextBox.Text.TrimEnd('\\');
            Properties.Settings.Default.repolocation = RepoTextBox.Text;
            Properties.Settings.Default.ytdlplocation = ytdlpLocationTextBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }
    }
}
