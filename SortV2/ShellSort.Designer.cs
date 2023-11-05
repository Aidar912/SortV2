namespace SortV2
{
    partial class ShellSort
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellSort));
            label1 = new Label();
            ViewPanel = new Panel();
            label6 = new Label();
            desc = new Button();
            block = new Button();
            sort = new Button();
            iter = new Button();
            InfoPanel = new Panel();
            TimeShell = new Label();
            label3 = new Label();
            label2 = new Label();
            iterMas = new RichTextBox();
            SourceArray = new TextBox();
            RandomArray = new Button();
            SaveArray = new Button();
            ResultArray = new TextBox();
            label4 = new Label();
            label5 = new Label();
            blockPanel = new Panel();
            descPanel = new Panel();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            back = new Button();
            ViewPanel.SuspendLayout();
            InfoPanel.SuspendLayout();
            descPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(311, 21);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 0;
            label1.Text = "Сортировка Шелла";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(label6);
            ViewPanel.Location = new Point(200, 303);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(769, 635);
            ViewPanel.TabIndex = 1;
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
            // desc
            // 
            desc.Location = new Point(35, 347);
            desc.Name = "desc";
            desc.Size = new Size(136, 57);
            desc.TabIndex = 2;
            desc.Text = "Описание";
            desc.UseVisualStyleBackColor = true;
            desc.Click += desc_Click;
            // 
            // block
            // 
            block.Location = new Point(35, 439);
            block.Name = "block";
            block.Size = new Size(136, 57);
            block.TabIndex = 3;
            block.Text = "Блок схема";
            block.UseVisualStyleBackColor = true;
            block.Click += block_Click;
            // 
            // sort
            // 
            sort.Location = new Point(35, 528);
            sort.Name = "sort";
            sort.Size = new Size(136, 57);
            sort.TabIndex = 4;
            sort.Text = "Сортировка";
            sort.UseVisualStyleBackColor = true;
            sort.Click += sort_Click;
            // 
            // iter
            // 
            iter.Location = new Point(35, 629);
            iter.Name = "iter";
            iter.Size = new Size(136, 57);
            iter.TabIndex = 5;
            iter.Text = "Информация";
            iter.UseVisualStyleBackColor = true;
            iter.Click += iter_Click;
            // 
            // InfoPanel
            // 
            InfoPanel.Controls.Add(TimeShell);
            InfoPanel.Controls.Add(label3);
            InfoPanel.Controls.Add(label2);
            InfoPanel.Controls.Add(iterMas);
            InfoPanel.Location = new Point(200, 308);
            InfoPanel.Margin = new Padding(3, 4, 3, 4);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(769, 635);
            InfoPanel.TabIndex = 6;
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
            // SourceArray
            // 
            SourceArray.Location = new Point(198, 133);
            SourceArray.Margin = new Padding(3, 4, 3, 4);
            SourceArray.Name = "SourceArray";
            SourceArray.Size = new Size(771, 27);
            SourceArray.TabIndex = 7;
            // 
            // RandomArray
            // 
            RandomArray.Location = new Point(1008, 132);
            RandomArray.Margin = new Padding(3, 4, 3, 4);
            RandomArray.Name = "RandomArray";
            RandomArray.Size = new Size(86, 31);
            RandomArray.TabIndex = 8;
            RandomArray.Text = "Рандом";
            RandomArray.UseVisualStyleBackColor = true;
            RandomArray.Click += RandomArray_Click;
            // 
            // SaveArray
            // 
            SaveArray.Location = new Point(1101, 132);
            SaveArray.Margin = new Padding(3, 4, 3, 4);
            SaveArray.Name = "SaveArray";
            SaveArray.Size = new Size(86, 31);
            SaveArray.TabIndex = 9;
            SaveArray.Text = "Сохранить";
            SaveArray.UseVisualStyleBackColor = true;
            SaveArray.Click += SaveArray_Click;
            // 
            // ResultArray
            // 
            ResultArray.Location = new Point(198, 219);
            ResultArray.Margin = new Padding(3, 4, 3, 4);
            ResultArray.Name = "ResultArray";
            ResultArray.Size = new Size(771, 27);
            ResultArray.TabIndex = 10;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(200, 85);
            label4.Name = "label4";
            label4.Size = new Size(217, 30);
            label4.TabIndex = 11;
            label4.Text = "Исходный массив";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Showcard Gothic", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(200, 175);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 12;
            label5.Text = "Результат";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // blockPanel
            // 
            blockPanel.BackgroundImage = (Image)resources.GetObject("blockPanel.BackgroundImage");
            blockPanel.ForeColor = Color.DarkMagenta;
            blockPanel.Location = new Point(198, 357);
            blockPanel.Margin = new Padding(3, 4, 3, 4);
            blockPanel.MaximumSize = new Size(872, 435);
            blockPanel.MinimumSize = new Size(872, 435);
            blockPanel.Name = "blockPanel";
            blockPanel.Size = new Size(872, 435);
            blockPanel.TabIndex = 7;
            blockPanel.Visible = false;
            // 
            // descPanel
            // 
            descPanel.Controls.Add(richTextBox1);
            descPanel.Controls.Add(label7);
            descPanel.Location = new Point(200, 300);
            descPanel.Name = "descPanel";
            descPanel.Size = new Size(769, 635);
            descPanel.TabIndex = 6;
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
            // back
            // 
            back.Location = new Point(35, 735);
            back.Name = "back";
            back.Size = new Size(136, 57);
            back.TabIndex = 13;
            back.Text = "Назад";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // ShellSort
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            ClientSize = new Size(1210, 1017);
            Controls.Add(back);
            Controls.Add(descPanel);
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
            Controls.Add(blockPanel);
            Controls.Add(ViewPanel);
            Controls.Add(InfoPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1228, 1064);
            MinimumSize = new Size(1228, 1018);
            Name = "ShellSort";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Нитевидная сортировка";
            ViewPanel.ResumeLayout(false);
            ViewPanel.PerformLayout();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            descPanel.ResumeLayout(false);
            descPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel ViewPanel;
        private Button desc;
        private Button block;
        private Button sort;
        private Button iter;
        private RichTextBox indexMas;
        private TextBox sMas;
        private TextBox mas;
        private Panel InfoPanel;
        private Label label2;
        private RichTextBox iterMas;
        private Label TimeShell;
        private Label label3;
        private TextBox SourceArray;
        private Button RandomArray;
        private Button SaveArray;
        private TextBox ResultArray;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel blockPanel;
        private Panel descPanel;
        private RichTextBox richTextBox1;
        private Label label7;
        private Button back;
    }
}