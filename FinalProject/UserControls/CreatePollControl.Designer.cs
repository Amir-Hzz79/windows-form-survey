namespace FinalProject.UserControls
{
    partial class CreatePollControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer3 = new SplitContainer();
            questionDataGrid = new DataGridView();
            splitContainer4 = new SplitContainer();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            saveButton = new Button();
            selectedQuestionsDataGrid = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            pollNameTextBox = new TextBox();
            label6 = new Label();
            descriptionTextBox = new TextBox();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) questionDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize) splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) selectedQuestionsDataGrid).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(splitContainer3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2807016F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.7193F));
            tableLayoutPanel1.Size = new Size(1011, 621);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 79);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(questionDataGrid);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer4);
            splitContainer3.Size = new Size(1005, 539);
            splitContainer3.SplitterDistance = 414;
            splitContainer3.TabIndex = 1;
            // 
            // questionDataGrid
            // 
            questionDataGrid.AllowUserToAddRows = false;
            questionDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            questionDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            questionDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionDataGrid.Dock = DockStyle.Fill;
            questionDataGrid.Location = new Point(0, 0);
            questionDataGrid.Name = "questionDataGrid";
            questionDataGrid.ReadOnly = true;
            questionDataGrid.RightToLeft = RightToLeft.No;
            questionDataGrid.RowHeadersWidth = 51;
            questionDataGrid.RowTemplate.Height = 29;
            questionDataGrid.Size = new Size(414, 539);
            questionDataGrid.TabIndex = 1;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tableLayoutPanel3);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(selectedQuestionsDataGrid);
            splitContainer4.Size = new Size(587, 539);
            splitContainer4.SplitterDistance = 156;
            splitContainer4.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button2, 0, 1);
            tableLayoutPanel3.Controls.Add(saveButton, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(156, 539);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(150, 128);
            button1.TabIndex = 0;
            button1.Text = "اضافه";
            button1.UseVisualStyleBackColor = true;
            button1.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 137);
            button2.Name = "button2";
            button2.Size = new Size(150, 128);
            button2.TabIndex = 0;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += removebutton_Click;
            // 
            // saveButton
            // 
            saveButton.Dock = DockStyle.Fill;
            saveButton.Location = new Point(3, 405);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 131);
            saveButton.TabIndex = 1;
            saveButton.Text = "ثبت";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // selectedQuestionsDataGrid
            // 
            selectedQuestionsDataGrid.AllowUserToAddRows = false;
            selectedQuestionsDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            selectedQuestionsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            selectedQuestionsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectedQuestionsDataGrid.Dock = DockStyle.Fill;
            selectedQuestionsDataGrid.Location = new Point(0, 0);
            selectedQuestionsDataGrid.Name = "selectedQuestionsDataGrid";
            selectedQuestionsDataGrid.ReadOnly = true;
            selectedQuestionsDataGrid.RightToLeft = RightToLeft.No;
            selectedQuestionsDataGrid.RowHeadersWidth = 51;
            selectedQuestionsDataGrid.RowTemplate.Height = 29;
            selectedQuestionsDataGrid.Size = new Size(427, 539);
            selectedQuestionsDataGrid.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(pollNameTextBox, 0, 0);
            tableLayoutPanel4.Controls.Add(label6, 1, 0);
            tableLayoutPanel4.Controls.Add(descriptionTextBox, 0, 1);
            tableLayoutPanel4.Controls.Add(label7, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel4.Size = new Size(1005, 70);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // pollNameTextBox
            // 
            pollNameTextBox.Dock = DockStyle.Fill;
            pollNameTextBox.Location = new Point(3, 3);
            pollNameTextBox.Name = "pollNameTextBox";
            pollNameTextBox.Size = new Size(798, 27);
            pollNameTextBox.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(807, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 1;
            label6.Text = "نام نظرسنجی";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Fill;
            descriptionTextBox.Location = new Point(3, 40);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(798, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(807, 37);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 3;
            label7.Text = "توضیحات";
            // 
            // CreatePollControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CreatePollControl";
            Size = new Size(1011, 621);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) questionDataGrid).EndInit();
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) selectedQuestionsDataGrid).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer3;
        private DataGridView questionDataGrid;
        private SplitContainer splitContainer4;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button saveButton;
        private DataGridView selectedQuestionsDataGrid;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox pollNameTextBox;
        private Label label6;
        private TextBox descriptionTextBox;
        private Label label7;
    }
}
