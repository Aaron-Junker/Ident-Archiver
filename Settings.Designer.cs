namespace Ident_Archiver
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ytdlpLocationTextBox = new TextBox();
            RepoTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(105, 16);
            label1.TabIndex = 0;
            label1.Text = "yt-dlp executable:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(113, 16);
            label2.TabIndex = 1;
            label2.Text = "Repository location:";
            // 
            // button1
            // 
            button1.Location = new Point(505, 65);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ytdlpLocationTextBox
            // 
            ytdlpLocationTextBox.Location = new Point(123, 7);
            ytdlpLocationTextBox.Name = "ytdlpLocationTextBox";
            ytdlpLocationTextBox.Size = new Size(457, 23);
            ytdlpLocationTextBox.TabIndex = 3;
            // 
            // RepoTextBox
            // 
            RepoTextBox.Location = new Point(123, 36);
            RepoTextBox.Name = "RepoTextBox";
            RepoTextBox.Size = new Size(457, 23);
            RepoTextBox.TabIndex = 4;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 91);
            Controls.Add(RepoTextBox);
            Controls.Add(ytdlpLocationTextBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox ytdlpLocationTextBox;
        private TextBox RepoTextBox;
    }
}