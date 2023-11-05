using System.Data;
using System.Diagnostics;

namespace SortV2
{
    public partial class StrandSort : Form

    {
        public List<int> arrayToSort;
        private Graphics g;
        private Panel sortingPanel;
        private RichTextBox resultsTextBox;
        private Label time;
        private List<int> rectangleHeights;
        List<int[]> iterations;
        private List<int> rectanglePositions;
        public long elapsedMilliseconds;
        private List<int> mergeIterationsList = new List<int>();
        private List<int> strandIterationsList = new List<int>();
        private List<int> strandSortMergeIterationsList = new List<int>();
        public StrandSort()
        {
            InitializeComponent();
            sortingPanel = this.ViewPanel;
            resultsTextBox = this.iterMas;
            time = this.TimeStrand;
            iterations = new List<int[]>();
        }

      

        public List<int> MergeList(List<int> a, List<int> b)
        {
            List<int> outList = new List<int>();
            int iterations = 0;

            while (a.Count > 0 && b.Count > 0)
            {
                iterations++;
                if (a[0] < b[0])
                {
                    outList.Add(a[0]);
                    a.RemoveAt(0);
                }
                else
                {
                    outList.Add(b[0]);
                    b.RemoveAt(0);
                }
            }

            outList.AddRange(a);
            outList.AddRange(b);

            mergeIterationsList.Add(iterations);

            return outList;
        }

        public List<int> Strand(List<int> a)
        {
            List<int> s = new List<int>();
            s.Add(a[0]);
            a.RemoveAt(0);
            int iterations = 0;

            int i = 0;

            while (i < a.Count)
            {
                iterations++;
                if (a[i] > s[s.Count - 1])
                {
                    s.Add(a[i]);
                    a.RemoveAt(i);
                }
                else
                {
                    i++;
                }
                DrawArray(i);
                Thread.Sleep(100);
            }

            strandIterationsList.Add(iterations);

            return s;
        }

        public List<int> StrandSortFunc(List<int> a)
        {
            List<int> outList = Strand(a);
            int mergeIterations = 0;

            while (a.Count > 0)
            {
                outList = MergeList(outList, Strand(a));
                mergeIterations++;
            }

            strandSortMergeIterationsList.Add(mergeIterations);

            return outList;
        }

        public void DisplayIterationsInRichTextBox(RichTextBox richTextBox)
        {
            richTextBox.Clear();

            for (int i = 0; i < mergeIterationsList.Count; i++)
            {
                richTextBox.AppendText($"MergeList Iteration {i + 1}: {mergeIterationsList[i]}\n");
            }

            for (int i = 0; i < strandIterationsList.Count; i++)
            {
                richTextBox.AppendText($"Strand Iteration {i + 1}: {strandIterationsList[i]}\n");
            }

            for (int i = 0; i < strandSortMergeIterationsList.Count; i++)
            {
                richTextBox.AppendText($"StrandSort Merge Iteration {i + 1}: {strandSortMergeIterationsList[i]}\n");
            }
        }


        //Кнопка описания алгоритма

        private void desc_Click(object sender, EventArgs e)
        {
            InfoPanel.Visible = false;
            ViewPanel.Visible = false;
            descPanel.Visible = true;
            blockPanel.Visible = false;
        }

        private void DrawArray(int currentRectIndex)
        {
            g = sortingPanel.CreateGraphics();
            g.Clear(sortingPanel.BackColor);

            int rectWidth = 10;
            int xOffset = 10;
            int yOffset = sortingPanel.Height;

            int totalWidth = arrayToSort.Count * (rectWidth + xOffset);
            int startX = (sortingPanel.Width - totalWidth) / 2;

            for (int i = 0; i < arrayToSort.Count; i++)
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
            arrayToSort = new List<int>(arraySize);


            for (int i = 0; i < arraySize; i++)
            {
                arrayToSort.Add(random.Next(10, 1000));
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

            arrayToSort = new List<int>(inputArray.Length);

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (int.TryParse(inputArray[i], out int value))
                {
                    arrayToSort.Add( value);
                }
                else
                {
                    arrayToSort.Add(1);
                }
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            arrayToSort = StrandSortFunc(arrayToSort);

            stopwatch.Stop();

            elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            time.Text = ($" - {elapsedMilliseconds} мс\n");
            ShowSortedArray();
            DisplayIterationsInRichTextBox(resultsTextBox);
            
        }


        private void back_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}

