namespace FinalProject.UserControls
{
    partial class CreateQuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AnswerSection = new TableLayoutPanel();
            Answer4TextBox = new TextBox();
            Answer3TextBox = new TextBox();
            Answer2TextBox = new TextBox();
            Answer1TextBox = new TextBox();
            QuestionTextTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CreateQuestionButton = new Button();
            AnswerSection.SuspendLayout();
            SuspendLayout();
            // 
            // AnswerSection
            // 
            AnswerSection.ColumnCount = 2;
            AnswerSection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AnswerSection.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 89F));
            AnswerSection.Controls.Add(Answer4TextBox, 0, 4);
            AnswerSection.Controls.Add(Answer3TextBox, 0, 3);
            AnswerSection.Controls.Add(Answer2TextBox, 0, 2);
            AnswerSection.Controls.Add(Answer1TextBox, 0, 1);
            AnswerSection.Controls.Add(QuestionTextTextBox, 0, 0);
            AnswerSection.Controls.Add(label1, 1, 0);
            AnswerSection.Controls.Add(label2, 1, 1);
            AnswerSection.Controls.Add(label3, 1, 2);
            AnswerSection.Controls.Add(label4, 1, 3);
            AnswerSection.Controls.Add(label5, 1, 4);
            AnswerSection.Controls.Add(CreateQuestionButton, 0, 5);
            AnswerSection.Dock = DockStyle.Fill;
            AnswerSection.Location = new Point(0, 0);
            AnswerSection.Name = "AnswerSection";
            AnswerSection.RowCount = 6;
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07213F));
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07213F));
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07213F));
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07213F));
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 17.07213F));
            AnswerSection.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6393518F));
            AnswerSection.Size = new Size(849, 464);
            AnswerSection.TabIndex = 7;
            // 
            // Answer4TextBox
            // 
            Answer4TextBox.Dock = DockStyle.Fill;
            Answer4TextBox.Location = new Point(3, 319);
            Answer4TextBox.Multiline = true;
            Answer4TextBox.Name = "Answer4TextBox";
            Answer4TextBox.Size = new Size(754, 73);
            Answer4TextBox.TabIndex = 7;
            // 
            // Answer3TextBox
            // 
            Answer3TextBox.Dock = DockStyle.Fill;
            Answer3TextBox.Location = new Point(3, 240);
            Answer3TextBox.Multiline = true;
            Answer3TextBox.Name = "Answer3TextBox";
            Answer3TextBox.Size = new Size(754, 73);
            Answer3TextBox.TabIndex = 5;
            // 
            // Answer2TextBox
            // 
            Answer2TextBox.Dock = DockStyle.Fill;
            Answer2TextBox.Location = new Point(3, 161);
            Answer2TextBox.Multiline = true;
            Answer2TextBox.Name = "Answer2TextBox";
            Answer2TextBox.Size = new Size(754, 73);
            Answer2TextBox.TabIndex = 3;
            // 
            // Answer1TextBox
            // 
            Answer1TextBox.Dock = DockStyle.Fill;
            Answer1TextBox.Location = new Point(3, 82);
            Answer1TextBox.Multiline = true;
            Answer1TextBox.Name = "Answer1TextBox";
            Answer1TextBox.Size = new Size(754, 73);
            Answer1TextBox.TabIndex = 2;
            // 
            // QuestionTextTextBox
            // 
            QuestionTextTextBox.Dock = DockStyle.Fill;
            QuestionTextTextBox.Location = new Point(3, 3);
            QuestionTextTextBox.Multiline = true;
            QuestionTextTextBox.Name = "QuestionTextTextBox";
            QuestionTextTextBox.Size = new Size(754, 73);
            QuestionTextTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(763, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "متن سوال";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 79);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "متن پاسخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(763, 158);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 1;
            label3.Text = "متن پاسخ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(763, 237);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "متن پاسخ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(763, 316);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 1;
            label5.Text = "متن پاسخ";
            // 
            // CreateQuestionButton
            // 
            CreateQuestionButton.BackColor = Color.LimeGreen;
            CreateQuestionButton.Location = new Point(3, 398);
            CreateQuestionButton.Name = "CreateQuestionButton";
            CreateQuestionButton.Size = new Size(153, 38);
            CreateQuestionButton.TabIndex = 8;
            CreateQuestionButton.Text = "ثبت";
            CreateQuestionButton.UseVisualStyleBackColor = false;
            CreateQuestionButton.Click += CreateQuestionButton_Click;
            // 
            // CreateQuestionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AnswerSection);
            Name = "CreateQuestionControl";
            Size = new Size(849, 464);
            AnswerSection.ResumeLayout(false);
            AnswerSection.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AnswerSection;
        private TextBox Answer4TextBox;
        private TextBox Answer3TextBox;
        private TextBox Answer2TextBox;
        private TextBox Answer1TextBox;
        private TextBox QuestionTextTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CreateQuestionButton;
    }
}
