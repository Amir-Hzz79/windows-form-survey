namespace FinalProject
{
    partial class UserForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            avaiablePolls = new Button();
            pollHistory = new Button();
            containerPanel = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6864691F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.31353F));
            tableLayoutPanel1.Size = new Size(934, 673);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(avaiablePolls, 5, 0);
            tableLayoutPanel2.Controls.Add(pollHistory, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(928, 92);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // avaiablePolls
            // 
            avaiablePolls.Dock = DockStyle.Fill;
            avaiablePolls.Location = new Point(773, 3);
            avaiablePolls.Name = "avaiablePolls";
            avaiablePolls.Size = new Size(152, 86);
            avaiablePolls.TabIndex = 0;
            avaiablePolls.Text = "نظرسنجی های در دسترس";
            avaiablePolls.UseVisualStyleBackColor = true;
            avaiablePolls.Click += avaiablePolls_Click;
            // 
            // pollHistory
            // 
            pollHistory.Dock = DockStyle.Fill;
            pollHistory.Location = new Point(619, 3);
            pollHistory.Name = "pollHistory";
            pollHistory.Size = new Size(148, 86);
            pollHistory.TabIndex = 0;
            pollHistory.Text = "تاریخچه نظرسنجی ها\r\n";
            pollHistory.UseVisualStyleBackColor = true;
            pollHistory.Click += pollHistory_Click;
            // 
            // containerPanel
            // 
            containerPanel.Dock = DockStyle.Fill;
            containerPanel.Location = new Point(3, 101);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new Size(928, 569);
            containerPanel.TabIndex = 1;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 673);
            Controls.Add(tableLayoutPanel1);
            Name = "UserForm";
            Text = "پنل کاربر";
            FormClosed += UserForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button avaiablePolls;
        private Button pollHistory;
        private Panel containerPanel;
    }
}