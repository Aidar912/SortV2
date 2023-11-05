using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SortV2
{
    public partial class Comparison : Form


    {

        private int[] arrayToSort;
        public long maxTime;




        public Comparison()
        {
            InitializeComponent();
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


        private void TIme_Click(object sender, EventArgs e)
        {
            timePanel.Visible = true;
            infoPanel.Visible = false;
            SourceArray.Visible = true;
            RandomArray.Visible = true;
            SaveArray.Visible = true;
            label4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timePanel.Visible = false;
            infoPanel.Visible = true;
            SourceArray.Visible = false;
            RandomArray.Visible = false;
            SaveArray.Visible = false;
            label4.Visible = false;
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

            IntroSort introSort = new IntroSort();
            StrandSort strand = new StrandSort();
            ShellSort shellSort = new ShellSort();

            introSort.arrayToSort = arrayToSort;
            strand.arrayToSort = arrayToSort.ToList();
            shellSort.arrayToSort = arrayToSort;

            introSort.Sort();
            shellSort.ShellSortFunc();
            strand.StrandSortFunc(arrayToSort.ToList());

            maxTime = 0;
            long[] ArrayTime = { introSort.elapsedMilliseconds, shellSort.elapsedMilliseconds, strand.elapsedMilliseconds };

            foreach (var item in ArrayTime)
            {
                if (item > maxTime)
                {
                    maxTime = item;
                }
            }


            UpdateProgressBar(introSortTime, introSort.elapsedMilliseconds);
            UpdateProgressBar(StrandSortTime, strand.elapsedMilliseconds);
            UpdateProgressBar(ShellSortTime, shellSort.elapsedMilliseconds);

            long introSortTimeText = introSort.elapsedMilliseconds;
            long strandSortTime = strand.elapsedMilliseconds;
            long shellSortTime = shellSort.elapsedMilliseconds;

            // Находим минимальное, максимальное и среднее время
            long minTimeText = Math.Min(Math.Min(introSortTimeText, strandSortTime), shellSortTime);
            long maxTimeText = Math.Max(Math.Max(introSortTimeText, strandSortTime), shellSortTime);
            long averageTime = (introSortTimeText + strandSortTime + shellSortTime) / 3;

            // Устанавливаем цвет текста в зависимости от времени
            intTIme.ForeColor = (introSortTimeText == maxTimeText) ? Color.Red : (introSortTimeText == minTimeText) ? Color.Green : Color.Yellow;
            StrandTimeText.ForeColor = (strandSortTime == maxTimeText) ? Color.Red : (strandSortTime == minTimeText) ? Color.Green : Color.Yellow;
            ShellTimeText.ForeColor = (shellSortTime == maxTimeText) ? Color.Red : (shellSortTime == minTimeText) ? Color.Green : Color.Yellow;

            intTIme.Text = $" - {introSortTimeText} мс";
            StrandTimeText.Text = $" - {strandSortTime} мс";
            ShellTimeText.Text = $" - {shellSortTime} мс";




        }


        private void UpdateProgressBar(ProgressBar progressBar, long elapsedTime)
        {
            long minValue = 0;
            long maxValue = maxTime;

            // Вычислите прогресс в процентах (0-100)
            double progress = (double)(elapsedTime - minValue) / (maxValue - minValue) * 100;

            if (progress < minValue)
            {
                progressBar.Value = (int)minValue;
            }
            else if (progress > maxValue)
            {
                progressBar.Value = (int)maxValue;

            }
            else
            {
                progressBar.Value = (int)progress;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
