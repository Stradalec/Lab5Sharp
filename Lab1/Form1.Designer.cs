namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dichotomyButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            coordinateDescentButton = new System.Windows.Forms.Button();
            NewtonButton = new System.Windows.Forms.Button();
            GoldenRatioButton = new System.Windows.Forms.Button();
            sortingsButton = new System.Windows.Forms.Button();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            richTextBox4 = new System.Windows.Forms.RichTextBox();
            richTextBox5 = new System.Windows.Forms.RichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dichotomyButton
            // 
            dichotomyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            dichotomyButton.AutoSize = true;
            dichotomyButton.Location = new System.Drawing.Point(33, 5);
            dichotomyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dichotomyButton.Name = "dichotomyButton";
            dichotomyButton.Size = new System.Drawing.Size(138, 54);
            dichotomyButton.TabIndex = 0;
            dichotomyButton.Text = "Метод Дихотомии";
            dichotomyButton.UseVisualStyleBackColor = true;
            dichotomyButton.Click += dichotomyButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel1.Controls.Add(richTextBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(dichotomyButton, 0, 0);
            tableLayoutPanel1.Controls.Add(coordinateDescentButton, 0, 3);
            tableLayoutPanel1.Controls.Add(NewtonButton, 0, 2);
            tableLayoutPanel1.Controls.Add(GoldenRatioButton, 0, 1);
            tableLayoutPanel1.Controls.Add(sortingsButton, 0, 4);
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new System.Drawing.Point(11, 72);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1017, 498);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // coordinateDescentButton
            // 
            coordinateDescentButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            coordinateDescentButton.AutoSize = true;
            coordinateDescentButton.Location = new System.Drawing.Point(6, 191);
            coordinateDescentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            coordinateDescentButton.Name = "coordinateDescentButton";
            coordinateDescentButton.Size = new System.Drawing.Size(193, 54);
            coordinateDescentButton.TabIndex = 3;
            coordinateDescentButton.Text = "Метод покоординатного спуска";
            coordinateDescentButton.UseVisualStyleBackColor = true;
            coordinateDescentButton.Click += coordinateDescentButton_Click;
            // 
            // NewtonButton
            // 
            NewtonButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            NewtonButton.AutoSize = true;
            NewtonButton.Location = new System.Drawing.Point(39, 129);
            NewtonButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new System.Drawing.Size(127, 54);
            NewtonButton.TabIndex = 2;
            NewtonButton.Text = "Метод Ньютона";
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.Click += NewtonButton_Click;
            // 
            // GoldenRatioButton
            // 
            GoldenRatioButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            GoldenRatioButton.AutoSize = true;
            GoldenRatioButton.Location = new System.Drawing.Point(24, 67);
            GoldenRatioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GoldenRatioButton.Name = "GoldenRatioButton";
            GoldenRatioButton.Size = new System.Drawing.Size(157, 54);
            GoldenRatioButton.TabIndex = 1;
            GoldenRatioButton.Text = "Метод Золотого Сечения";
            GoldenRatioButton.UseVisualStyleBackColor = true;
            GoldenRatioButton.Click += GoldenRatioButton_Click;
            // 
            // sortingsButton
            // 
            sortingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            sortingsButton.AutoSize = true;
            sortingsButton.Location = new System.Drawing.Point(13, 253);
            sortingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sortingsButton.Name = "sortingsButton";
            sortingsButton.Size = new System.Drawing.Size(179, 54);
            sortingsButton.TabIndex = 4;
            sortingsButton.Text = "Сортировки";
            sortingsButton.UseVisualStyleBackColor = true;
            sortingsButton.Click += sortingsButton_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(208, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(667, 46);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(208, 67);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(667, 46);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new System.Drawing.Point(208, 129);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new System.Drawing.Size(667, 46);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "Метод Ньютона\nИспользуется для нахождения минимума, максимума функции, а также точки пересечения её с осью абсциис.\nНахождение касательных к функции.\nМетод хорош для плоских задач.\n\n";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new System.Drawing.Point(208, 191);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new System.Drawing.Size(667, 46);
            richTextBox4.TabIndex = 8;
            richTextBox4.Text = "Метод покоординатного спуска\nИспользуется для нахождения минимума, максимума функции.\nПостепенное приближение с заданным шагом.\nМетод плох для плоских задач.\n\n";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new System.Drawing.Point(208, 253);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new System.Drawing.Size(667, 46);
            richTextBox5.TabIndex = 9;
            richTextBox5.Text = "Сортировки.\nСортировки различнейшими способами.\n\n\n";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1057, 614);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Приложение";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button dichotomyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GoldenRatioButton;
        private System.Windows.Forms.Button NewtonButton;
        private System.Windows.Forms.Button coordinateDescentButton;
        private System.Windows.Forms.Button sortingsButton;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox5;
    }
}

