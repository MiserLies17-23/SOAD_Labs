using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab5
{
    public partial class Form1 : Form
    {
        private int n;
        private long[] mas;
        private const int BEGIN = 1000000;
        private const int END = 30000001;
        private int key;
        private const int REPLAY = 1000000, REPLAY2 = 1000;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            n = rnd.Next(BEGIN, END);
            mas = new long[n+1]; 
            int elem = rnd.Next(0, 5), step = 5;
            for (int i = 0; i < n; i++)
            {
                mas[i] = elem;
                elem = rnd.Next(elem+1, elem + step);
            }
            mas[n] = n + 1;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            key = (int)keyValue.Value;

            UnOptimalBinarySearch();
            OptimalBinarySearch();
            InterpolationSearch();
            SequentialBinarySearch();
            SequentialSearch();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UnOptimalBinarySearch()
        {
            long index = 0;
            long right;
            long left;

            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY; i++)
            {
                // Алгоритм неоптимального бинарного поиска (алогритм А)
                left = 0;
                right = n - 1;
                index = (right + left) / 2;

                while (left <= right)
                {
                    if (mas[index] == key) break;
                    if (mas[index] > key) right = index - 1;
                    else left = index + 1;
                    index = (right + left) / 2;
                }
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (mas[index] != key) SuboptimalIndex.Text = "Нет элемента";
            else SuboptimalIndex.Text = index.ToString();
            SuboptimalTime.Text = ResultTime.ToString();
        }

        private void OptimalBinarySearch()
        {
            long index = 0;
            long right = 0;
            long left;
            
            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY; i++)
            {
                // Алгоритм оптимального бинарного поиска (алогритм B)
                left = 0;
                right = n - 1;
                index = (right + left) / 2;

                while (left < right)
                {
                    if (key <= mas[index]) right = index;
                    else left = index + 1;
                    index = (right + left) / 2;
                }
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (mas[right] != key) OptimalIndex.Text = "Нет элемента";
            else OptimalIndex.Text = right.ToString();
            OptimalTime.Text = ResultTime.ToString();
        }

        private void InterpolationSearch()
        {
            long index = 0;
            long right;
            long left;

            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY; i++)
            {
                // Алгоритм интерполяционного поиска (алгоритм C)
                left = 0;
                right = n - 1;
                index = 0;
                while (key > mas[left] && key < mas[right])
                {
                    index = left + (key - mas[left]) * (right - left) / (mas[right] - mas[left]);
                    if (mas[index] == key) break;
                    if (mas[index] > key) right = index - 1;
                    else left = index + 1;
                }
                if (mas[right] == key) index = right;
                else if (mas[left] == key) index = left;
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (mas[index] != key) InterpolationIndex.Text = "Нет элемента";
            else InterpolationIndex.Text = index.ToString();
            InterpolationTime.Text = ResultTime.ToString();
        }

        private void SequentialBinarySearch()
        {
            int P = 0;
            int B;

            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY; i++)
            {
                // Алгоритм "последовательного" бинарного поиска (Алгоритм D) 
                P = 0;
                B = n / 2;
                while (B > 0)
                {
                    while (P + B < n && mas[P + B] <= key) P += B;
                    B /= 2;
                }
            }

            int ResultTime = Environment.TickCount - StartTime;
            if (mas[P] == key) ConsistentIndex.Text = P.ToString();
            else ConsistentIndex.Text = "Нет элемента";
            ConsistentTime.Text = ResultTime.ToString();
        }

        private void SequentialSearch()
        {
            int index = 0;
            mas[n] = key + 1;
            int StartTime = Environment.TickCount;
            for (int i = 0; i < REPLAY2; i++)
            {
                index = 0;
                while (mas[index] < key)
                {
                    index++;
                }
            }

            int ResultTime = (Environment.TickCount - StartTime)*10000;
            if (mas[index] == key) ConsistentInSortIndex.Text = index.ToString();
            else ConsistentInSortIndex.Text = "Нет элемента";
            ConsistentInSortTime.Text = ResultTime.ToString();
        }
    }
}