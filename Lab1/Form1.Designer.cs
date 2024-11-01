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
            dichotomyButton = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            NewtonButton = new System.Windows.Forms.Button();
            GoldenRatioButton = new System.Windows.Forms.Button();
            coordinateDescentButton = new System.Windows.Forms.Button();
            sortingsButton = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dichotomyButton
            // 
            dichotomyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            dichotomyButton.AutoSize = true;
            dichotomyButton.Location = new System.Drawing.Point(52, 5);
            dichotomyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dichotomyButton.Name = "dichotomyButton";
            dichotomyButton.Size = new System.Drawing.Size(138, 46);
            dichotomyButton.TabIndex = 0;
            dichotomyButton.Text = "Метод Дихотомии";
            dichotomyButton.UseVisualStyleBackColor = true;
            dichotomyButton.Click += dichotomyButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.6633663F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.33663F));
            tableLayoutPanel1.Controls.Add(dichotomyButton, 0, 0);
            tableLayoutPanel1.Controls.Add(coordinateDescentButton, 0, 3);
            tableLayoutPanel1.Controls.Add(NewtonButton, 0, 2);
            tableLayoutPanel1.Controls.Add(GoldenRatioButton, 0, 1);
            tableLayoutPanel1.Controls.Add(sortingsButton, 0, 4);
            tableLayoutPanel1.Location = new System.Drawing.Point(41, 77);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1012, 513);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // NewtonButton
            // 
            NewtonButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            NewtonButton.AutoSize = true;
            NewtonButton.Location = new System.Drawing.Point(57, 119);
            NewtonButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NewtonButton.Name = "NewtonButton";
            NewtonButton.Size = new System.Drawing.Size(127, 55);
            NewtonButton.TabIndex = 2;
            NewtonButton.Text = "Метод Ньютона";
            NewtonButton.UseVisualStyleBackColor = true;
            NewtonButton.Click += NewtonButton_Click;
            // 
            // GoldenRatioButton
            // 
            GoldenRatioButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            GoldenRatioButton.AutoSize = true;
            GoldenRatioButton.Location = new System.Drawing.Point(42, 59);
            GoldenRatioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GoldenRatioButton.Name = "GoldenRatioButton";
            GoldenRatioButton.Size = new System.Drawing.Size(157, 52);
            GoldenRatioButton.TabIndex = 1;
            GoldenRatioButton.Text = "Метод Золотого Сечения";
            GoldenRatioButton.UseVisualStyleBackColor = true;
            GoldenRatioButton.Click += GoldenRatioButton_Click;
            // 
            // coordinateDescentButton
            // 
            coordinateDescentButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            coordinateDescentButton.AutoSize = true;
            coordinateDescentButton.Location = new System.Drawing.Point(24, 182);
            coordinateDescentButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            coordinateDescentButton.Name = "coordinateDescentButton";
            coordinateDescentButton.Size = new System.Drawing.Size(193, 64);
            coordinateDescentButton.TabIndex = 3;
            coordinateDescentButton.Text = "Метод покоординатного спуска";
            coordinateDescentButton.UseVisualStyleBackColor = true;
            coordinateDescentButton.Click += coordinateDescentButton_Click;
            // 
            // sortingsButton
            // 
            sortingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            sortingsButton.AutoSize = true;
            sortingsButton.Location = new System.Drawing.Point(24, 254);
            sortingsButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sortingsButton.Name = "sortingsButton";
            sortingsButton.Size = new System.Drawing.Size(193, 62);
            sortingsButton.TabIndex = 4;
            sortingsButton.Text = "Сортировки";
            sortingsButton.UseVisualStyleBackColor = true;
            sortingsButton.Click += sortingsButton_Click;
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
    }
}

