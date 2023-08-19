namespace FinalProject
{
    partial class LoginForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            loginButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Dock = DockStyle.Fill;
            usernameTextBox.Location = new Point(3, 3);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(239, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Location = new Point(3, 49);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(239, 27);
            passwordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(248, 0);
            label1.Name = "label1";
            label1.Size = new Size(77, 46);
            label1.TabIndex = 2;
            label1.Text = "نام کاربری";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(248, 46);
            label2.Name = "label2";
            label2.Size = new Size(77, 46);
            label2.TabIndex = 2;
            label2.Text = "رمز عبور";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.69512F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.30488F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(usernameTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(loginButton, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3233261F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3233261F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3533478F));
            tableLayoutPanel1.Size = new Size(328, 140);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Fill;
            loginButton.Location = new Point(3, 95);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(239, 42);
            loginButton.TabIndex = 3;
            loginButton.Text = "ورود";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 164);
            Controls.Add(tableLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button loginButton;
    }
}