using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Globalization;

namespace SortV2
{
    public partial class ShellSort : Form
    {
        public int[] arrayToSort;
        private Panel sortingPanel;
        private RichTextBox resultsTextBox;
        private Label time;
        public long elapsedMilliseconds;

        public ShellSort()
        {
            InitializeComponent();
            sortingPanel = this.ViewPanel;
            resultsTextBox = this.iterMas;
            time = this.TimeShell;

        }






        //������ �������� ���������

        private void desc_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = false;
            descPanel.Visible = true;
            blockPanel.Visible = false;
        }

        //������ ���� �����

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


        public void ShellSortFunc()
        {
            int n = arrayToSort.Length;
            int gap = n / 2;

            List<int[]> iterations = new List<int[]>();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); // ��������� ������� �������

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arrayToSort[i];
                    int j = i;

                    while (j >= gap && arrayToSort[j - gap] > temp)
                    {
                        arrayToSort[j] = arrayToSort[j - gap];
                        j -= gap;
                    }

                    arrayToSort[j] = temp;
                    int[] currentIteration = new int[arrayToSort.Length];
                    Array.Copy(arrayToSort, currentIteration, arrayToSort.Length);
                    iterations.Add(currentIteration);
                    DrawArray(i);
                    Thread.Sleep(100);
                }

                gap /= 2;
            }

            stopwatch.Stop();
            for (int i = 0; i < iterations.Count; i++)
            {
                resultsTextBox.AppendText($"�������� {i + 1}: ");
                for (int j = 0; j < iterations[i].Length; j++)
                {
                    resultsTextBox.AppendText(iterations[i][j] + " ");
                }
                resultsTextBox.AppendText("\n");
            }

            // ����� ���������� � �������������
            elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            time.Text = ($" - {elapsedMilliseconds} ��\n");

            ShowSortedArray();
        }

        private void ShowSortedArray()
        {
            string sortedArrayText = string.Join(" ", arrayToSort.Select(x => x.ToString()));
            ResultArray.Text = sortedArrayText;
        }


        private void DrawArray(int currentRectIndex)
        {
            Graphics g = sortingPanel.CreateGraphics();
            g.Clear(sortingPanel.BackColor);

            int rectWidth = 10;
            int xOffset = 10;
            int yOffset = sortingPanel.Height;

            int totalWidth = arrayToSort.Length * (rectWidth + xOffset);
            int startX = (sortingPanel.Width - totalWidth) / 2; // ������������ �� �����������

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int rectHeight = arrayToSort[i];
                Rectangle rect = new Rectangle(startX + i * (rectWidth + xOffset), yOffset - rectHeight, rectWidth, rectHeight);

                if (i == currentRectIndex)
                {
                    g.FillRectangle(Brushes.Red, rect); // ��������� �������� �������������� ������� ������
                }
                else
                {
                    g.FillRectangle(Brushes.Blue, rect); // ��������� �������������� ������ �����
                }
            }

            g.Dispose();
        }







        //����������

        private void sort_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = true;
            descPanel.Visible = false;
            blockPanel.Visible = false;



        }

        //��������

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
            ShellSortFunc();
        }

        private void back_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}