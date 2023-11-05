namespace SortV2
{
    partial class IntroSort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroSort));
            back = new Button();
            descPanel = new Panel();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            ResultArray = new TextBox();
            SaveArray = new Button();
            RandomArray = new Button();
            SourceArray = new TextBox();
            iter = new Button();
            sort = new Button();
            block = new Button();
            desc = new Button();
            label1 = new Label();
            blockPanel = new Panel();
            ViewPanel = new Panel();
            label6 = new Label();
            InfoPanel = new Panel();
            TimeShell = new Label();
            label3 = new Label();
            label2 = new Label();
            iterMas = new RichTextBox();
            descPanel.SuspendLayout();
            ViewPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // back
            // 
            back.Location = new Point(31, 767);
            back.Name = "back";
            back.Size = new Size(136, 57);
            back.TabIndex = 29;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // descPanel
            // 
            descPanel.Controls.Add(richTextBox1);
            descPanel.Controls.Add(label7);
            descPanel.Location = new Point(195, 332);
            descPanel.Name = "descPanel";
            descPanel.Size = new Size(769, 635);
            descPanel.TabIndex = 20;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(27, 85);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(671, 447);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(250, 5);
            label7.Name = "label7";
            label7.Size = new Size(333, 37);
            label7.TabIndex = 5;
            label7.Text = "Описание сортировки";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(195, 207);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 28;
            label5.Text = "Результат";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(195, 117);
            label4.Name = "label4";
            label4.Size = new Size(217, 30);
            label4.TabIndex = 27;
            label4.Text = "Исходный массив";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // ResultArray
            // 
            ResultArray.Location = new Point(193, 251);
            ResultArray.Margin = new Padding(3, 4, 3, 4);
            ResultArray.Name = "ResultArray";
            ResultArray.Size = new Size(771, 27);
            ResultArray.TabIndex = 26;
            // 
            // SaveArray
            // 
            SaveArray.Location = new Point(1096, 164);
            SaveArray.Margin = new Padding(3, 4, 3, 4);
            SaveArray.Name = "SaveArray";
            SaveArray.Size = new Size(102, 31);
            SaveArray.TabIndex = 25;
            SaveArray.Text = "Сохранить";
            SaveArray.UseVisualStyleBackColor = true;
            SaveArray.Click += SaveArray_Click;
            // 
            // RandomArray
            // 
            RandomArray.Location = new Point(1003, 164);
            RandomArray.Margin = new Padding(3, 4, 3, 4);
            RandomArray.Name = "RandomArray";
            RandomArray.Size = new Size(86, 31);
            RandomArray.TabIndex = 24;
            RandomArray.Text = "Рандом";
            RandomArray.UseVisualStyleBackColor = true;
            RandomArray.Click += RandomArray_Click;
            // 
            // SourceArray
            // 
            SourceArray.Location = new Point(193, 165);
            SourceArray.Margin = new Padding(3, 4, 3, 4);
            SourceArray.Name = "SourceArray";
            SourceArray.Size = new Size(771, 27);
            SourceArray.TabIndex = 22;
            // 
            // iter
            // 
            iter.Location = new Point(31, 661);
            iter.Name = "iter";
            iter.Size = new Size(136, 57);
            iter.TabIndex = 19;
            iter.Text = "Информация";
            iter.UseVisualStyleBackColor = true;
            iter.Click += iter_Click;
            // 
            // sort
            // 
            sort.Location = new Point(31, 560);
            sort.Name = "sort";
            sort.Size = new Size(136, 57);
            sort.TabIndex = 18;
            sort.Text = "Сортировка";
            sort.UseVisualStyleBackColor = true;
            sort.Click += sort_Click;
            // 
            // block
            // 
            block.Location = new Point(31, 471);
            block.Name = "block";
            block.Size = new Size(136, 57);
            block.TabIndex = 17;
            block.Text = "Блок схема";
            block.UseVisualStyleBackColor = true;
            block.Click += block_Click;
            // 
            // desc
            // 
            desc.Location = new Point(31, 379);
            desc.Name = "desc";
            desc.Size = new Size(136, 57);
            desc.TabIndex = 16;
            desc.Text = "Описание";
            desc.UseVisualStyleBackColor = true;
            desc.Click += desc_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(306, 53);
            label1.Name = "label1";
            label1.Size = new Size(350, 37);
            label1.TabIndex = 14;
            label1.Text = "Гибридная сортировка";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // blockPanel
            // 
            blockPanel.BackgroundImage = (Image)resources.GetObject("blockPanel.BackgroundImage");
            blockPanel.ForeColor = Color.DarkMagenta;
            blockPanel.Location = new Point(193, 389);
            blockPanel.Margin = new Padding(3, 4, 3, 4);
            blockPanel.MaximumSize = new Size(635, 435);
            blockPanel.MinimumSize = new Size(635, 435);
            blockPanel.Name = "blockPanel";
            blockPanel.Size = new Size(635, 435);
            blockPanel.TabIndex = 23;
            blockPanel.Visible = false;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(label6);
            ViewPanel.Location = new Point(195, 335);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(769, 635);
            ViewPanel.TabIndex = 15;
            ViewPanel.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(250, 5);
            label6.Name = "label6";
            label6.Size = new Size(340, 37);
            label6.TabIndex = 5;
            label6.Text = "Анимация сортировки";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(TimeShell);
            InfoPanel.Controls.Add(label3);
            InfoPanel.Controls.Add(label2);
            InfoPanel.Controls.Add(iterMas);
            InfoPanel.Location = new Point(195, 340);
            InfoPanel.Margin = new Padding(3, 4, 3, 4);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(769, 635);
            InfoPanel.TabIndex = 21;
            InfoPanel.Visible = false;
            // 
            // TimeShell
            // 
            TimeShell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TimeShell.AutoSize = true;
            TimeShell.BackColor = Color.Transparent;
            TimeShell.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            TimeShell.ForeColor = Color.White;
            TimeShell.Location = new Point(323, 280);
            TimeShell.Name = "TimeShell";
            TimeShell.Size = new Size(0, 37);
            TimeShell.TabIndex = 4;
            TimeShell.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 280);
            label3.Name = "label3";
            label3.Size = new Size(287, 37);
            label3.TabIndex = 3;
            label3.Text = "Время сортировки";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 5);
            label2.Name = "label2";
            label2.Size = new Size(159, 37);
            label2.TabIndex = 1;
            label2.Text = "Итерации";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // iterMas
            // 
            iterMas.Location = new Point(27, 49);
            iterMas.Margin = new Padding(3, 4, 3, 4);
            iterMas.Name = "iterMas";
            iterMas.Size = new Size(724, 187);
            iterMas.TabIndex = 0;
            iterMas.Text = "";
            // 
            // IntroSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1210, 1017);
            Controls.Add(back);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(ResultArray);
            Controls.Add(SaveArray);
            Controls.Add(RandomArray);
            Controls.Add(SourceArray);
            Controls.Add(iter);
            Controls.Add(sort);
            Controls.Add(block);
            Controls.Add(desc);
            Controls.Add(label1);
            Controls.Add(descPanel);
            Controls.Add(blockPanel);
            Controls.Add(ViewPanel);
            Controls.Add(InfoPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1228, 1064);
            MinimumSize = new Size(1228, 1018);
            Name = "IntroSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гибридная сортировка";
            descPanel.ResumeLayout(false);
            descPanel.PerformLayout();
            ViewPanel.ResumeLayout(false);
            ViewPanel.PerformLayout();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back;
        private Panel descPanel;
        private RichTextBox richTextBox1;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox ResultArray;
        private Button SaveArray;
        private Button RandomArray;
        private TextBox SourceArray;
        private Button iter;
        private Button sort;
        private Button block;
        private Button desc;
        private Label label1;
        private Panel blockPanel;
        private Panel ViewPanel;
        private Label label6;
        private Panel InfoPanel;
        private Label TimeShell;
        private Label label3;
        private Label label2;
        private RichTextBox iterMas;
    }
}