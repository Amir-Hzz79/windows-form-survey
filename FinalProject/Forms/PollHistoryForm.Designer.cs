namespace FinalProject.Forms
{
	partial class PollHistoryForm
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
			containerPanel = new FlowLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			nameLable = new Label();
			descriptionLable = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// containerPanel
			// 
			containerPanel.AutoScroll = true;
			containerPanel.Dock = DockStyle.Fill;
			containerPanel.FlowDirection = FlowDirection.RightToLeft;
			containerPanel.Location = new Point(3, 70);
			containerPanel.Name = "containerPanel";
			containerPanel.RightToLeft = RightToLeft.No;
			containerPanel.Size = new Size(794, 377);
			containerPanel.TabIndex = 2;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
			tableLayoutPanel1.Controls.Add(containerPanel, 0, 1);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.8888893F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.1111145F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(nameLable, 0, 0);
			tableLayoutPanel2.Controls.Add(descriptionLable, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RightToLeft = RightToLeft.Yes;
			tableLayoutPanel2.RowCount = 2;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(794, 61);
			tableLayoutPanel2.TabIndex = 1;
			// 
			// nameLable
			// 
			nameLable.AutoSize = true;
			nameLable.Location = new Point(753, 0);
			nameLable.Name = "nameLable";
			nameLable.Size = new Size(38, 15);
			nameLable.TabIndex = 0;
			nameLable.Text = "label1";
			// 
			// descriptionLable
			// 
			descriptionLable.AutoSize = true;
			descriptionLable.Location = new Point(753, 30);
			descriptionLable.Name = "descriptionLable";
			descriptionLable.Size = new Size(38, 15);
			descriptionLable.TabIndex = 0;
			descriptionLable.Text = "label1";
			// 
			// PollHistoryForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "PollHistoryForm";
			Text = "PollHistoryForm";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private FlowLayoutPanel containerPanel;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label nameLable;
		private Label descriptionLable;
	}
}