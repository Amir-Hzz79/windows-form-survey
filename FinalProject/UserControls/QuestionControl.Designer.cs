namespace FinalProject.UserControls
{
	partial class QuestionControl
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
			radioButton4 = new RadioButton();
			radioButton3 = new RadioButton();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			answer4Label = new Label();
			answer2Label = new Label();
			answer3Label = new Label();
			answer1Label = new Label();
			questionLabel = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			answer1PercentLabel = new Label();
			answer2PercentLabel = new Label();
			answer3PercentLabel = new Label();
			answer4PercentLabel = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// radioButton4
			// 
			radioButton4.AutoSize = true;
			radioButton4.Location = new Point(511, 144);
			radioButton4.Name = "radioButton4";
			radioButton4.Size = new Size(14, 13);
			radioButton4.TabIndex = 7;
			radioButton4.TabStop = true;
			radioButton4.UseVisualStyleBackColor = true;
			radioButton4.CheckedChanged += radioButton4_CheckedChanged;
			// 
			// radioButton3
			// 
			radioButton3.AutoSize = true;
			radioButton3.Location = new Point(511, 97);
			radioButton3.Name = "radioButton3";
			radioButton3.Size = new Size(14, 13);
			radioButton3.TabIndex = 8;
			radioButton3.TabStop = true;
			radioButton3.UseVisualStyleBackColor = true;
			radioButton3.CheckedChanged += radioButton3_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(511, 50);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(14, 13);
			radioButton2.TabIndex = 9;
			radioButton2.TabStop = true;
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(511, 3);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(14, 13);
			radioButton1.TabIndex = 10;
			radioButton1.TabStop = true;
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// answer4Label
			// 
			answer4Label.AutoSize = true;
			answer4Label.Location = new Point(455, 141);
			answer4Label.Name = "answer4Label";
			answer4Label.Size = new Size(40, 15);
			answer4Label.TabIndex = 2;
			answer4Label.Text = "پاسخ ۴";
			// 
			// answer2Label
			// 
			answer2Label.AutoSize = true;
			answer2Label.Location = new Point(455, 47);
			answer2Label.Name = "answer2Label";
			answer2Label.Size = new Size(40, 15);
			answer2Label.TabIndex = 3;
			answer2Label.Text = "پاسخ ۲";
			// 
			// answer3Label
			// 
			answer3Label.AutoSize = true;
			answer3Label.Location = new Point(454, 94);
			answer3Label.Name = "answer3Label";
			answer3Label.Size = new Size(41, 15);
			answer3Label.TabIndex = 4;
			answer3Label.Text = "پاسخ ۳";
			// 
			// answer1Label
			// 
			answer1Label.AutoSize = true;
			answer1Label.Location = new Point(458, 0);
			answer1Label.Name = "answer1Label";
			answer1Label.Size = new Size(37, 15);
			answer1Label.TabIndex = 5;
			answer1Label.Text = "پاسخ ۱";
			// 
			// questionLabel
			// 
			questionLabel.AutoSize = true;
			questionLabel.Location = new Point(486, 0);
			questionLabel.Name = "questionLabel";
			questionLabel.Size = new Size(61, 15);
			questionLabel.TabIndex = 6;
			questionLabel.Text = "متن پرسش";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(questionLabel, 0, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.77778F));
			tableLayoutPanel1.Size = new Size(550, 250);
			tableLayoutPanel1.TabIndex = 11;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 4;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.94117641F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.51470566F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.955883F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.5882339F));
			tableLayoutPanel2.Controls.Add(radioButton4, 1, 3);
			tableLayoutPanel2.Controls.Add(radioButton1, 1, 0);
			tableLayoutPanel2.Controls.Add(radioButton3, 1, 2);
			tableLayoutPanel2.Controls.Add(radioButton2, 1, 1);
			tableLayoutPanel2.Controls.Add(answer1Label, 2, 0);
			tableLayoutPanel2.Controls.Add(answer2Label, 2, 1);
			tableLayoutPanel2.Controls.Add(answer3Label, 2, 2);
			tableLayoutPanel2.Controls.Add(answer4Label, 2, 3);
			tableLayoutPanel2.Controls.Add(answer1PercentLabel, 3, 0);
			tableLayoutPanel2.Controls.Add(answer2PercentLabel, 3, 1);
			tableLayoutPanel2.Controls.Add(answer3PercentLabel, 3, 2);
			tableLayoutPanel2.Controls.Add(answer4PercentLabel, 3, 3);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 58);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RightToLeft = RightToLeft.Yes;
			tableLayoutPanel2.RowCount = 4;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanel2.Size = new Size(544, 189);
			tableLayoutPanel2.TabIndex = 7;
			// 
			// answer1PercentLabel
			// 
			answer1PercentLabel.AutoSize = true;
			answer1PercentLabel.Location = new Point(207, 0);
			answer1PercentLabel.Name = "answer1PercentLabel";
			answer1PercentLabel.Size = new Size(38, 15);
			answer1PercentLabel.TabIndex = 11;
			answer1PercentLabel.Text = "label1";
			// 
			// answer2PercentLabel
			// 
			answer2PercentLabel.AutoSize = true;
			answer2PercentLabel.Location = new Point(207, 47);
			answer2PercentLabel.Name = "answer2PercentLabel";
			answer2PercentLabel.Size = new Size(38, 15);
			answer2PercentLabel.TabIndex = 11;
			answer2PercentLabel.Text = "label1";
			// 
			// answer3PercentLabel
			// 
			answer3PercentLabel.AutoSize = true;
			answer3PercentLabel.Location = new Point(207, 94);
			answer3PercentLabel.Name = "answer3PercentLabel";
			answer3PercentLabel.Size = new Size(38, 15);
			answer3PercentLabel.TabIndex = 11;
			answer3PercentLabel.Text = "label1";
			// 
			// answer4PercentLabel
			// 
			answer4PercentLabel.AutoSize = true;
			answer4PercentLabel.Location = new Point(207, 141);
			answer4PercentLabel.Name = "answer4PercentLabel";
			answer4PercentLabel.Size = new Size(38, 15);
			answer4PercentLabel.TabIndex = 11;
			answer4PercentLabel.Text = "label1";
			// 
			// QuestionControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel1);
			Name = "QuestionControl";
			Size = new Size(550, 250);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private RadioButton radioButton4;
		private RadioButton radioButton3;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private Label answer4Label;
		private Label answer2Label;
		private Label answer3Label;
		private Label answer1Label;
		private Label questionLabel;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label answer1PercentLabel;
		private Label answer2PercentLabel;
		private Label answer3PercentLabel;
		private Label answer4PercentLabel;
	}
}
