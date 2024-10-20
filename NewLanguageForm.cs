using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ident_Archiver
{
    public partial class NewLanguageForm : Form
    {
        public NewLanguageForm()
        {
            InitializeComponent();
        }

        private const string MarkdownTemplate =
            """
            ---
            layout: language
            smallname: {0}
            fullname: {1}
            ---
            """;
        private void button1_Click(object sender, EventArgs e)
        {
            if (SmallNameTextBox.Text == "" || FullNameTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Please fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string markdown = string.Format(MarkdownTemplate, SmallNameTextBox.Text, FullNameTextBox.Text);
            File.WriteAllText(Properties.Settings.Default.repolocation + "/categories/language/" + SmallNameTextBox.Text + ".md", markdown);

            MessageBox.Show("Language added", "Language added", MessageBoxButtons.OK, MessageBoxIcon.Information);  

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
