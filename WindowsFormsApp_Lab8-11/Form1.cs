using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Lab8_11
{
    public partial class Form1 : Form
    {
        private const int BEGIN = 0, END = 10000; 
        private const int SIZE = 10000; 
        private double A = (Math.Sqrt(5) - 1) / 2;
        
        private int[] m1, m2, moa;
        private List<int>[] moc; 
        private readonly Random rnd;
        public Form1()
        {
            InitializeComponent();
            
            rnd = new Random();
            m1 = new int[SIZE];
            m2 = new int[SIZE];
            moa = new int[SIZE];
            moc = new List<int>[SIZE];
            InitializeArrays();
            InitializeArrayOfChains();
        }

        private void HashButton_Click(object sender, EventArgs e)
        {
            int div = 997;
            int n = (int)quantityNumeric.Value;
            int t1 = 0, t2 = 0, t3 = 0, t4 = 0;

            for (int i = 0; i < n; i++)
            {
                ArrayGenerate(); // обновляем массив случайных чисел

                int k1 = CollisionSum(DivisionMethod, div);
                InitializeArrayOfChains(); // обновляем массив цепочек
                
                int k2 = CollisionSum(MidsquareMethod, SIZE);
                InitializeArrayOfChains();

                int k3 = CollisionSum(MultiplicationMethod, SIZE);
                InitializeArrayOfChains();

                int k4 = CollisionSum(FoldingMethod, SIZE);
                InitializeArrayOfChains();

                int min = Math.Min(k1, Math.Min(k2, Math.Min(k3, k4))); // находим минимальное количество коллизий
                if (min == k1) t1++; // обновляем количество побед у метода с минимальным числом коллизий
                if (min == k2) t2++;
                if (min == k3) t3++;
                if (min == k4) t4++;
            }

            DivisionMethodTextBox.Text = t1.ToString();
            MidsquaredMethodTextBox.Text = t2.ToString();
            MultiplicationMethodTextBox.Text = t3.ToString();
            FoldingMethodTextBox.Text = t4.ToString();
        }

        private int CollisionSum(Func<int, int, int> method, int div)
        {
            int k = 0;
            foreach (int num in m1)
            {
                int hash = method(num, div);
                if (moc[hash].Count != 0) k++;
                moc[hash].Add(num);
            }
            return k;
        }

        // Метод деления
        public int DivisionMethod(int key, int div)
        {
            return key % div;
        }

        // Метод середины квадрата
        public int MidsquareMethod (int key, int size) 
        {
            long squared = (long)Math.Pow(key, 2);
            if (squared < size) return (int) squared;

            long squredSize = (long)Math.Ceiling(Math.Log10(squared));
            squared /= (long)Math.Pow(10, (squredSize - (long)Math.Log10(size))/2);
            int hash = (int)squared % (int)Math.Pow(10, Math.Log10(size)); 
            return hash; 
        }

        // Метод свёртывания
        public int FoldingMethod(int key, int size) 
        {
            int sum = 0;
            while (key > 0)
            {
                sum += key % size;
                key /= size;
            }
            return sum%size;
        }

        // Метод умножения
        public int MultiplicationMethod(int key, int size) 
        {
            double fraction = (double)(key * A) % 1;
            return (int)(fraction * size);
        }

        private void ArrayGenerate()
        {
            for (int i = 0; i < SIZE; i++)
                m1[i] = rnd.Next(BEGIN, END);
        }

        private void InitializeArrays()
        {
            for (int i = 0; i < SIZE; i++)
            {
                m1[i] = rnd.Next(BEGIN, END);
                m2[i] = rnd.Next(BEGIN, END * 2);
                moa[i] = -1;
            }
        }

        private void InitializeArrayOfChains()
        {
            Array.Clear(moc, 0, SIZE);
            for (int i = 0; i < SIZE; i++)
                moc[i] = new List<int>(); // ОБЯЗАТЕЛЬНО инициализируем цепочки!
        }

        private void CompareButton_Click(object sender, EventArgs e)
        {
            InitializeArrays();
            InitializeArrayOfChains();
            foreach (int num in m1)
            {
                // используем метод свёртывания 
                int hash = FoldingMethod(num, SIZE);

                while (moa[hash % SIZE] != -1)
                    hash++;
                moa[hash % SIZE] = num;
            }

            int sum = 0;
            int founds = 0;
            int StartTime = Environment.TickCount;
            
            foreach (int num in m2)
            {
                int hash = FoldingMethod(num, SIZE);

                for (int i = 0; i < SIZE; i++)
                {
                    sum++;
                    if (num == moa[hash % SIZE])
                    { 
                        founds++;
                        break;
                    }
                    hash++;
                }
                sum++;
            }

            int EndTime = Environment.TickCount - StartTime;
            float comparisons = (float)sum / SIZE;

            AddressTimeTextBox.Text = EndTime.ToString();
            AddressСomparisonTextBox.Text = comparisons.ToString();
            AddressFoundTextBox.Text = founds.ToString();

            foreach (int num in m1)
            {
                int hash = FoldingMethod(num, SIZE);

                moc[hash].Add(num);
            }

            sum = 0;
            founds = 0;
            StartTime = Environment.TickCount;

            foreach (int num in m2)
            {
                int hash = FoldingMethod(num, SIZE);

                for (int i = 0; i < moc[hash].Count; i++)
                {
                    sum++;
                    if (num == moc[hash][i])
                    {
                        founds++;
                        break;
                    }
                }
                sum++;
            }

            EndTime = Environment.TickCount - StartTime;
            comparisons = (float)sum / SIZE;

            СhainTimeTextBox.Text = EndTime.ToString();
            ChainComparisonTextBox.Text = comparisons.ToString();
            ChainFoundTextBox.Text = founds.ToString();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
