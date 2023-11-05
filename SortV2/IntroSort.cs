using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SortV2
{
    public partial class IntroSort : Form
    {

        private Graphics g;
        public int[] arrayToSort;
        private Panel sortingPanel;
        private Label time;
        List<int[]> iterations;
        private RichTextBox resultsTextBox;
        public long elapsedMilliseconds;

        public IntroSort()
        {
            InitializeComponent();
            sortingPanel = this.ViewPanel;
            time = this.TimeShell;
            iterations = new List<int[]>();
            resultsTextBox = this.iterMas;
        }



        public void Sort()
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // Запускаем счетчик времени
            int maxDepth = (int)Math.Floor(2 * Math.Log(arrayToSort.Length) / Math.Log(2));
            IntroSortHelper(0, arrayToSort.Length - 1, maxDepth);
            stopwatch.Stop();
            elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            time.Text = ($" - {elapsedMilliseconds} мс\n");
            for (int i = 0; i < iterations.Count; i++)
            {
                resultsTextBox.AppendText($"Итерация {i + 1}: ");
                for (int j = 0; j < iterations[i].Length; j++)
                {
                    resultsTextBox.AppendText(iterations[i][j] + " ");
                }
                resultsTextBox.AppendText("\n");
            }

            ShowSortedArray();
        }

        private void IntroSortHelper(int left, int right, int depthLimit)
        {
            if (left < right)
            {
                if (depthLimit == 0)
                {
                    // If the depth limit is reached, switch to Heap Sort
                    HeapSort(left, right);
                }
                else
                {
                    int pivot = Partition(left, right);
                    IntroSortHelper(left, pivot, depthLimit - 1);
                    IntroSortHelper(pivot + 1, right, depthLimit - 1);
                }
            }
        }

        private int Partition(int left, int right)
        {
            int pivot = arrayToSort[left];
            int i = left - 1;
            int j = right + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (arrayToSort[i] < pivot);

                do
                {
                    j--;
                } while (arrayToSort[j] > pivot);

                if (i >= j)
                    return j;

                Swap(i, j);
                DrawArray(i);
                Thread.Sleep(100);
                iterations.Add((int[])arrayToSort.Clone());
            }
        }

        private void HeapSort(int left, int right)
        {
            for (int i = (right - left) / 2; i >= 0; i--)
                Heapify(left, right, i);

            for (int i = right; i > left; i--)
            {
                Swap(left, i);
                Heapify(left, i - 1, 0);
            }
        }

        private void Heapify(int left, int right, int i)
        {
            int largest = i;
            int leftChild = 2 * i + 1;
            int rightChild = 2 * i + 2;

            if (leftChild <= right && arrayToSort[leftChild] > arrayToSort[largest])
                largest = leftChild;

            if (rightChild <= right && arrayToSort[rightChild] > arrayToSort[largest])
                largest = rightChild;

            if (largest != i)
            {
                Swap(i, largest);
                Heapify(left, right, largest);
            }
        }

        private void Swap(int i, int j)
        {
            int temp = arrayToSort[i];
            arrayToSort[i] = arrayToSort[j];
            arrayToSort[j] = temp;
        }

        private void DrawArray(int currentRectIndex)
        {
            g = sortingPanel.CreateGraphics();
            g.Clear(sortingPanel.BackColor);

            int rectWidth = 10;
            int xOffset = 10;
            int yOffset = sortingPanel.Height;

            int totalWidth = arrayToSort.Length * (rectWidth + xOffset);
            int startX = (sortingPanel.Width - totalWidth) / 2;

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int rectHeight = arrayToSort[i];
                Rectangle rect = new Rectangle(startX + i * (rectWidth + xOffset), yOffset - rectHeight, rectWidth, rectHeight);

                if (i == currentRectIndex)
                {
                    g.FillRectangle(Brushes.Red, rect);
                }
                else
                {
                    g.FillRectangle(Brushes.Blue, rect);
                }
            }

            g.Dispose();
        }


        //Кнопка описания алгоритма

        private void desc_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = false;
            descPanel.Visible = true;
            blockPanel.Visible = false;
        }

        //Кнопка блок схемы

        private void block_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = false;
            descPanel.Visible = false;
            blockPanel.Visible = true;
        }

        private void InitializeArrayToSort()
        {
            Random random = new Random();
            int arraySize = random.Next(10, 40);
            arrayToSort = new int[arraySize];


            for (int i = 0; i < arraySize; i++)
            {
                arrayToSort[i] = random.Next(10, 1000);
            }
        }





        private void ShowSortedArray()
        {
            string sortedArrayText = string.Join(" ", arrayToSort.Select(x => x.ToString()));
            ResultArray.Text = sortedArrayText;
        }



        //Сортировка

        private void sort_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = true;
            descPanel.Visible = false;
            blockPanel.Visible = false;




        }

        //Итерации

        private void iter_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = true;
            ViewPanel.Visible = false;
            descPanel.Visible = false;
            blockPanel.Visible = false;
        }

        private void RandomArray_Click(object sender, EventArgs e)
        {
            InitializeArrayToSort();
            string arrayText = string.Join(" ", arrayToSort.Select(x => x.ToString()));
            SourceArray.Text = arrayText;
        }

        private void SaveArray_Click(object sender, EventArgs e)
        {

            string inputText = SourceArray.Text;
            string[] inputArray = inputText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            arrayToSort = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int value))
                {
                    arrayToSort[i] = value;
                }
                else
                {
                    arrayToSort[i] = 1;
                }
            }

            Sort();



        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
