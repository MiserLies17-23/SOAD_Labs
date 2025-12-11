namespace WindowsFormsApp_Lab8_11
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.DivisionMethodLabel = new System.Windows.Forms.Label();
            this.MidsquareMethodLabel = new System.Windows.Forms.Label();
            this.FoldingMethodLabel = new System.Windows.Forms.Label();
            this.MultiplicationMethodLabel = new System.Windows.Forms.Label();
            this.DivisionMethodTextBox = new System.Windows.Forms.TextBox();
            this.MidsquaredMethodTextBox = new System.Windows.Forms.TextBox();
            this.FoldingMethodTextBox = new System.Windows.Forms.TextBox();
            this.MultiplicationMethodTextBox = new System.Windows.Forms.TextBox();
            this.HashButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.HashComparisonPanel = new System.Windows.Forms.Panel();
            this.quantityNumeric = new System.Windows.Forms.NumericUpDown();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.ComparisonLabel = new System.Windows.Forms.Label();
            this.SolutionsComparisonPanel = new System.Windows.Forms.Panel();
            this.CompareButton = new System.Windows.Forms.Button();
            this.ChainMethodPanel = new System.Windows.Forms.Panel();
            this.ChainFoundLabel = new System.Windows.Forms.Label();
            this.ChainFoundTextBox = new System.Windows.Forms.TextBox();
            this.ChainComparisonLabel = new System.Windows.Forms.Label();
            this.ChainComparisonTextBox = new System.Windows.Forms.TextBox();
            this.ChainTimeLabel = new System.Windows.Forms.Label();
            this.СhainTimeTextBox = new System.Windows.Forms.TextBox();
            this.ChainMethodTitle = new System.Windows.Forms.Label();
            this.AddressFoundTextBox = new System.Windows.Forms.TextBox();
            this.AddressFoundLabel = new System.Windows.Forms.Label();
            this.AddressComprasionLabel = new System.Windows.Forms.Label();
            this.AddressСomparisonTextBox = new System.Windows.Forms.TextBox();
            this.AddressTimeTextBox = new System.Windows.Forms.TextBox();
            this.AddressTimeLabel = new System.Windows.Forms.Label();
            this.AddressMethodLabel = new System.Windows.Forms.Label();
            this.CollisionСomparisonLabel = new System.Windows.Forms.Label();
            this.TitlePanel.SuspendLayout();
            this.HashComparisonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).BeginInit();
            this.SolutionsComparisonPanel.SuspendLayout();
            this.ChainMethodPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(135, 12);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(220, 18);
            this.Title.TabIndex = 0;
            this.Title.Text = "Лабораторная работа №11";
            // 
            // DivisionMethodLabel
            // 
            this.DivisionMethodLabel.AutoSize = true;
            this.DivisionMethodLabel.Location = new System.Drawing.Point(104, 85);
            this.DivisionMethodLabel.Name = "DivisionMethodLabel";
            this.DivisionMethodLabel.Size = new System.Drawing.Size(107, 16);
            this.DivisionMethodLabel.TabIndex = 1;
            this.DivisionMethodLabel.Text = "Метод деления";
            // 
            // MidsquareMethodLabel
            // 
            this.MidsquareMethodLabel.AutoSize = true;
            this.MidsquareMethodLabel.Location = new System.Drawing.Point(39, 118);
            this.MidsquareMethodLabel.Name = "MidsquareMethodLabel";
            this.MidsquareMethodLabel.Size = new System.Drawing.Size(181, 16);
            this.MidsquareMethodLabel.TabIndex = 2;
            this.MidsquareMethodLabel.Text = "Метод середины квадрата";
            // 
            // FoldingMethodLabel
            // 
            this.FoldingMethodLabel.AutoSize = true;
            this.FoldingMethodLabel.Location = new System.Drawing.Point(73, 151);
            this.FoldingMethodLabel.Name = "FoldingMethodLabel";
            this.FoldingMethodLabel.Size = new System.Drawing.Size(138, 16);
            this.FoldingMethodLabel.TabIndex = 3;
            this.FoldingMethodLabel.Text = "Метод свёртывания";
            // 
            // MultiplicationMethodLabel
            // 
            this.MultiplicationMethodLabel.AutoSize = true;
            this.MultiplicationMethodLabel.Location = new System.Drawing.Point(86, 187);
            this.MultiplicationMethodLabel.Name = "MultiplicationMethodLabel";
            this.MultiplicationMethodLabel.Size = new System.Drawing.Size(125, 16);
            this.MultiplicationMethodLabel.TabIndex = 4;
            this.MultiplicationMethodLabel.Text = "Метод умножения";
            // 
            // DivisionMethodTextBox
            // 
            this.DivisionMethodTextBox.Location = new System.Drawing.Point(280, 85);
            this.DivisionMethodTextBox.Name = "DivisionMethodTextBox";
            this.DivisionMethodTextBox.ReadOnly = true;
            this.DivisionMethodTextBox.Size = new System.Drawing.Size(100, 22);
            this.DivisionMethodTextBox.TabIndex = 5;
            // 
            // MidsquaredMethodTextBox
            // 
            this.MidsquaredMethodTextBox.Location = new System.Drawing.Point(280, 118);
            this.MidsquaredMethodTextBox.Name = "MidsquaredMethodTextBox";
            this.MidsquaredMethodTextBox.ReadOnly = true;
            this.MidsquaredMethodTextBox.Size = new System.Drawing.Size(100, 22);
            this.MidsquaredMethodTextBox.TabIndex = 6;
            // 
            // FoldingMethodTextBox
            // 
            this.FoldingMethodTextBox.Location = new System.Drawing.Point(280, 151);
            this.FoldingMethodTextBox.Name = "FoldingMethodTextBox";
            this.FoldingMethodTextBox.ReadOnly = true;
            this.FoldingMethodTextBox.Size = new System.Drawing.Size(100, 22);
            this.FoldingMethodTextBox.TabIndex = 7;
            // 
            // MultiplicationMethodTextBox
            // 
            this.MultiplicationMethodTextBox.Location = new System.Drawing.Point(280, 187);
            this.MultiplicationMethodTextBox.Name = "MultiplicationMethodTextBox";
            this.MultiplicationMethodTextBox.ReadOnly = true;
            this.MultiplicationMethodTextBox.Size = new System.Drawing.Size(100, 22);
            this.MultiplicationMethodTextBox.TabIndex = 8;
            // 
            // HashButton
            // 
            this.HashButton.Location = new System.Drawing.Point(185, 227);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(100, 23);
            this.HashButton.TabIndex = 9;
            this.HashButton.Text = "Выполнить";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(379, 601);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 23);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(482, 45);
            this.TitlePanel.TabIndex = 11;
            // 
            // HashComparisonPanel
            // 
            this.HashComparisonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HashComparisonPanel.Controls.Add(this.quantityNumeric);
            this.HashComparisonPanel.Controls.Add(this.QuantityLabel);
            this.HashComparisonPanel.Controls.Add(this.ComparisonLabel);
            this.HashComparisonPanel.Controls.Add(this.HashButton);
            this.HashComparisonPanel.Controls.Add(this.DivisionMethodLabel);
            this.HashComparisonPanel.Controls.Add(this.MidsquareMethodLabel);
            this.HashComparisonPanel.Controls.Add(this.FoldingMethodLabel);
            this.HashComparisonPanel.Controls.Add(this.MultiplicationMethodLabel);
            this.HashComparisonPanel.Controls.Add(this.MultiplicationMethodTextBox);
            this.HashComparisonPanel.Controls.Add(this.DivisionMethodTextBox);
            this.HashComparisonPanel.Controls.Add(this.FoldingMethodTextBox);
            this.HashComparisonPanel.Controls.Add(this.MidsquaredMethodTextBox);
            this.HashComparisonPanel.Location = new System.Drawing.Point(0, 45);
            this.HashComparisonPanel.Name = "HashComparisonPanel";
            this.HashComparisonPanel.Size = new System.Drawing.Size(482, 255);
            this.HashComparisonPanel.TabIndex = 12;
            // 
            // quantityNumeric
            // 
            this.quantityNumeric.Location = new System.Drawing.Point(280, 45);
            this.quantityNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantityNumeric.Name = "quantityNumeric";
            this.quantityNumeric.Size = new System.Drawing.Size(120, 22);
            this.quantityNumeric.TabIndex = 11;
            this.quantityNumeric.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(86, 47);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(159, 16);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Количество сравнений";
            // 
            // ComparisonLabel
            // 
            this.ComparisonLabel.AutoSize = true;
            this.ComparisonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComparisonLabel.Location = new System.Drawing.Point(104, 13);
            this.ComparisonLabel.Name = "ComparisonLabel";
            this.ComparisonLabel.Size = new System.Drawing.Size(271, 18);
            this.ComparisonLabel.TabIndex = 9;
            this.ComparisonLabel.Text = "Сравнение функций хэширования";
            // 
            // SolutionsComparisonPanel
            // 
            this.SolutionsComparisonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SolutionsComparisonPanel.Controls.Add(this.CompareButton);
            this.SolutionsComparisonPanel.Controls.Add(this.ChainMethodPanel);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressFoundTextBox);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressFoundLabel);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressComprasionLabel);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressСomparisonTextBox);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressTimeTextBox);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressTimeLabel);
            this.SolutionsComparisonPanel.Controls.Add(this.AddressMethodLabel);
            this.SolutionsComparisonPanel.Controls.Add(this.CollisionСomparisonLabel);
            this.SolutionsComparisonPanel.Location = new System.Drawing.Point(0, 300);
            this.SolutionsComparisonPanel.Name = "SolutionsComparisonPanel";
            this.SolutionsComparisonPanel.Size = new System.Drawing.Size(482, 284);
            this.SolutionsComparisonPanel.TabIndex = 13;
            // 
            // CompareButton
            // 
            this.CompareButton.Location = new System.Drawing.Point(185, 242);
            this.CompareButton.Name = "CompareButton";
            this.CompareButton.Size = new System.Drawing.Size(92, 23);
            this.CompareButton.TabIndex = 14;
            this.CompareButton.Text = "Сравнить";
            this.CompareButton.UseVisualStyleBackColor = true;
            this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
            // 
            // ChainMethodPanel
            // 
            this.ChainMethodPanel.Controls.Add(this.ChainFoundLabel);
            this.ChainMethodPanel.Controls.Add(this.ChainFoundTextBox);
            this.ChainMethodPanel.Controls.Add(this.ChainComparisonLabel);
            this.ChainMethodPanel.Controls.Add(this.ChainComparisonTextBox);
            this.ChainMethodPanel.Controls.Add(this.ChainTimeLabel);
            this.ChainMethodPanel.Controls.Add(this.СhainTimeTextBox);
            this.ChainMethodPanel.Controls.Add(this.ChainMethodTitle);
            this.ChainMethodPanel.Location = new System.Drawing.Point(0, 122);
            this.ChainMethodPanel.Name = "ChainMethodPanel";
            this.ChainMethodPanel.Size = new System.Drawing.Size(481, 114);
            this.ChainMethodPanel.TabIndex = 17;
            // 
            // ChainFoundLabel
            // 
            this.ChainFoundLabel.AutoSize = true;
            this.ChainFoundLabel.Location = new System.Drawing.Point(375, 49);
            this.ChainFoundLabel.Name = "ChainFoundLabel";
            this.ChainFoundLabel.Size = new System.Drawing.Size(65, 16);
            this.ChainFoundLabel.TabIndex = 18;
            this.ChainFoundLabel.Text = "Найдено";
            // 
            // ChainFoundTextBox
            // 
            this.ChainFoundTextBox.Location = new System.Drawing.Point(360, 68);
            this.ChainFoundTextBox.Name = "ChainFoundTextBox";
            this.ChainFoundTextBox.ReadOnly = true;
            this.ChainFoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChainFoundTextBox.TabIndex = 17;
            // 
            // ChainComparisonLabel
            // 
            this.ChainComparisonLabel.AutoSize = true;
            this.ChainComparisonLabel.Location = new System.Drawing.Point(190, 49);
            this.ChainComparisonLabel.Name = "ChainComparisonLabel";
            this.ChainComparisonLabel.Size = new System.Drawing.Size(79, 16);
            this.ChainComparisonLabel.TabIndex = 16;
            this.ChainComparisonLabel.Text = "Сравнения";
            // 
            // ChainComparisonTextBox
            // 
            this.ChainComparisonTextBox.Location = new System.Drawing.Point(185, 68);
            this.ChainComparisonTextBox.Name = "ChainComparisonTextBox";
            this.ChainComparisonTextBox.ReadOnly = true;
            this.ChainComparisonTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChainComparisonTextBox.TabIndex = 15;
            // 
            // ChainTimeLabel
            // 
            this.ChainTimeLabel.AutoSize = true;
            this.ChainTimeLabel.Location = new System.Drawing.Point(39, 49);
            this.ChainTimeLabel.Name = "ChainTimeLabel";
            this.ChainTimeLabel.Size = new System.Drawing.Size(48, 16);
            this.ChainTimeLabel.TabIndex = 14;
            this.ChainTimeLabel.Text = "Время";
            // 
            // СhainTimeTextBox
            // 
            this.СhainTimeTextBox.Location = new System.Drawing.Point(11, 68);
            this.СhainTimeTextBox.Name = "СhainTimeTextBox";
            this.СhainTimeTextBox.ReadOnly = true;
            this.СhainTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.СhainTimeTextBox.TabIndex = 13;
            // 
            // ChainMethodTitle
            // 
            this.ChainMethodTitle.AutoSize = true;
            this.ChainMethodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChainMethodTitle.Location = new System.Drawing.Point(175, 9);
            this.ChainMethodTitle.Name = "ChainMethodTitle";
            this.ChainMethodTitle.Size = new System.Drawing.Size(120, 16);
            this.ChainMethodTitle.TabIndex = 12;
            this.ChainMethodTitle.Text = "Метод цепочек";
            // 
            // AddressFoundTextBox
            // 
            this.AddressFoundTextBox.Location = new System.Drawing.Point(360, 94);
            this.AddressFoundTextBox.Name = "AddressFoundTextBox";
            this.AddressFoundTextBox.ReadOnly = true;
            this.AddressFoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressFoundTextBox.TabIndex = 16;
            // 
            // AddressFoundLabel
            // 
            this.AddressFoundLabel.AutoSize = true;
            this.AddressFoundLabel.Location = new System.Drawing.Point(375, 75);
            this.AddressFoundLabel.Name = "AddressFoundLabel";
            this.AddressFoundLabel.Size = new System.Drawing.Size(65, 16);
            this.AddressFoundLabel.TabIndex = 15;
            this.AddressFoundLabel.Text = "Найдено";
            // 
            // AddressComprasionLabel
            // 
            this.AddressComprasionLabel.AutoSize = true;
            this.AddressComprasionLabel.Location = new System.Drawing.Point(190, 75);
            this.AddressComprasionLabel.Name = "AddressComprasionLabel";
            this.AddressComprasionLabel.Size = new System.Drawing.Size(79, 16);
            this.AddressComprasionLabel.TabIndex = 14;
            this.AddressComprasionLabel.Text = "Сравнения";
            // 
            // AddressСomparisonTextBox
            // 
            this.AddressСomparisonTextBox.Location = new System.Drawing.Point(185, 94);
            this.AddressСomparisonTextBox.Name = "AddressСomparisonTextBox";
            this.AddressСomparisonTextBox.ReadOnly = true;
            this.AddressСomparisonTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressСomparisonTextBox.TabIndex = 13;
            // 
            // AddressTimeTextBox
            // 
            this.AddressTimeTextBox.Location = new System.Drawing.Point(11, 94);
            this.AddressTimeTextBox.Name = "AddressTimeTextBox";
            this.AddressTimeTextBox.ReadOnly = true;
            this.AddressTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.AddressTimeTextBox.TabIndex = 12;
            // 
            // AddressTimeLabel
            // 
            this.AddressTimeLabel.AutoSize = true;
            this.AddressTimeLabel.Location = new System.Drawing.Point(39, 75);
            this.AddressTimeLabel.Name = "AddressTimeLabel";
            this.AddressTimeLabel.Size = new System.Drawing.Size(48, 16);
            this.AddressTimeLabel.TabIndex = 12;
            this.AddressTimeLabel.Text = "Время";
            // 
            // AddressMethodLabel
            // 
            this.AddressMethodLabel.AutoSize = true;
            this.AddressMethodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressMethodLabel.Location = new System.Drawing.Point(134, 47);
            this.AddressMethodLabel.Name = "AddressMethodLabel";
            this.AddressMethodLabel.Size = new System.Drawing.Size(212, 16);
            this.AddressMethodLabel.TabIndex = 11;
            this.AddressMethodLabel.Text = "Метод открытой адресации";
            // 
            // CollisionСomparisonLabel
            // 
            this.CollisionСomparisonLabel.AutoSize = true;
            this.CollisionСomparisonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CollisionСomparisonLabel.Location = new System.Drawing.Point(57, 16);
            this.CollisionСomparisonLabel.Name = "CollisionСomparisonLabel";
            this.CollisionСomparisonLabel.Size = new System.Drawing.Size(343, 18);
            this.CollisionСomparisonLabel.TabIndex = 10;
            this.CollisionСomparisonLabel.Text = "Сравнение методов разрешения коллизий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 653);
            this.Controls.Add(this.SolutionsComparisonPanel);
            this.Controls.Add(this.HashComparisonPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "24ВП1 Толстоухов ЛР 8-11";
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.HashComparisonPanel.ResumeLayout(false);
            this.HashComparisonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumeric)).EndInit();
            this.SolutionsComparisonPanel.ResumeLayout(false);
            this.SolutionsComparisonPanel.PerformLayout();
            this.ChainMethodPanel.ResumeLayout(false);
            this.ChainMethodPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label DivisionMethodLabel;
        private System.Windows.Forms.Label MidsquareMethodLabel;
        private System.Windows.Forms.Label FoldingMethodLabel;
        private System.Windows.Forms.Label MultiplicationMethodLabel;
        private System.Windows.Forms.TextBox DivisionMethodTextBox;
        private System.Windows.Forms.TextBox MidsquaredMethodTextBox;
        private System.Windows.Forms.TextBox FoldingMethodTextBox;
        private System.Windows.Forms.TextBox MultiplicationMethodTextBox;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel HashComparisonPanel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label ComparisonLabel;
        private System.Windows.Forms.NumericUpDown quantityNumeric;
        private System.Windows.Forms.Panel SolutionsComparisonPanel;
        private System.Windows.Forms.Label AddressTimeLabel;
        private System.Windows.Forms.Label AddressMethodLabel;
        private System.Windows.Forms.Label CollisionСomparisonLabel;
        private System.Windows.Forms.TextBox AddressTimeTextBox;
        private System.Windows.Forms.TextBox AddressСomparisonTextBox;
        private System.Windows.Forms.TextBox AddressFoundTextBox;
        private System.Windows.Forms.Label AddressFoundLabel;
        private System.Windows.Forms.Label AddressComprasionLabel;
        private System.Windows.Forms.Panel ChainMethodPanel;
        private System.Windows.Forms.Button CompareButton;
        private System.Windows.Forms.Label ChainTimeLabel;
        private System.Windows.Forms.TextBox СhainTimeTextBox;
        private System.Windows.Forms.Label ChainMethodTitle;
        private System.Windows.Forms.Label ChainComparisonLabel;
        private System.Windows.Forms.TextBox ChainComparisonTextBox;
        private System.Windows.Forms.Label ChainFoundLabel;
        private System.Windows.Forms.TextBox ChainFoundTextBox;
    }
}

