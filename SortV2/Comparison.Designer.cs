namespace SortV2
{
    partial class Comparison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparison));
            label4 = new Label();
            SaveArray = new Button();
            RandomArray = new Button();
            SourceArray = new TextBox();
            label1 = new Label();
            timePanel = new Panel();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            ShellSortTime = new ProgressBar();
            StrandSortTime = new ProgressBar();
            introSortTime = new ProgressBar();
            TIme = new Button();
            button1 = new Button();
            infoPanel = new Panel();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            intTIme = new Label();
            StrandTimeText = new Label();
            ShellTimeText = new Label();
            timePanel.SuspendLayout();
            infoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(145, 82);
            label4.Name = "label4";
            label4.Size = new Size(217, 30);
            label4.TabIndex = 34;
            label4.Text = "Исходный массив";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // SaveArray
            // 
            SaveArray.Location = new Point(1046, 129);
            SaveArray.Margin = new Padding(3, 4, 3, 4);
            SaveArray.Name = "SaveArray";
            SaveArray.Size = new Size(103, 31);
            SaveArray.TabIndex = 32;
            SaveArray.Text = "Сохранить";
            SaveArray.UseVisualStyleBackColor = true;
            SaveArray.Click += SaveArray_Click;
            // 
            // RandomArray
            // 
            RandomArray.Location = new Point(953, 129);
            RandomArray.Margin = new Padding(3, 4, 3, 4);
            RandomArray.Name = "RandomArray";
            RandomArray.Size = new Size(86, 31);
            RandomArray.TabIndex = 31;
            RandomArray.Text = "Рандом";
            RandomArray.UseVisualStyleBackColor = true;
            RandomArray.Click += RandomArray_Click;
            // 
            // SourceArray
            // 
            SourceArray.Location = new Point(143, 130);
            SourceArray.Margin = new Padding(3, 4, 3, 4);
            SourceArray.Name = "SourceArray";
            SourceArray.Size = new Size(771, 27);
            SourceArray.TabIndex = 30;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(373, 21);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 29;
            label1.Text = "Сравнение алгоритмов";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // timePanel
            // 
            timePanel.Controls.Add(ShellTimeText);
            timePanel.Controls.Add(StrandTimeText);
            timePanel.Controls.Add(intTIme);
            timePanel.Controls.Add(label6);
            timePanel.Controls.Add(label3);
            timePanel.Controls.Add(label2);
            timePanel.Controls.Add(ShellSortTime);
            timePanel.Controls.Add(StrandSortTime);
            timePanel.Controls.Add(introSortTime);
            timePanel.Location = new Point(277, 267);
            timePanel.Name = "timePanel";
            timePanel.Size = new Size(848, 494);
            timePanel.TabIndex = 36;
            timePanel.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(126, 356);
            label6.Name = "label6";
            label6.Size = new Size(295, 37);
            label6.TabIndex = 43;
            label6.Text = "Сортировка Шелла";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 219);
            label3.Name = "label3";
            label3.Size = new Size(366, 37);
            label3.TabIndex = 42;
            label3.Text = "Нитевидная сортировка";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 57);
            label2.Name = "label2";
            label2.Size = new Size(350, 37);
            label2.TabIndex = 38;
            label2.Text = "Гибридная сортировка";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ShellSortTime
            // 
            ShellSortTime.Location = new Point(126, 409);
            ShellSortTime.Name = "ShellSortTime";
            ShellSortTime.Size = new Size(586, 29);
            ShellSortTime.TabIndex = 41;
            // 
            // StrandSortTime
            // 
            StrandSortTime.Location = new Point(126, 269);
            StrandSortTime.Name = "StrandSortTime";
            StrandSortTime.Size = new Size(586, 29);
            StrandSortTime.TabIndex = 40;
            // 
            // introSortTime
            // 
            introSortTime.Location = new Point(126, 113);
            introSortTime.Name = "introSortTime";
            introSortTime.Size = new Size(586, 29);
            introSortTime.TabIndex = 39;
            // 
            // TIme
            // 
            TIme.Location = new Point(29, 295);
            TIme.Name = "TIme";
            TIme.Size = new Size(128, 66);
            TIme.TabIndex = 37;
            TIme.Text = "Сравнение времени";
            TIme.UseVisualStyleBackColor = true;
            TIme.Click += TIme_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 425);
            button1.Name = "button1";
            button1.Size = new Size(128, 66);
            button1.TabIndex = 38;
            button1.Text = "Описание сортировок";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(richTextBox3);
            infoPanel.Controls.Add(richTextBox2);
            infoPanel.Controls.Add(richTextBox1);
            infoPanel.Controls.Add(label7);
            infoPanel.Controls.Add(label8);
            infoPanel.Controls.Add(label9);
            infoPanel.Location = new Point(178, 36);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1024, 746);
            infoPanel.TabIndex = 44;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(45, 561);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(938, 175);
            richTextBox3.TabIndex = 46;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(45, 328);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(938, 175);
            richTextBox2.TabIndex = 45;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(45, 110);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(938, 175);
            richTextBox1.TabIndex = 44;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 521);
            label7.Name = "label7";
            label7.Size = new Size(295, 37);
            label7.TabIndex = 43;
            label7.Text = "Сортировка Шелла";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(45, 288);
            label8.Name = "label8";
            label8.Size = new Size(366, 37);
            label8.TabIndex = 42;
            label8.Text = "Нитевидная сортировка";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(45, 53);
            label9.Name = "label9";
            label9.Size = new Size(350, 37);
            label9.TabIndex = 38;
            label9.Text = "Гибридная сортировка";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(29, 528);
            button2.Name = "button2";
            button2.Size = new Size(128, 66);
            button2.TabIndex = 45;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // intTIme
            // 
            intTIme.AutoSize = true;
            intTIme.ForeColor = SystemColors.ButtonFace;
            intTIme.Location = new Point(126, 158);
            intTIme.Name = "intTIme";
            intTIme.Size = new Size(0, 20);
            intTIme.TabIndex = 44;
            // 
            // StrandTimeText
            // 
            StrandTimeText.AutoSize = true;
            StrandTimeText.ForeColor = SystemColors.ButtonFace;
            StrandTimeText.Location = new Point(126, 307);
            StrandTimeText.Name = "StrandTimeText";
            StrandTimeText.Size = new Size(0, 20);
            StrandTimeText.TabIndex = 45;
            // 
            // ShellTimeText
            // 
            ShellTimeText.AutoSize = true;
            ShellTimeText.ForeColor = SystemColors.ButtonHighlight;
            ShellTimeText.Location = new Point(126, 452);
            ShellTimeText.Name = "ShellTimeText";
            ShellTimeText.Size = new Size(0, 20);
            ShellTimeText.TabIndex = 46;
            // 
            // Comparison
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1204, 794);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TIme);
            Controls.Add(label4);
            Controls.Add(SaveArray);
            Controls.Add(RandomArray);
            Controls.Add(SourceArray);
            Controls.Add(label1);
            Controls.Add(timePanel);
            Controls.Add(infoPanel);
            Name = "Comparison";
            Text = "Comparison";
            timePanel.ResumeLayout(false);
            timePanel.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button SaveArray;
        private Button RandomArray;
        private TextBox SourceArray;
        private Label label1;
        private Panel timePanel;
        private Label label6;
        private Label label3;
        private Label label2;
        private ProgressBar ShellSortTime;
        private ProgressBar StrandSortTime;
        private ProgressBar introSortTime;
        private Button TIme;
        private Button button1;
        private Panel infoPanel;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
        private Label ShellTimeText;
        private Label StrandTimeText;
        private Label intTIme;
    }
}