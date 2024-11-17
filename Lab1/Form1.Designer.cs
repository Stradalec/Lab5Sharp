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
            richTextBox5 = new System.Windows.Forms.RichTextBox();
            richTextBox4 = new System.Windows.Forms.RichTextBox();
            richTextBox3 = new System.Windows.Forms.RichTextBox();
            richTextBox2 = new System.Windows.Forms.RichTextBox();
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            coordinateDescentButton = new System.Windows.Forms.Button();
            sortingsButton = new System.Windows.Forms.Button();
            GoldenRatioButton = new System.Windows.Forms.Button();
            NewtonButton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dichotomyButton
            // 
            dichotomyButton.AutoSize = true;
            dichotomyButton.Location = new System.Drawing.Point(817, 5);
            dichotomyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dichotomyButton.Name = "dichotomyButton";
            dichotomyButton.Size = new System.Drawing.Size(192, 54);
            dichotomyButton.TabIndex = 0;
            dichotomyButton.Text = "Метод Дихотомии";
            dichotomyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            dichotomyButton.UseVisualStyleBackColor = true;
            dichotomyButton.Click += dichotomyButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(richTextBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(richTextBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(richTextBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(coordinateDescentButton, 2, 3);
            tableLayoutPanel1.Controls.Add(sortingsButton, 2, 4);
            tableLayoutPanel1.Controls.Add(dichotomyButton, 2, 0);
            tableLayoutPanel1.Controls.Add(GoldenRatioButton, 2, 1);
            tableLayoutPanel1.Controls.Add(NewtonButton, 2, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
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
            // richTextBox5
            // 
            richTextBox5.Location = new System.Drawing.Point(128, 253);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new System.Drawing.Size(667, 46);
            richTextBox5.TabIndex = 9;
            richTextBox5.Text = "Сортировки.\nСортировки различнейшими способами.\n\n\n";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new System.Drawing.Point(128, 191);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new System.Drawing.Size(667, 46);
            richTextBox4.TabIndex = 8;
            richTextBox4.Text = "Метод покоординатного спуска\nИспользуется для нахождения минимума, максимума функции.\nПостепенное приближение с заданным шагом.\nМетод плох для плоских задач.\n\n";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new System.Drawing.Point(128, 129);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new System.Drawing.Size(667, 46);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "Метод Ньютона\nИспользуется для нахождения минимума, максимума функции, а также точки пересечения её с осью абсциис.\nНахождение касательных к функции.\nМетод хорош для плоских задач.\n\n";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(128, 67);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new System.Drawing.Size(667, 46);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(128, 5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new System.Drawing.Size(667, 46);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // coordinateDescentButton
            // 
            coordinateDescentButton.AutoSize = true;
            coordinateDescentButton.Location = new System.Drawing.Point(817, 191);
            coordinateDescentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            coordinateDescentButton.Name = "coordinateDescentButton";
            coordinateDescentButton.Size = new System.Drawing.Size(193, 54);
            coordinateDescentButton.TabIndex = 3;
            coordinateDescentButton.Text = "Метод покоординатного спуска";
            coordinateDescentButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            coordinateDescentButton.UseVisualStyleBackColor = true;
            coordinateDescentButton.Click += coordinateDescentButton_Click;
            // 
            // sortingsButton
            // 
            sortingsButton.AutoSize = true;
            sortingsButton.Location = new System.Drawing.Point(817, 253);
            sortingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sortingsButton.Name = "sortingsButton";
            sortingsButton.Size = new System.Drawing.Size(192, 54);
            sortingsButton.TabIndex = 4;
            sortingsButton.Text = "Сортировки";
            sortingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            sortingsButton.UseVisualStyleBackColor = true;
            sortingsButton.Click += sortingsButton_Click;
            // 
            // GoldenRatioButton
            // 
            GoldenRatioButton.AutoSize = true;
            GoldenRatioButton.Location = new System.Drawing.Point(817, 67);
            GoldenRatioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GoldenRatioButton.Name = "GoldenRatioButton";
            GoldenRatioButton.Size = new System.Drawing.Size(192, 54);
            GoldenRatioButton.TabIndex = 1;
            GoldenRatioButton.Text = "Метод Золотого Сечения";
            GoldenRatioButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            GoldenRatioButton.UseVisualStyleBackColor = true;
            GoldenRatioButton.Click += GoldenRatioButton_Click;
            // 
            // NewtonButton
            // 
            NewtonButton.AutoSize = true;
            NewtonButton.Location = new System.Drawing.Point(817, 129);
            NewtonButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new System.Drawing.Size(192, 54);
            NewtonButton.TabIndex = 2;
            NewtonButton.Text = "Метод Ньютона";
            NewtonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.Click += NewtonButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(7, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(110, 54);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            label1.Location = new System.Drawing.Point(355, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(313, 28);
            label1.TabIndex = 2;
            label1.Text = "Численные методы (и не только)";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(326, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(374, 15);
            label2.TabIndex = 3;
            label2.Text = "Перед использованием рекомендуется ознакомиться со справкой";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(705, 43);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1057, 614);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Приложение";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

