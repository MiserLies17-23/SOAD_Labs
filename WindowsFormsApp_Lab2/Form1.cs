using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab2
{
    public partial class Form1 : Form
    {
        private int n;
        private int[] mas, sortMas;
        private const int REPLAY = 100;
        private const int BEGIN = 1000000;
        private const int END = 10000001;
        private int index, key;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            n = rnd.Next(BEGIN, END);
            mas = new int[n+1];
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0, n);
            }

            //Отсортированный массив
            sortMas = new int[n + 1];
            int elem = rnd.Next(0, n), step = 3;
            for (int i = 0; i < n; i++)
            {
                sortMas[i] = elem;
                elem = rnd.Next(elem, elem+step);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            key = (int)numericUpDown2.Value;
            SuboptimalSequentialSearch(textBox1, textBox4, mas);

            // Алгоритм оптимального последовательного поиска (алгоритм B)
            OptimalSequentialSearch(textBox2, textBox3, mas);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            key = (int)numericUpDown1.Value;

            // Алгоритм оптимального последовательного поиска (алгоритм B)
            OptimalSequentialSearch(textBox7, textBox8, sortMas);

            // Алгоритм последовательного поиска в упорядоченном массиве (алгоритм C)
            OptimalSequentialSearchInSorted(textBox5, textBox6, sortMas);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SuboptimalSequentialSearch (TextBox ind, TextBox time, int[] mas)
        {
            int StartTime = Environment.TickCount;

            for (int j = 0; j < REPLAY; j++)
            {
                // алгоритм неоптимального последовательного поиска (алгоритм А) для неупорядоченного массива.
                for (index = 0; index < n; index++)
                {
                    if (mas[index] == key) break;
                }
            }
            int ResultTime = Environment.TickCount - StartTime;

            // Проверка ненахождения элемента
            if (index == n) ind.Text = "Элемент не найден!";
            else ind.Text = index.ToString();
            time.Text = ResultTime.ToString();
        }

        private void OptimalSequentialSearch(TextBox ind, TextBox time, int[] mas)
        {
            mas[n] = key;
            int StartTime = Environment.TickCount;
            for (int j = 0; j < REPLAY; j++)
            {
                index = 0;
                while (mas[index] != key)
                {
                    index++;
                }
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (index == n) ind.Text = "Элемент не найден!";
            else ind.Text = index.ToString();
            time.Text = ResultTime.ToString();
        }

        private void OptimalSequentialSearchInSorted (TextBox ind, TextBox time, int[] mas)
        {
            mas[n] = key + 1;
            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY; i++)
            {
                index = 0;
                while (sortMas[index] < key)
                {
                    index++;
                }
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (mas[index] == key) ind.Text = index.ToString();
            else ind.Text = "Элемент не найден!";
            time.Text = ResultTime.ToString();
        }
    }
}
