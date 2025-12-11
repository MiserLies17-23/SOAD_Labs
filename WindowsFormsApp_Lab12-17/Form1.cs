using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab12_17
{
    public partial class SortingForm : Form
    {
        public SortingForm()
        {
            InitializeComponent();
        }

        private void SortingForm_Load(object sender, EventArgs e)
        {
            DataGridView_Initilize();
        }

        private void DataGridView_Initilize()
        {
            dataGridView1.RowCount = 7;
            dataGridView1.Rows[0].Cells[1].Value = "Обмен";
            dataGridView1.Rows[1].Cells[1].Value = "Выбор";
            dataGridView1.Rows[2].Cells[1].Value = "Включение";
            dataGridView1.Rows[3].Cells[1].Value = "Шелла";
            dataGridView1.Rows[4].Cells[1].Value = "Быстрая";
            dataGridView1.Rows[5].Cells[1].Value = "Линейная";
            dataGridView1.Rows[6].Cells[1].Value = "Встроенная";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
