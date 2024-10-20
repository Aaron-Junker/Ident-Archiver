namespace Ident_Archiver
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
