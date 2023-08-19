namespace FinalProject
{
    partial class AdminForm
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
            splitContainer1 = new SplitContainer();
            questionsDataGrid = new DataGridView();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            addButton = new Button();
            removeButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ContainerPanel = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            createQuestionButton = new Button();
            createPollButton = new Button();
            manageUsersButton = new Button();
            ((System.ComponentModel.ISupportInitialize) splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) questionsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize) splitContainer2).BeginInit();
            splitContainer2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(questionsDataGrid);
            splitContainer1.Size = new Size(150, 100);
            splitContainer1.TabIndex = 0;
            // 
            // questionsDataGrid
            // 
            questionsDataGrid.AllowUserToAddRows = false;
            questionsDataGrid.AllowUserToDeleteRows = false;
            questionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGrid.Dock = DockStyle.Fill;
            questionsDataGrid.Location = new Point(0, 0);
            questionsDataGrid.Name = "questionsDataGrid";
            questionsDataGrid.ReadOnly = true;
            questionsDataGrid.RowHeadersWidth = 51;
            questionsDataGrid.RowTemplate.Height = 29;
            questionsDataGrid.Size = new Size(50, 100);
            questionsDataGrid.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Size = new Size(150, 100);
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(addButton, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Fill;
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(194, 14);
            addButton.TabIndex = 0;
            addButton.Text = "اضافه";
            addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.Fill;
            removeButton.Location = new Point(3, 108);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(194, 99);
            removeButton.TabIndex = 0;
            removeButton.Text = "حذف";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ContainerPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.2892561F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 84.71075F));
            tableLayoutPanel1.Size = new Size(982, 703);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ContainerPanel
            // 
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(3, 110);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(976, 590);
            ContainerPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(createQuestionButton, 5, 0);
            tableLayoutPanel3.Controls.Add(createPollButton, 4, 0);
            tableLayoutPanel3.Controls.Add(manageUsersButton, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(976, 101);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // createQuestionButton
            // 
            createQuestionButton.Dock = DockStyle.Fill;
            createQuestionButton.Location = new Point(813, 3);
            createQuestionButton.Name = "createQuestionButton";
            createQuestionButton.Size = new Size(160, 95);
            createQuestionButton.TabIndex = 0;
            createQuestionButton.Text = "تعریف سوال";
            createQuestionButton.UseVisualStyleBackColor = true;
            createQuestionButton.Click += createQuestionButton_Click;
            // 
            // createPollButton
            // 
            createPollButton.Dock = DockStyle.Fill;
            createPollButton.Location = new Point(651, 3);
            createPollButton.Name = "createPollButton";
            createPollButton.Size = new Size(156, 95);
            createPollButton.TabIndex = 1;
            createPollButton.Text = "تعریف نظرسنجی";
            createPollButton.UseVisualStyleBackColor = true;
            createPollButton.Click += createPollButton_Click;
            // 
            // manageUsersButton
            // 
            manageUsersButton.Dock = DockStyle.Fill;
            manageUsersButton.Location = new Point(489, 3);
            manageUsersButton.Name = "manageUsersButton";
            manageUsersButton.Size = new Size(156, 95);
            manageUsersButton.TabIndex = 2;
            manageUsersButton.Text = "مدیریت کاربران";
            manageUsersButton.UseVisualStyleBackColor = true;
            manageUsersButton.Click += manageUsersButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 703);
            Controls.Add(tableLayoutPanel1);
            Name = "AdminForm";
            Text = "پنل ادمین";
            FormClosed += AdminForm_FormClosed;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) questionsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize) splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button createPollButton;
        private SplitContainer splitContainer1;
        private DataGridView questionsDataGrid;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addButton;
        private Button removeButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel ContainerPanel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button createQuestionButton;
        private Button button2;
        private Button manageUsersButton;
    }
}