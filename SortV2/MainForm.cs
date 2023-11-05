using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortV2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void IntroSort_Click(object sender, EventArgs e)
        {
            IntroSort introSort = new IntroSort();
            introSort.Show();
            this.Hide();
        }

        private void ShellSort_Click(object sender, EventArgs e)
        {
            ShellSort shellSort = new ShellSort();
            shellSort.Show();
            this.Hide();
        }

        private void StarndSort_Click(object sender, EventArgs e)
        {
            StrandSort strandSort = new StrandSort();
            strandSort.Show();
            this.Hide();
        }

        private void AllSort_Click(object sender, EventArgs e)
        {
            Comparison comparison = new Comparison();
            comparison.Show();
            this.Hide();

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
