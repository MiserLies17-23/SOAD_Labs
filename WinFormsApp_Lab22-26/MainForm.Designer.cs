namespace WinFormsApp_Lab22_26
{
    partial class MainForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            SortDataGridView = new DataGridView();
            CheckColumn = new DataGridViewCheckBoxColumn();
            SortTypeColumn = new DataGridViewTextBoxColumn();
            ComparisonsColumn = new DataGridViewTextBoxColumn();
            AssignmentsColumn = new DataGridViewTextBoxColumn();
            TimeColumn = new DataGridViewTextBoxColumn();
            IsSortedColumn = new DataGridViewTextBoxColumn();
            SortButton = new Button();
            SizeLabel = new Label();
            SizeNumericUpDown = new NumericUpDown();
            PercentNumericUpDown = new NumericUpDown();
            PercentLabel = new Label();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SortDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PercentNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // SortDataGridView
            // 
            SortDataGridView.AllowUserToAddRows = false;
            SortDataGridView.AllowUserToDeleteRows = false;
            SortDataGridView.AllowUserToResizeColumns = false;
            SortDataGridView.AllowUserToResizeRows = false;
            SortDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SortDataGridView.Columns.AddRange(new DataGridViewColumn[] { CheckColumn, SortTypeColumn, ComparisonsColumn, AssignmentsColumn, TimeColumn, IsSortedColumn });
            SortDataGridView.Location = new Point(12, 12);
            SortDataGridView.Name = "SortDataGridView";
            SortDataGridView.RowHeadersVisible = false;
            SortDataGridView.RowHeadersWidth = 51;
            SortDataGridView.Size = new Size(678, 175);
            SortDataGridView.TabIndex = 0;
            // 
            // CheckColumn
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.NullValue = false;
            CheckColumn.DefaultCellStyle = dataGridViewCellStyle1;
            CheckColumn.HeaderText = "";
            CheckColumn.MinimumWidth = 6;
            CheckColumn.Name = "CheckColumn";
            CheckColumn.Width = 50;
            // 
            // SortTypeColumn
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(128, 255, 255);
            SortTypeColumn.DefaultCellStyle = dataGridViewCellStyle2;
            SortTypeColumn.HeaderText = "Сортировка";
            SortTypeColumn.MinimumWidth = 6;
            SortTypeColumn.Name = "SortTypeColumn";
            SortTypeColumn.Width = 125;
            // 
            // ComparisonsColumn
            // 
            ComparisonsColumn.HeaderText = "Сравнения";
            ComparisonsColumn.MinimumWidth = 6;
            ComparisonsColumn.Name = "ComparisonsColumn";
            ComparisonsColumn.Width = 125;
            // 
            // AssignmentsColumn
            // 
            AssignmentsColumn.HeaderText = "Присвоения";
            AssignmentsColumn.MinimumWidth = 6;
            AssignmentsColumn.Name = "AssignmentsColumn";
            AssignmentsColumn.Width = 125;
            // 
            // TimeColumn
            // 
            TimeColumn.HeaderText = "Время";
            TimeColumn.MinimumWidth = 6;
            TimeColumn.Name = "TimeColumn";
            TimeColumn.Width = 125;
            // 
            // IsSortedColumn
            // 
            IsSortedColumn.HeaderText = "Отсортировано";
            IsSortedColumn.MinimumWidth = 6;
            IsSortedColumn.Name = "IsSortedColumn";
            IsSortedColumn.Width = 125;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(12, 215);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(110, 29);
            SortButton.TabIndex = 1;
            SortButton.Text = "Сортировать";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // SizeLabel
            // 
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SizeLabel.Location = new Point(156, 219);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(123, 20);
            SizeLabel.TabIndex = 2;
            SizeLabel.Text = "Размер массива";
            // 
            // SizeNumericUpDown
            // 
            SizeNumericUpDown.Location = new Point(285, 215);
            SizeNumericUpDown.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            SizeNumericUpDown.Name = "SizeNumericUpDown";
            SizeNumericUpDown.Size = new Size(119, 27);
            SizeNumericUpDown.TabIndex = 3;
            SizeNumericUpDown.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            // 
            // PercentNumericUpDown
            // 
            PercentNumericUpDown.Location = new Point(498, 217);
            PercentNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PercentNumericUpDown.Name = "PercentNumericUpDown";
            PercentNumericUpDown.Size = new Size(55, 27);
            PercentNumericUpDown.TabIndex = 4;
            PercentNumericUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // PercentLabel
            // 
            PercentLabel.AutoSize = true;
            PercentLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentLabel.Location = new Point(442, 219);
            PercentLabel.Name = "PercentLabel";
            PercentLabel.Size = new Size(48, 20);
            PercentLabel.TabIndex = 5;
            PercentLabel.Text = "% ОП";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(607, 242);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 6;
            ExitButton.Text = "Выйти";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(701, 271);
            Controls.Add(ExitButton);
            Controls.Add(PercentLabel);
            Controls.Add(PercentNumericUpDown);
            Controls.Add(SizeNumericUpDown);
            Controls.Add(SizeLabel);
            Controls.Add(SortButton);
            Controls.Add(SortDataGridView);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "24ВП1_Толстоухов_ЛР22-26";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)SortDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SizeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PercentNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView SortDataGridView;
        private DataGridViewCheckBoxColumn CheckColumn;
        private DataGridViewTextBoxColumn SortTypeColumn;
        private DataGridViewTextBoxColumn ComparisonsColumn;
        private DataGridViewTextBoxColumn AssignmentsColumn;
        private DataGridViewTextBoxColumn TimeColumn;
        private DataGridViewTextBoxColumn IsSortedColumn;
        private Button SortButton;
        private Label SizeLabel;
        private NumericUpDown SizeNumericUpDown;
        private NumericUpDown PercentNumericUpDown;
        private Label PercentLabel;
        private Button ExitButton;
    }
}
