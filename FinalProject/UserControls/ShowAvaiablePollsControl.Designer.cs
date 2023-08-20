namespace FinalProject.UserControls
{
	partial class ShowAvaiablePollsControl
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
			pollDataGridView = new DataGridView();
			((System.ComponentModel.ISupportInitialize)pollDataGridView).BeginInit();
			SuspendLayout();
			// 
			// pollDataGridView
			// 
			pollDataGridView.AllowUserToAddRows = false;
			pollDataGridView.AllowUserToDeleteRows = false;
			pollDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			pollDataGridView.Dock = DockStyle.Fill;
			pollDataGridView.Location = new Point(0, 0);
			pollDataGridView.Name = "pollDataGridView";
			pollDataGridView.ReadOnly = true;
			pollDataGridView.RowTemplate.Height = 25;
			pollDataGridView.Size = new Size(853, 489);
			pollDataGridView.TabIndex = 0;
			pollDataGridView.CellDoubleClick += pollDataGridView_CellDoubleClick;
			// 
			// ShowPollsControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pollDataGridView);
			Margin = new Padding(3, 2, 3, 2);
			Name = "ShowPollsControl";
			Size = new Size(853, 489);
			((System.ComponentModel.ISupportInitialize)pollDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView pollDataGridView;
	}
}
