namespace SortV2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            IntroSort = new Button();
            StarndSort = new Button();
            ShellSort = new Button();
            AllSort = new Button();
            closeBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // IntroSort
            // 
            IntroSort.Location = new Point(96, 318);
            IntroSort.Margin = new Padding(3, 4, 3, 4);
            IntroSort.Name = "IntroSort";
            IntroSort.Size = new Size(218, 75);
            IntroSort.TabIndex = 0;
            IntroSort.Text = "Гибридная сортировка";
            IntroSort.UseVisualStyleBackColor = true;
            IntroSort.Click += IntroSort_Click;
            // 
            // StarndSort
            // 
            StarndSort.Location = new Point(96, 472);
            StarndSort.Margin = new Padding(3, 4, 3, 4);
            StarndSort.Name = "StarndSort";
            StarndSort.Size = new Size(218, 75);
            StarndSort.TabIndex = 1;
            StarndSort.Text = "Нитевидная сортировка";
            StarndSort.UseVisualStyleBackColor = true;
            StarndSort.Click += StarndSort_Click;
            // 
            // ShellSort
            // 
            ShellSort.Location = new Point(385, 318);
            ShellSort.Margin = new Padding(3, 4, 3, 4);
            ShellSort.Name = "ShellSort";
            ShellSort.Size = new Size(218, 75);
            ShellSort.TabIndex = 2;
            ShellSort.Text = "Сортировка Шелла";
            ShellSort.UseVisualStyleBackColor = true;
            ShellSort.Click += ShellSort_Click;
            // 
            // AllSort
            // 
            AllSort.Location = new Point(385, 453);
            AllSort.Margin = new Padding(3, 4, 3, 4);
            AllSort.Name = "AllSort";
            AllSort.Size = new Size(218, 75);
            AllSort.TabIndex = 3;
            AllSort.Text = "Сравнение ";
            AllSort.UseVisualStyleBackColor = true;
            AllSort.Click += AllSort_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(850, 385);
            closeBtn.Margin = new Padding(3, 4, 3, 4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(218, 75);
            closeBtn.TabIndex = 4;
            closeBtn.Text = "Выход";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(246, 124);
            label1.Name = "label1";
            label1.Size = new Size(796, 74);
            label1.TabIndex = 15;
            label1.Text = "Тренажер для школьников";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1210, 1017);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(AllSort);
            Controls.Add(ShellSort);
            Controls.Add(StarndSort);
            Controls.Add(IntroSort);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1228, 1064);
            MinimumSize = new Size(1228, 1018);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button IntroSort;
        private Button StarndSort;
        private Button ShellSort;
        private Button AllSort;
        private Button closeBtn;
        private Label label1;
    }
}