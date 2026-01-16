using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab12_17
{
    public partial class SortingForm : Form
    {
        private int[] m, copy;
        private int size;
        private const int ROWS_COUNT = 7;
        private const int CELLS_COUNT = 6;
        private static readonly Random rnd = new Random();

        private int comparisons;
        private int permutations;
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
            dataGridView1.RowCount = ROWS_COUNT;
            dataGridView1.Rows[0].Cells[1].Value = "Обмен";
            dataGridView1.Rows[1].Cells[1].Value = "Выбор";
            dataGridView1.Rows[2].Cells[1].Value = "Включение";
            dataGridView1.Rows[3].Cells[1].Value = "Шелла";
            dataGridView1.Rows[4].Cells[1].Value = "Быстрая";
            dataGridView1.Rows[5].Cells[1].Value = "Линейная";
            dataGridView1.Rows[6].Cells[1].Value = "Встроенная";
            
            dataGridView1.Rows[0].Cells[0].Value = true;
            dataGridView1.Rows[1].Cells[0].Value = true;
        }
        private void CompareButton_Click(object sender, EventArgs e)
        {
            MassiveInitilize(); // инициализируем массив заданной длины

            if((bool)dataGridView1.Rows[0].Cells[0].Value == true)
            {
                int StartTime = Environment.TickCount;
                m = BubbleSorting(m);
                int EndTime = Environment.TickCount - StartTime;
                dataGridView1.Rows[0].Cells[2].Value = comparisons;
                dataGridView1.Rows[0].Cells[3].Value = permutations;
                dataGridView1.Rows[0].Cells[4].Value = EndTime;
                dataGridView1.Rows[0].Cells[5].Value = SortingCheck(m) ? "Да" : "Нет";
            }
            else
            {
                dataGridView1.Rows[0].Cells[2].Value = null;
                dataGridView1.Rows[0].Cells[3].Value = null;
                dataGridView1.Rows[0].Cells[4].Value = null;
                dataGridView1.Rows[0].Cells[5].Value = null;
            }
            
            MassiveUpdate(); // обновляем массив - возвращаем в исходное состояние

            if ((bool)dataGridView1.Rows[1].Cells[0].Value == true)
            {
                int StartTime = Environment.TickCount;
                m = DirectSelection(m);
                int EndTime = Environment.TickCount - StartTime;
                dataGridView1.Rows[1].Cells[2].Value = comparisons;
                dataGridView1.Rows[1].Cells[3].Value = permutations;
                dataGridView1.Rows[1].Cells[4].Value = EndTime;
                dataGridView1.Rows[1].Cells[5].Value = SortingCheck(m) ? "Да" : "Нет";
            }
            else
            {
                dataGridView1.Rows[1].Cells[2].Value = null;
                dataGridView1.Rows[1].Cells[3].Value = null;
                dataGridView1.Rows[1].Cells[4].Value = null;
                dataGridView1.Rows[1].Cells[5].Value = null;
            }

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MassiveInitilize()
        {
            comparisons = 0; permutations = 0;
            size = (int)ArraySizeNumeric.Value;
            m = new int[size]; 
            copy = new int[size];

            for (int i = 0; i < size; i++)
            {
                int elem = rnd.Next();
                m[i] = elem;
                copy[i] = elem;
            }
        }
        private void MassiveUpdate()
        {
            comparisons = 0; permutations = 0;
            for (int i = 0; i < size; i++)
                m[i] = copy[i];
        }

        private bool SortingCheck(int[] m)
        {
            for (int i = 0; i < size - 1; i++)
                if (m[i] > m[i + 1]) return false;
            return true;
        }

        public int[] BubbleSorting(int[] m)
        {
            bool flag = true;
            for (int start = 0; start < size && flag; start++)
            {
                flag = false;
                for (int next = 0; next < size - start - 1; next++)
                {
                    if (m[next] > m[next + 1])
                    {
                        (m[next], m[next + 1]) = (m[next + 1], m[next]);
                        permutations++;
                        flag = true;
                    }
                    comparisons++;
                }
            }
            return m;
        }

        public int[] DirectSelection(int[] m)
        {
            for (int i = 0; i < size -1; i ++)
            {
                int index = i;
                for (int j = i + 1; j < size; j++) 
                {   
                    if (m[j] < m[index]) index = j;
                    comparisons++;
                }
                (m[i], m[index]) = (m[index], m[i]);
                permutations++;
            }
            return m;
        }

        public void ClearDataGridVeiw()
        {
            for (int i = 0; i < 2;i ++)
            {
                for (int j = 2; j < 6; j ++)
                    dataGridView1.Rows[i].Cells[i].Value = null;
            }
        }
    }
}
