using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab18_20
{
    public partial class MainForm : Form
    {
        private readonly Random _RND;
        private readonly static int _ROWS_COUNT = 4;
        public MainForm()
        {
            InitializeComponent();
            _RND = new Random();
            TreeDataGridView.RowCount = _ROWS_COUNT;
        }

        private void Print(int[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                ArrayDataGridView.Rows[0].Cells[i].Value = m[i].ToString();
            }
            int index = 0;
            for (int i = 1; i <= _ROWS_COUNT; i++)
            {
                int j = m.Length/(int)Math.Pow(2, i);
                while (j < m.Length)
                {
                    TreeDataGridView.Rows[i - 1].Cells[j].Value = m[index].ToString();
                    index++;
                    j += m.Length / (int)Math.Pow(2, i - 1) + 1;
                    
                }
            }
        }

        private void CreateQueueButton_Click(object sender, EventArgs e)
        {
            int[] m = new int[15];
            for (int i = 0; i < m.Length; i++)
            {
                m[i] = _RND.Next(10, 100);
            }
            
            // Это для 19!
            //for (int i = 0; i < m.Length / 2; i++)
            //{
            //    int index = i, right = 2 * i + 1;
            //    if (m[right] > m[i])
            //    {
            //        index = right;
            //    }
            //    int left = 2 * i + 2;
            //    if (m[left] > m[i])
            //    {
            //        index = left;
            //    }
            //    while (m[index] > m[i])
            //    {
            //        (m[i], m[index]) = (m[index], m[i]);
            //        index = i;
            //        i /= 2;
            //    }
            //}
            Print(m);
        }

        private void ClearQueueButton_Click(object sender, EventArgs e)
        {
            ArrayDataGridView.Rows.Clear();

            InsertDataGridView.Rows.Clear();

            TreeDataGridView.Rows.Clear();
            TreeDataGridView.RowCount = _ROWS_COUNT;
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
