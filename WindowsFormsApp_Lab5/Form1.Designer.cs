namespace WindowsFormsApp_Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.OptimalPanel = new System.Windows.Forms.Panel();
            this.keyValue = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuboptimalIndex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuboptimalTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.OptimalIndex = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OptimalTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.InterpolationIndex = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.InterpolationTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ConsistentIndex = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ConsistentTime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.ConsistentInSortIndex = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ConsistentInSortTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OptimalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №7";
            // 
            // OptimalPanel
            // 
            this.OptimalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OptimalPanel.Controls.Add(this.keyValue);
            this.OptimalPanel.Controls.Add(this.label2);
            this.OptimalPanel.Location = new System.Drawing.Point(-1, 28);
            this.OptimalPanel.Name = "OptimalPanel";
            this.OptimalPanel.Size = new System.Drawing.Size(484, 48);
            this.OptimalPanel.TabIndex = 1;
            // 
            // keyValue
            // 
            this.keyValue.Location = new System.Drawing.Point(206, 12);
            this.keyValue.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.keyValue.Name = "keyValue";
            this.keyValue.Size = new System.Drawing.Size(120, 22);
            this.keyValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ключ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SuboptimalIndex);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.SuboptimalTime);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 65);
            this.panel2.TabIndex = 2;
            // 
            // SuboptimalIndex
            // 
            this.SuboptimalIndex.Location = new System.Drawing.Point(313, 36);
            this.SuboptimalIndex.Name = "SuboptimalIndex";
            this.SuboptimalIndex.Size = new System.Drawing.Size(100, 22);
            this.SuboptimalIndex.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Индекс";
            // 
            // SuboptimalTime
            // 
            this.SuboptimalTime.Location = new System.Drawing.Point(129, 33);
            this.SuboptimalTime.Name = "SuboptimalTime";
            this.SuboptimalTime.Size = new System.Drawing.Size(100, 22);
            this.SuboptimalTime.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Время";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Неоптимальный бинарный поиск";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.OptimalIndex);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.OptimalTime);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(-1, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 65);
            this.panel3.TabIndex = 3;
            // 
            // OptimalIndex
            // 
            this.OptimalIndex.Location = new System.Drawing.Point(313, 28);
            this.OptimalIndex.Name = "OptimalIndex";
            this.OptimalIndex.Size = new System.Drawing.Size(100, 22);
            this.OptimalIndex.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Индекс";
            // 
            // OptimalTime
            // 
            this.OptimalTime.Location = new System.Drawing.Point(129, 31);
            this.OptimalTime.Name = "OptimalTime";
            this.OptimalTime.Size = new System.Drawing.Size(100, 22);
            this.OptimalTime.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Время";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Оптимальный бинарный поиск";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Интерполяционный бинарный поиск";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.InterpolationIndex);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.InterpolationTime);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(-1, 205);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(484, 65);
            this.panel4.TabIndex = 5;
            // 
            // InterpolationIndex
            // 
            this.InterpolationIndex.Location = new System.Drawing.Point(313, 31);
            this.InterpolationIndex.Name = "InterpolationIndex";
            this.InterpolationIndex.Size = new System.Drawing.Size(100, 22);
            this.InterpolationIndex.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(252, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Индекс";
            // 
            // InterpolationTime
            // 
            this.InterpolationTime.Location = new System.Drawing.Point(129, 34);
            this.InterpolationTime.Name = "InterpolationTime";
            this.InterpolationTime.Size = new System.Drawing.Size(100, 22);
            this.InterpolationTime.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Время";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.ConsistentIndex);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.ConsistentTime);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(-1, 270);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(484, 65);
            this.panel5.TabIndex = 6;
            // 
            // ConsistentIndex
            // 
            this.ConsistentIndex.Location = new System.Drawing.Point(313, 34);
            this.ConsistentIndex.Name = "ConsistentIndex";
            this.ConsistentIndex.Size = new System.Drawing.Size(100, 22);
            this.ConsistentIndex.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(252, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Индекс";
            // 
            // ConsistentTime
            // 
            this.ConsistentTime.Location = new System.Drawing.Point(129, 34);
            this.ConsistentTime.Name = "ConsistentTime";
            this.ConsistentTime.Size = new System.Drawing.Size(100, 22);
            this.ConsistentTime.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Время";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(110, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(254, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "\"Последовательный\" бинарный поиск";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.ConsistentInSortIndex);
            this.panel6.Controls.Add(this.label17);
            this.panel6.Controls.Add(this.ConsistentInSortTime);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(-1, 335);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(484, 65);
            this.panel6.TabIndex = 7;
            // 
            // ConsistentInSortIndex
            // 
            this.ConsistentInSortIndex.Location = new System.Drawing.Point(313, 30);
            this.ConsistentInSortIndex.Name = "ConsistentInSortIndex";
            this.ConsistentInSortIndex.Size = new System.Drawing.Size(100, 22);
            this.ConsistentInSortIndex.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(252, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 9;
            this.label17.Text = "Индекс";
            // 
            // ConsistentInSortTime
            // 
            this.ConsistentInSortTime.Location = new System.Drawing.Point(129, 33);
            this.ConsistentInSortTime.Name = "ConsistentInSortTime";
            this.ConsistentInSortTime.Size = new System.Drawing.Size(100, 22);
            this.ConsistentInSortTime.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(75, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "Время";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(352, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "Последовательный поиск в упорядоченном массиве";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.SearchButton);
            this.panel7.Location = new System.Drawing.Point(-1, 400);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(484, 50);
            this.panel7.TabIndex = 8;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(210, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(338, 465);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptimalPanel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "24ВП1_Толстоухов_Лаб5-7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OptimalPanel.ResumeLayout(false);
            this.OptimalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keyValue)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel OptimalPanel;
        private System.Windows.Forms.NumericUpDown keyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SuboptimalIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SuboptimalTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox OptimalIndex;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox OptimalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox InterpolationIndex;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox InterpolationTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ConsistentIndex;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ConsistentTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox ConsistentInSortIndex;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ConsistentInSortTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

