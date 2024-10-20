namespace Ident_Archiver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            UrlTextBox = new TextBox();
            FromTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ToTextBox = new TextBox();
            label4 = new Label();
            LongNameTextBox = new TextBox();
            label5 = new Label();
            WatermarkTextBox = new TextBox();
            label6 = new Label();
            DateTextBox = new TextBox();
            LanguageTextBox = new Label();
            OrgTextBox = new Label();
            SourceTextTextBox = new Label();
            STextBox = new TextBox();
            SourceTextBox = new Label();
            ShortNameTextBox = new TextBox();
            LangTextBox = new TextBox();
            OrganizationTextBox = new TextBox();
            STTextBox = new TextBox();
            label7 = new Label();
            button1 = new Button();
            CmdTextBox = new TextBox();
            CmdOutTextBox = new TextBox();
            label8 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            CleanButton = new Button();
            label9 = new Label();
            TrimCheckBox = new CheckBox();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 71);
            label1.Name = "label1";
            label1.Size = new Size(22, 16);
            label1.TabIndex = 0;
            label1.Text = "Url";
            // 
            // UrlTextBox
            // 
            UrlTextBox.Location = new Point(92, 68);
            UrlTextBox.Name = "UrlTextBox";
            UrlTextBox.Size = new Size(479, 23);
            UrlTextBox.TabIndex = 1;
            UrlTextBox.Text = "https://";
            // 
            // FromTextBox
            // 
            FromTextBox.Location = new Point(137, 96);
            FromTextBox.Name = "FromTextBox";
            FromTextBox.Size = new Size(49, 23);
            FromTextBox.TabIndex = 2;
            FromTextBox.Text = "0:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 100);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 2;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 16);
            label3.TabIndex = 4;
            label3.Text = "Short name";
            // 
            // ToTextBox
            // 
            ToTextBox.Location = new Point(217, 96);
            ToTextBox.Name = "ToTextBox";
            ToTextBox.Size = new Size(49, 23);
            ToTextBox.TabIndex = 3;
            ToTextBox.Text = "10:00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 99);
            label4.Name = "label4";
            label4.Size = new Size(19, 16);
            label4.TabIndex = 7;
            label4.Text = "To";
            // 
            // LongNameTextBox
            // 
            LongNameTextBox.Location = new Point(92, 158);
            LongNameTextBox.Name = "LongNameTextBox";
            LongNameTextBox.Size = new Size(479, 23);
            LongNameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 161);
            label5.Name = "label5";
            label5.Size = new Size(68, 16);
            label5.TabIndex = 8;
            label5.Text = "Long name";
            // 
            // WatermarkTextBox
            // 
            WatermarkTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            WatermarkTextBox.Location = new Point(92, 187);
            WatermarkTextBox.Name = "WatermarkTextBox";
            WatermarkTextBox.PlaceholderText = "None";
            WatermarkTextBox.Size = new Size(479, 23);
            WatermarkTextBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 190);
            label6.Name = "label6";
            label6.Size = new Size(66, 16);
            label6.TabIndex = 10;
            label6.Text = "Watermark";
            // 
            // DateTextBox
            // 
            DateTextBox.AutoCompleteCustomSource.AddRange(new string[] { "Unknown" });
            DateTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DateTextBox.Location = new Point(92, 216);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.PlaceholderText = "yyyy-mm-dd or yyyy or yyyy-yyyy or  ~yyyy or Unknown";
            DateTextBox.Size = new Size(479, 23);
            DateTextBox.TabIndex = 7;
            // 
            // LanguageTextBox
            // 
            LanguageTextBox.AutoSize = true;
            LanguageTextBox.Location = new Point(14, 248);
            LanguageTextBox.Name = "LanguageTextBox";
            LanguageTextBox.Size = new Size(60, 16);
            LanguageTextBox.TabIndex = 14;
            LanguageTextBox.Text = "Language";
            // 
            // OrgTextBox
            // 
            OrgTextBox.AutoSize = true;
            OrgTextBox.Location = new Point(14, 277);
            OrgTextBox.Name = "OrgTextBox";
            OrgTextBox.Size = new Size(76, 16);
            OrgTextBox.TabIndex = 16;
            OrgTextBox.Text = "Organization";
            // 
            // SourceTextTextBox
            // 
            SourceTextTextBox.AutoSize = true;
            SourceTextTextBox.Location = new Point(14, 335);
            SourceTextTextBox.Name = "SourceTextTextBox";
            SourceTextTextBox.Size = new Size(70, 16);
            SourceTextTextBox.TabIndex = 18;
            SourceTextTextBox.Text = "Source Text";
            // 
            // STextBox
            // 
            STextBox.Location = new Point(92, 303);
            STextBox.Name = "STextBox";
            STextBox.PlaceholderText = "optional";
            STextBox.Size = new Size(479, 23);
            STextBox.TabIndex = 10;
            // 
            // SourceTextBox
            // 
            SourceTextBox.AutoSize = true;
            SourceTextBox.Location = new Point(14, 306);
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(45, 16);
            SourceTextBox.TabIndex = 20;
            SourceTextBox.Text = "Source";
            // 
            // ShortNameTextBox
            // 
            ShortNameTextBox.Location = new Point(92, 129);
            ShortNameTextBox.Name = "ShortNameTextBox";
            ShortNameTextBox.Size = new Size(479, 23);
            ShortNameTextBox.TabIndex = 4;
            // 
            // LangTextBox
            // 
            LangTextBox.AutoCompleteCustomSource.AddRange(new string[] { "de", "en", "rt", "it", "fr" });
            LangTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            LangTextBox.Location = new Point(92, 245);
            LangTextBox.Name = "LangTextBox";
            LangTextBox.PlaceholderText = "xx";
            LangTextBox.Size = new Size(479, 23);
            LangTextBox.TabIndex = 8;
            // 
            // OrganizationTextBox
            // 
            OrganizationTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            OrganizationTextBox.Location = new Point(92, 274);
            OrganizationTextBox.Name = "OrganizationTextBox";
            OrganizationTextBox.Size = new Size(479, 23);
            OrganizationTextBox.TabIndex = 9;
            // 
            // STTextBox
            // 
            STTextBox.Location = new Point(92, 332);
            STTextBox.Name = "STTextBox";
            STTextBox.PlaceholderText = "optional";
            STTextBox.Size = new Size(479, 23);
            STTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 219);
            label7.Name = "label7";
            label7.Size = new Size(33, 16);
            label7.TabIndex = 26;
            label7.Text = "Date";
            // 
            // button1
            // 
            button1.Location = new Point(14, 363);
            button1.Name = "button1";
            button1.Size = new Size(76, 23);
            button1.TabIndex = 12;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // CmdTextBox
            // 
            CmdTextBox.Location = new Point(14, 403);
            CmdTextBox.Name = "CmdTextBox";
            CmdTextBox.PlaceholderText = "Command";
            CmdTextBox.ReadOnly = true;
            CmdTextBox.Size = new Size(776, 23);
            CmdTextBox.TabIndex = 27;
            // 
            // CmdOutTextBox
            // 
            CmdOutTextBox.Location = new Point(14, 432);
            CmdOutTextBox.Multiline = true;
            CmdOutTextBox.Name = "CmdOutTextBox";
            CmdOutTextBox.PlaceholderText = "Output";
            CmdOutTextBox.ReadOnly = true;
            CmdOutTextBox.Size = new Size(776, 116);
            CmdOutTextBox.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Small", 19F);
            label8.Location = new Point(12, 31);
            label8.Name = "label8";
            label8.Size = new Size(388, 35);
            label8.TabIndex = 29;
            label8.Text = "Ident Archiver for Ident Archive";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 566);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 30;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(40, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // CleanButton
            // 
            CleanButton.Location = new Point(96, 363);
            CleanButton.Name = "CleanButton";
            CleanButton.Size = new Size(76, 23);
            CleanButton.TabIndex = 31;
            CleanButton.Text = "Clear";
            CleanButton.UseVisualStyleBackColor = true;
            CleanButton.Click += CleanButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.GrayText;
            label9.Location = new Point(699, 551);
            label9.Name = "label9";
            label9.Size = new Size(101, 16);
            label9.TabIndex = 32;
            label9.Text = "Ident Archiver 1.0";
            // 
            // TrimCheckBox
            // 
            TrimCheckBox.AutoSize = true;
            TrimCheckBox.Checked = true;
            TrimCheckBox.CheckState = CheckState.Checked;
            TrimCheckBox.Location = new Point(14, 99);
            TrimCheckBox.Name = "TrimCheckBox";
            TrimCheckBox.Size = new Size(49, 20);
            TrimCheckBox.TabIndex = 33;
            TrimCheckBox.Text = "Trim";
            TrimCheckBox.UseVisualStyleBackColor = true;
            TrimCheckBox.CheckedChanged += TrimCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(TrimCheckBox);
            Controls.Add(CleanButton);
            Controls.Add(statusStrip1);
            Controls.Add(label8);
            Controls.Add(CmdOutTextBox);
            Controls.Add(CmdTextBox);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(STTextBox);
            Controls.Add(OrganizationTextBox);
            Controls.Add(LangTextBox);
            Controls.Add(ShortNameTextBox);
            Controls.Add(STextBox);
            Controls.Add(SourceTextBox);
            Controls.Add(SourceTextTextBox);
            Controls.Add(OrgTextBox);
            Controls.Add(LanguageTextBox);
            Controls.Add(DateTextBox);
            Controls.Add(WatermarkTextBox);
            Controls.Add(label6);
            Controls.Add(LongNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ToTextBox);
            Controls.Add(label3);
            Controls.Add(FromTextBox);
            Controls.Add(label2);
            Controls.Add(UrlTextBox);
            Controls.Add(label1);
            Controls.Add(label9);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Ident Archiver for Ident Archive";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UrlTextBox;
        private Label label2;
        private TextBox FromTextBox;
        private Label label3;
        private TextBox ToTextBox;
        private Label label4;
        private TextBox LongNameTextBox;
        private Label label5;
        private TextBox WatermarkTextBox;
        private Label label6;
        private TextBox DateTextBox;
        private Label LanguageTextBox;
        private Label OrgTextBox;
        private Label SourceTextTextBox;
        private TextBox STextBox;
        private Label SourceTextBox;
        private TextBox ShortNameTextBox;
        private TextBox LangTextBox;
        private TextBox OrganizationTextBox;
        private TextBox STTextBox;
        private Label label7;
        private Button button1;
        private TextBox CmdTextBox;
        private TextBox CmdOutTextBox;
        private Label label8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button CleanButton;
        private Label label9;
        private CheckBox checkBox1;
        private CheckBox TrimCheckBox;
    }
}
