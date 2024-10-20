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
    public partial class NewOrgForm : Form
    {
        public NewOrgForm()
        {
            InitializeComponent();
        }

        private const string MarkdownTemplate =
            """
            ---
            layout: org
            smallname: {0}
            fullname: {1}
            ---
            """;

        private const string MarkdownTemplateWithSubOrgs =
            """
            ---
            layout: org
            smallname: {0}
            fullname: {1}
            suborgs: {2}
            ---
            """;
        private void button1_Click(object sender, EventArgs e)
        {
            if (SmallNameTextBox.Text == "" || FullNameTextBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Please fill in all fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string markdown;

            if (SubOrgsTextBox.Text != "")
            {
                markdown = string.Format(MarkdownTemplateWithSubOrgs, SmallNameTextBox.Text, FullNameTextBox.Text, SubOrgsTextBox.Text);
            }
            else
            {
                markdown = string.Format(MarkdownTemplate, SmallNameTextBox.Text, FullNameTextBox.Text);
            }
            File.WriteAllText(Properties.Settings.Default.repolocation + "/categories/org/" + SmallNameTextBox.Text + ".md", markdown);

            MessageBox.Show("Organization added", "Organization added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
