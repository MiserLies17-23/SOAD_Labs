using System.Drawing;

namespace WinFormsApp_Lab22_26
{
    public partial class MainForm : Form
    {
        private readonly static int RowsCount = 5;

        private readonly static Random Rnd = new Random();

        private int comparisons;

        private int equalyties;

        private int[] m, copy;

        public MainForm()
        {
            InitializeComponent();
            comparisons = 0;
            equalyties = 0;
            m = [];
            copy = [];
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            SortDataGridView.RowCount = RowsCount;
            SortDataGridView.Rows[0].Cells[1].Value = "Простое 2ф";
            SortDataGridView.Rows[1].Cells[1].Value = "Простое 1ф";
            SortDataGridView.Rows[2].Cells[1].Value = "Естественное 2ф";
            SortDataGridView.Rows[3].Cells[1].Value = "Естественное 1ф";
            SortDataGridView.Rows[4].Cells[1].Value = "Поглощение";

            SortDataGridView.Rows[0].Cells[0].Value = true;
            SortDataGridView.Rows[1].Cells[0].Value = true;
            SortDataGridView.Rows[2].Cells[0].Value = true;
            SortDataGridView.Rows[3].Cells[0].Value = true;
            SortDataGridView.Rows[4].Cells[0].Value = true;

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            MassiveInitilize();
            comparisons = 0;
            equalyties = 0;

            if ((bool)SortDataGridView.Rows[0].Cells[0].Value == true)
            {
                int startTime = Environment.TickCount;
                m = TwoPhaseMergeSorting(m, 1);
                int endTime = Environment.TickCount - startTime;

                bool isSorted = IsSorted(m);

                SortDataGridView.Rows[0].Cells[2].Value = comparisons;
                SortDataGridView.Rows[0].Cells[3].Value = equalyties;
                SortDataGridView.Rows[0].Cells[4].Value = endTime;
                SortDataGridView.Rows[0].Cells[5].Value = isSorted ? "Да" : "Нет";
            }
            else
            {
                SortDataGridView.Rows[0].Cells[2].Value = null;
                SortDataGridView.Rows[0].Cells[3].Value = null;
                SortDataGridView.Rows[0].Cells[4].Value = null;
                SortDataGridView.Rows[0].Cells[5].Value = null;
            }

            MassiveUpdate();

            if ((bool)SortDataGridView.Rows[1].Cells[0].Value == true)
            {
                int startTime = Environment.TickCount;
                m = OnePhaseMergeSorting(m, 1);
                int endTime = Environment.TickCount - startTime;

                bool isSorted = IsSorted(m);

                SortDataGridView.Rows[1].Cells[2].Value = comparisons;
                SortDataGridView.Rows[1].Cells[3].Value = equalyties;
                SortDataGridView.Rows[1].Cells[4].Value = endTime;
                SortDataGridView.Rows[1].Cells[5].Value = isSorted ? "Да" : "Нет";
            }
            else
            {
                SortDataGridView.Rows[1].Cells[2].Value = null;
                SortDataGridView.Rows[1].Cells[3].Value = null;
                SortDataGridView.Rows[1].Cells[4].Value = null;
                SortDataGridView.Rows[1].Cells[5].Value = null;
            }

            MassiveUpdate();

            if ((bool)SortDataGridView.Rows[2].Cells[0].Value == true)
            {
                int startTime = Environment.TickCount;
                m = TwoPhaseEstMergeSorting(m);
                int endTime = Environment.TickCount - startTime;

                bool isSorted = IsSorted(m);

                SortDataGridView.Rows[2].Cells[2].Value = comparisons;
                SortDataGridView.Rows[2].Cells[3].Value = equalyties;
                SortDataGridView.Rows[2].Cells[4].Value = endTime;
                SortDataGridView.Rows[2].Cells[5].Value = isSorted ? "Да" : "Нет";
            }
            else
            {
                SortDataGridView.Rows[2].Cells[2].Value = null;
                SortDataGridView.Rows[2].Cells[3].Value = null;
                SortDataGridView.Rows[2].Cells[4].Value = null;
                SortDataGridView.Rows[2].Cells[5].Value = null;
            }

            MassiveUpdate();

            if ((bool)SortDataGridView.Rows[3].Cells[0].Value == true)
            {
                int startTime = Environment.TickCount;
                m = OnePhaseEstMergeSorting(m);
                int endTime = Environment.TickCount - startTime;

                bool isSorted = IsSorted(m);

                SortDataGridView.Rows[3].Cells[2].Value = comparisons;
                SortDataGridView.Rows[3].Cells[3].Value = equalyties;
                SortDataGridView.Rows[3].Cells[4].Value = endTime;
                SortDataGridView.Rows[3].Cells[5].Value = isSorted ? "Да" : "Нет";
            }
            else
            {
                SortDataGridView.Rows[3].Cells[2].Value = null;
                SortDataGridView.Rows[3].Cells[3].Value = null;
                SortDataGridView.Rows[3].Cells[4].Value = null;
                SortDataGridView.Rows[3].Cells[5].Value = null;
            }

            MassiveUpdate();

            if ((bool)SortDataGridView.Rows[4].Cells[0].Value == true)
            {
                double memoryPart = (double)PercentNumericUpDown.Value / 100;
                int startTime = Environment.TickCount;
                m = SortingByAbsorption(m, memoryPart);
                int endTime = Environment.TickCount - startTime;

                bool isSorted = IsSorted(m);

                SortDataGridView.Rows[4].Cells[2].Value = comparisons;
                SortDataGridView.Rows[4].Cells[3].Value = equalyties;
                SortDataGridView.Rows[4].Cells[4].Value = endTime;
                SortDataGridView.Rows[4].Cells[5].Value = isSorted ? "Да" : "Нет";
            }
            else
            {
                SortDataGridView.Rows[4].Cells[2].Value = null;
                SortDataGridView.Rows[4].Cells[3].Value = null;
                SortDataGridView.Rows[4].Cells[4].Value = null;
                SortDataGridView.Rows[4].Cells[5].Value = null;
            }
        }

        private void MassiveInitilize()
        {
            int size = (int)SizeNumericUpDown.Value;
            m = new int[size];
            copy = new int[size];
            for (int i = 0; i < size; i++)
            {
                int elem = Rnd.Next(0, size);
                m[i] = elem;
            }
            Array.Copy(m, copy, m.Length);
        }

        private void MassiveUpdate()
        {
            comparisons = 0; equalyties = 0;
            for (int i = 0; i < copy.Length; i++)
                m[i] = copy[i];
        }

        public int[] SortingByAbsorption(int[] a, double memoryPart)
        {
            int memorySize = (int)Math.Ceiling(memoryPart * a.Length);
            int roundsCount = (int)Math.Ceiling((double)a.Length / memorySize);

            int start = a.Length - 1;

            int[] op = new int[memorySize];
            for (int i = 0; i < memorySize && start >= 0; i++)
            {
                op[i] = a[start--];
                equalyties++;
            }
            Array.Sort(op);
            for (int i = memorySize - 1; i >= 0; i--)
            {
                a[a.Length - 1 - i] = op[^(i + 1)];
                equalyties++;
            }
            for (int i = 1; i < roundsCount; i++)
            {
                memorySize = (int)Math.Min(a.Length - start, memorySize);
                for (int j = 0; j < memorySize && start >= 0; j++)
                {
                    op[j] = a[start - j];
                    equalyties++;
                }
                Array.Sort(op);

                int leftIndex = 0;
                int rightIndex = start + 1;
                int aIndex = start - memorySize + 1;

                while (leftIndex < memorySize && rightIndex < a.Length)
                {
                    if (op[leftIndex] < a[rightIndex])
                    {
                        a[aIndex++] = op[leftIndex++];
                        comparisons++;
                        equalyties++;
                    }
                    else
                    {
                        a[aIndex++] = a[rightIndex++];
                        comparisons++; 
                        equalyties++;
                    }
                }

                while (leftIndex < memorySize)
                {
                    a[aIndex++] = op[leftIndex++];
                    equalyties++;
                }

                start -= memorySize;
            }
            return a;
        }

        public int[] TwoPhaseMergeSorting(int[] a, int seriesLength)
        {
            int seriesCount = (int)Math.Ceiling(a.Length / (double)seriesLength);

            int bLength = 0, cLength = 0, aLength = a.Length;
            while (aLength > 0)
            {
                if (aLength < seriesLength)
                {
                    bLength += aLength;
                    break;
                }
                bLength += seriesLength;
                aLength -= seriesLength * 2;
            }
            cLength = a.Length - bLength;

            int[] b = new int[bLength];
            int[] c = new int[cLength];

            int bIndex = 0, cIndex = 0;
            for (int i = 0; i < seriesCount; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < seriesLength && i * seriesLength + j < a.Length; j++)
                    { 
                        b[bIndex++] = a[i * seriesLength + j];
                        equalyties++;
                    }

                }
                else
                {
                    for (int j = 0; j < seriesLength && i * seriesLength + j < a.Length; j++)
                    { 
                        c[cIndex++] = a[i * seriesLength + j];
                        equalyties++;
                    }
                }
            }

            a = TwoInOneMerge(a, b, c, seriesLength);

            seriesLength *= 2;
            if (seriesLength < a.Length)
                a = TwoPhaseMergeSorting(a, seriesLength);

            return a;
        }

        public int[] TwoInOneMerge(int[] a, int[] b, int[] c, int seriesLength)
        {
            int bSeriesCount = (int)Math.Ceiling(b.Length / (double)seriesLength);
            int cSeriesCount = (int)Math.Ceiling(c.Length / (double)seriesLength);

            int i = 0, j = 0;
            int aIndex = 0;
            for (int k = 0; k < Math.Max(bSeriesCount, cSeriesCount); k++)
            {
                int bEnd = Math.Min(i + seriesLength, b.Length);
                int cEnd = Math.Min(j + seriesLength, c.Length);
                Merge(ref i, ref j, bEnd, cEnd, b, c, a, ref aIndex);
            }
            return a;
        }

        public int[] OnePhaseMergeSorting(int[] a, int seriesLength)
        {
            int seriesCount = (int)Math.Ceiling(a.Length / (double)seriesLength);

            int[] b = new int[a.Length];
            int[] c = new int[a.Length];

            int bIndex = 0, cIndex = 0;

            for (int i = 0; i < seriesCount; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < seriesLength && i * seriesLength + j < a.Length; j++)
                    { 
                        b[bIndex++] = a[i * seriesLength + j];
                        equalyties++;
                    }
                }
                else
                {
                    for (int j = 0; j < seriesLength && i * seriesLength + j < a.Length; j++)
                    { 
                        c[cIndex++] = a[i * seriesLength + j];
                        equalyties++;
                    }
                }
            }

            int[] d = new int[a.Length];
            int[] e = new int[a.Length];

            int dIndex = bIndex, eIndex = cIndex;
            int k = 0;
            while (seriesLength < a.Length)
            {
                if (k % 2 == 0)
                {
                    TwoInTwoMerge(b, c, d, e, bIndex, cIndex, ref dIndex, ref eIndex, seriesLength);
                }
                else
                {
                    TwoInTwoMerge(d, e, b, c, dIndex, eIndex, ref bIndex, ref cIndex, seriesLength);
                }
                k++;
                seriesLength *= 2;
            }
            if (k % 2 == 1)
                return d;

            return b;
        }
        public void TwoInTwoMerge(in int[] b, in int[] c, int[] d, int[] e, int bLength, int cLength,
            ref int dLength, ref int eLength, int seriesLength)
        {
            int bSeriesCount = (int)Math.Ceiling(bLength / (double)seriesLength);
            int cSeriesCount = (int)Math.Ceiling(cLength / (double)seriesLength);

            int i = 0; int j = 0; int dIndex = 0; int eIndex = 0;
            for (int k = 0; k < Math.Max(bSeriesCount, cSeriesCount); k++)
            {
                int bEnd = Math.Min(i + seriesLength, bLength);
                int cEnd = Math.Min(j + seriesLength, cLength);
                if (k % 2 == 0)
                {
                    Merge(ref i, ref j, bEnd, cEnd, b, c, d, ref dIndex);
                }
                else
                {
                    Merge(ref i, ref j, bEnd, cEnd, b, c, e, ref eIndex);
                }
            }
            dLength = dIndex;
            eLength = eIndex;
        }

        public int[] TwoPhaseEstMergeSorting(int[] a)
        {
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];

            int bLength = 0, cLength = 0, aIndex = 0;
            int nextAIndex = aIndex + 1;
            while (nextAIndex < a.Length)
            {
                while (nextAIndex < a.Length && a[aIndex] <= a[nextAIndex])
                {
                    b[bLength++] = a[aIndex++];
                    nextAIndex++;
                    equalyties++;
                }
                if (aIndex < a.Length)
                {
                    b[bLength++] = a[aIndex++];
                    nextAIndex++;
                    comparisons++;
                    equalyties++;
                }
                while (nextAIndex < a.Length && a[aIndex] <= a[nextAIndex])
                {
                    c[cLength++] = a[aIndex++];
                    nextAIndex++;
                    equalyties++;
                }
                if (aIndex < a.Length)
                {
                    c[cLength++] = a[aIndex++];
                    nextAIndex++;
                    comparisons++;
                    equalyties++;
                }
            }
            if (cLength > 0)
            {
                int i = 0, j = 0, z = 0;
                int bInd = 0, cInd = 0;
                int bLen = bLength;
                int cLen = cLength;

                while (bInd < bLen && cInd < cLen)
                {
                    int bSeriesStart = bInd;
                    while (bInd + 1 < bLen && b[bInd] <= b[bInd + 1])
                    {
                        bInd++;
                        equalyties++;
                    }
                    int bSeriesEnd = bInd;

                    int cSeriesStart = cInd;
                    while (cInd + 1 < cLen && c[cInd] <= c[cInd + 1])
                    {
                        cInd++;
                        equalyties++;
                    }
                    int cSeriesEnd = cInd;

                    i = bSeriesStart;
                    j = cSeriesStart;
                    while (i <= bSeriesEnd && j <= cSeriesEnd)
                    {
                        if (b[i] <= c[j])
                        { 
                            a[z++] = b[i++];
                            comparisons++;
                        }
                        else
                        { 
                            a[z++] = c[j++]; 
                            comparisons++;
                        }
                        equalyties++;
                    }

                    while (i <= bSeriesEnd)
                    { 
                        a[z++] = b[i++];
                        equalyties++;
                    }
                    while (j <= cSeriesEnd)
                    { 
                        a[z++] = c[j++];
                        equalyties++;
                    }

                    bInd++;
                    cInd++;
                }

                while (bInd < bLen)
                { 
                    a[z++] = b[bInd++];
                    equalyties++;
                }

                while (cInd < cLen)
                { 
                    a[z++] = c[cInd++];
                    equalyties++;
                }

                return TwoPhaseEstMergeSorting(a);
            }
            return b;
        }

        public int[] OnePhaseEstMergeSorting(int[] a)
        {
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];

            int bLength = 0, cLength = 0, aIndex = 0;
            int toB = 0;

            while (aIndex < a.Length)
            {
                int start = aIndex;

                while (aIndex + 1 < a.Length && a[aIndex] <= a[aIndex + 1])
                {
                    aIndex++;
                }
                if (toB %2 == 0)
                {
                    for (int j = start; j <= aIndex; j++)
                    {
                        b[bLength++] = a[j];
                        equalyties++;
                    }
                    comparisons++;
                }
                else
                {
                    for (int j = start; j <= aIndex; j++)
                    {
                        c[cLength++] = a[j];
                        equalyties++;
                    }
                }
                aIndex++;
                toB++;
            }

            int[] d = new int[a.Length];
            int[] e = new int[a.Length];
            int dLength = 0, eLength = 0;

            int series = 0;
            while (cLength > 0)
            {
                int i, j;
                int bInd = 0, cInd = 0;
                int dInd, eInd;
                int bSeriesStart, bSeriesEnd;
                int cSeriesStart, cSeriesEnd;
                int dSeriesStart, dSeriesEnd;
                int eSeriesStart, eSeriesEnd;

                if (series % 2 == 0)
                {
                    int deIndi = 0;
                    int kd = 0, ke = 0;
                    dLength = 0; eLength = 0;

                    while (bInd < bLength && cInd < cLength)
                    {
                        bSeriesStart = bInd;
                        bSeriesEnd = bSeriesStart;
                        while (bSeriesEnd + 1 < bLength && b[bSeriesEnd] <= b[bSeriesEnd + 1])
                        {
                            bSeriesEnd++;
                        }

                        cSeriesStart = cInd;
                        cSeriesEnd = cSeriesStart;
                        while (cSeriesEnd + 1 < cLength && c[cSeriesEnd] <= c[cSeriesEnd + 1])
                        {
                            cSeriesEnd++;
                        }

                        i = bSeriesStart;
                        j = cSeriesStart;

                        if (deIndi % 2 == 0)
                        {
                            while (i <= bSeriesEnd && j <= cSeriesEnd)
                            {
                                if (b[i] <= c[j])
                                    d[kd++] = b[i++];
                                else
                                    d[kd++] = c[j++];
                                comparisons++;
                                equalyties++;
                            }

                            while (i <= bSeriesEnd)
                            {
                                d[kd++] = b[i++];
                                equalyties++;
                            }
                            while (j <= cSeriesEnd)
                            { 
                                d[kd++] = c[j++];
                                equalyties++;
                            }

                            dLength = kd;
                        }
                        else
                        {
                            while (i <= bSeriesEnd && j <= cSeriesEnd)
                            {
                                if (b[i] <= c[j])
                                    e[ke++] = b[i++];
                                else
                                    e[ke++] = c[j++];
                                equalyties++;
                                comparisons++;
                            }

                            while (i <= bSeriesEnd)
                            { 
                                e[ke++] = b[i++];
                                equalyties++;
                            }
                            while (j <= cSeriesEnd)
                            { 
                                e[ke++] = c[j++]; 
                                equalyties++;
                            }

                            eLength = ke;
                        }

                        bInd = bSeriesEnd + 1;
                        cInd = cSeriesEnd + 1;
                        deIndi++;
                    }
                    while (bInd < bLength)
                    {
                        if (deIndi % 2 == 0)
                            d[dLength++] = b[bInd++];
                        else
                            e[eLength++] = b[bInd++];
                        comparisons++;
                        equalyties++;
                    }

                    while (cInd < cLength)
                    {
                        if (deIndi % 2 == 0)
                            d[dLength++] = c[cInd++];
                        else
                            e[eLength++] = c[cInd++];
                        comparisons++;
                        equalyties++;
                    }
                    if (eLength == 0)
                        return d;
                }

                else
                {
                    int bcIndi = 0;
                    int kb = 0, kc = 0;
                    bLength = 0; cLength = 0;
                    dInd = 0; eInd = 0;

                    while (dInd < dLength && eInd < eLength)
                    {
                        dSeriesStart = dInd;
                        dSeriesEnd = dSeriesStart;
                        while (dSeriesEnd + 1 < dLength && d[dSeriesEnd] <= d[dSeriesEnd + 1])
                        {
                            dSeriesEnd++;
                        }

                        eSeriesStart = eInd;
                        eSeriesEnd = eSeriesStart;
                        while (eSeriesEnd + 1 < eLength && e[eSeriesEnd] <= e[eSeriesEnd + 1])
                        {
                            eSeriesEnd++;
                        }

                        i = dSeriesStart;
                        j = eSeriesStart;

                        if (bcIndi % 2 == 0)
                        {
                            while (i <= dSeriesEnd && j <= eSeriesEnd)
                            {
                                if (d[i] <= e[j])
                                    b[kb++] = d[i++];
                                else
                                    b[kb++] = e[j++];
                                equalyties++;
                                comparisons++;
                            }
                            while (i <= dSeriesEnd)
                            { 
                                b[kb++] = d[i++];
                                equalyties++;
                            }
                            while (j <= eSeriesEnd)
                            { 
                                b[kb++] = e[j++];
                                equalyties++;
                            }
                            bLength = kb;
                        }
                        else
                        {
                            while (i <= dSeriesEnd && j <= eSeriesEnd)
                            {
                                if (d[i] <= e[j])
                                    c[kc++] = d[i++];
                                else
                                    c[kc++] = e[j++];
                                equalyties++;
                                comparisons++;
                            }
                            while (i <= dSeriesEnd)
                            { 
                                c[kc++] = d[i++];
                                equalyties++;
                            }
                            while (j <= eSeriesEnd)
                            { 
                                c[kc++] = e[j++];
                                equalyties++;
                            }
                            cLength = kc;
                        }

                        dInd = dSeriesEnd + 1;
                        eInd = eSeriesEnd + 1;
                        bcIndi++;
                    }

                    while (dInd < dLength)
                    {
                        if (bcIndi % 2 == 0)
                            b[bLength++] = d[dInd++];
                        else
                            c[cLength++] = d[dInd++];
                        equalyties++;
                        comparisons++;
                    }

                    while (eInd < eLength)
                    {
                        if (bcIndi % 2 == 0)
                            b[bLength++] = e[eInd++];
                        else
                            c[cLength++] = e[eInd++];
                        equalyties++;
                        comparisons++;
                    }
                }
                series++;
            }
            return b;
        }
        public void Merge(ref int i, ref int j, int bEnd, int cEnd, int[] b, int[] c, int[] d, ref int dIndex)
        {
            while (i < bEnd && j < cEnd)
            {
                if (b[i] < c[j])
                {
                    d[dIndex++] = b[i];
                    equalyties++;
                    comparisons++;
                    i++;
                }
                else
                {
                    d[dIndex++] = c[j];
                    equalyties++;
                    comparisons++;
                    j++;
                }
            }
            while (i < bEnd)
            {
                d[dIndex++] = b[i];
                equalyties++;
                i++;
            }
            while (j < cEnd)
            {
                d[dIndex++] = c[j];
                equalyties++;
                j++;
            }
        }

        private bool IsSorted(int[] m)
        {
            for (int i = 0; i < m.Length - 1; i++)
            {
                if (m[i + 1] < m[i])
                    return false;
            }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
