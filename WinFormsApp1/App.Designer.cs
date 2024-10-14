namespace WinFormsApp1
{
    partial class App
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
            panel2 = new Panel();
            panel4 = new Panel();
            closeButton = new Button();
            lgnButton = new Button();
            panel3 = new Panel();
            pwdBox = new TextBox();
            pwdLabel = new Label();
            panel1 = new Panel();
            unameBox = new TextBox();
            unameLabel = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 161);
            panel2.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(closeButton);
            panel4.Controls.Add(lgnButton);
            panel4.Location = new Point(108, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(162, 31);
            panel4.TabIndex = 8;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(84, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // lgnButton
            // 
            lgnButton.Location = new Point(3, 5);
            lgnButton.Name = "lgnButton";
            lgnButton.Size = new Size(75, 23);
            lgnButton.TabIndex = 0;
            lgnButton.Text = "Login";
            lgnButton.UseVisualStyleBackColor = true;
            lgnButton.Click += this.lgnButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pwdBox);
            panel3.Controls.Add(pwdLabel);
            panel3.Location = new Point(64, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 43);
            panel3.TabIndex = 7;
            // 
            // pwdBox
            // 
            pwdBox.Location = new Point(81, 10);
            pwdBox.Name = "pwdBox";
            pwdBox.PasswordChar = '*';
            pwdBox.Size = new Size(165, 23);
            pwdBox.TabIndex = 3;
            // 
            // pwdLabel
            // 
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new Point(3, 13);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new Size(57, 15);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "Password";
            pwdLabel.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(unameBox);
            panel1.Controls.Add(unameLabel);
            panel1.Location = new Point(64, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 43);
            panel1.TabIndex = 5;
            // 
            // unameBox
            // 
            unameBox.Location = new Point(81, 10);
            unameBox.Name = "unameBox";
            unameBox.Size = new Size(165, 23);
            unameBox.TabIndex = 3;
            // 
            // unameLabel
            // 
            unameLabel.AutoSize = true;
            unameLabel.Location = new Point(3, 13);
            unameLabel.Name = "unameLabel";
            unameLabel.Size = new Size(60, 15);
            unameLabel.TabIndex = 2;
            unameLabel.Text = "Username";
            // 
            // App
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(384, 161);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "App";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private TextBox unameBox;
        private Label unameLabel;
        private Button lgnButton;
        private Button closeButton;
        private Panel panel3;
        private TextBox pwdBox;
        private Label pwdLabel;
        private Panel panel4;
    }
}
