namespace Ident_Archiver
{
    partial class NewOrgForm
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
            FullNameTextBox = new TextBox();
            SmallNameTextBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            SubOrgsTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(156, 59);
            FullNameTextBox.Margin = new Padding(4);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.PlaceholderText = "German";
            FullNameTextBox.Size = new Size(586, 27);
            FullNameTextBox.TabIndex = 2;
            // 
            // SmallNameTextBox
            // 
            SmallNameTextBox.Location = new Point(156, 23);
            SmallNameTextBox.Margin = new Padding(4);
            SmallNameTextBox.Name = "SmallNameTextBox";
            SmallNameTextBox.PlaceholderText = "de";
            SmallNameTextBox.Size = new Size(586, 27);
            SmallNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(643, 129);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Full name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Small name:";
            // 
            // button2
            // 
            button2.Location = new Point(539, 129);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(96, 29);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SubOrgsTextBox
            // 
            SubOrgsTextBox.Location = new Point(156, 94);
            SubOrgsTextBox.Margin = new Padding(4);
            SubOrgsTextBox.Name = "SubOrgsTextBox";
            SubOrgsTextBox.PlaceholderText = "SRF,RTS";
            SubOrgsTextBox.Size = new Size(586, 27);
            SubOrgsTextBox.TabIndex = 7;
            //
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Suborgs:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 129);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(297, 20);
            label4.TabIndex = 9;
            label4.Text = "Suborgs is optional (Delimited by comma)";
            // 
            // NewOrgForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 169);
            Controls.Add(label4);
            Controls.Add(SubOrgsTextBox);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(FullNameTextBox);
            Controls.Add(SmallNameTextBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewOrgForm";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Add new organization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FullNameTextBox;
        private TextBox SmallNameTextBox;
        private Button button1;
        private Label label2;
        private Label label1;
        private Button button2;
        private TextBox SubOrgsTextBox;
        private Label label3;
        private Label label4;
    }
}