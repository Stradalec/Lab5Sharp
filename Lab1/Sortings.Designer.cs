namespace Lab1
{
    partial class Sortings
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
            bubble = new System.Windows.Forms.CheckBox();
            inserts = new System.Windows.Forms.CheckBox();
            fast = new System.Windows.Forms.CheckBox();
            shake = new System.Windows.Forms.CheckBox();
            swamp = new System.Windows.Forms.CheckBox();
            sortGroup = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            inputBox = new System.Windows.Forms.GroupBox();
            radioButton3 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton1 = new System.Windows.Forms.RadioButton();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Iterationss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            groupBox1 = new System.Windows.Forms.GroupBox();
            radioButton4 = new System.Windows.Forms.RadioButton();
            radioButton5 = new System.Windows.Forms.RadioButton();
            sortGroup.SuspendLayout();
            inputBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bubble
            // 
            bubble.AutoSize = true;
            bubble.Location = new System.Drawing.Point(15, 22);
            bubble.Name = "bubble";
            bubble.Size = new System.Drawing.Size(90, 19);
            bubble.TabIndex = 0;
            bubble.Text = "Пузырьком";
            bubble.UseVisualStyleBackColor = true;
            // 
            // inserts
            // 
            inserts.AutoSize = true;
            inserts.Location = new System.Drawing.Point(15, 54);
            inserts.Name = "inserts";
            inserts.Size = new System.Drawing.Size(84, 19);
            inserts.TabIndex = 1;
            inserts.Text = "Вставками";
            inserts.UseVisualStyleBackColor = true;
            // 
            // fast
            // 
            fast.AutoSize = true;
            fast.Location = new System.Drawing.Point(15, 88);
            fast.Name = "fast";
            fast.Size = new System.Drawing.Size(72, 19);
            fast.TabIndex = 2;
            fast.Text = "Быстрая";
            fast.UseVisualStyleBackColor = true;
            // 
            // shake
            // 
            shake.AutoSize = true;
            shake.Location = new System.Drawing.Point(15, 120);
            shake.Name = "shake";
            shake.Size = new System.Drawing.Size(88, 19);
            shake.TabIndex = 3;
            shake.Text = "Шейкерная";
            shake.UseVisualStyleBackColor = true;
            // 
            // swamp
            // 
            swamp.AutoSize = true;
            swamp.Location = new System.Drawing.Point(15, 154);
            swamp.Name = "swamp";
            swamp.Size = new System.Drawing.Size(78, 19);
            swamp.TabIndex = 4;
            swamp.Text = "Болотная";
            swamp.UseVisualStyleBackColor = true;
            // 
            // sortGroup
            // 
            sortGroup.Controls.Add(label1);
            sortGroup.Controls.Add(textBox1);
            sortGroup.Controls.Add(bubble);
            sortGroup.Controls.Add(swamp);
            sortGroup.Controls.Add(inserts);
            sortGroup.Controls.Add(shake);
            sortGroup.Controls.Add(fast);
            sortGroup.Location = new System.Drawing.Point(12, 30);
            sortGroup.Margin = new System.Windows.Forms.Padding(5);
            sortGroup.Name = "sortGroup";
            sortGroup.Size = new System.Drawing.Size(216, 179);
            sortGroup.TabIndex = 5;
            sortGroup.TabStop = false;
            sortGroup.Text = "Сортировки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(116, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 15);
            label1.TabIndex = 7;
            label1.Text = "Макс. итераций";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(116, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(94, 23);
            textBox1.TabIndex = 5;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(radioButton3);
            inputBox.Controls.Add(radioButton2);
            inputBox.Controls.Add(radioButton1);
            inputBox.Location = new System.Drawing.Point(245, 30);
            inputBox.Name = "inputBox";
            inputBox.Size = new System.Drawing.Size(105, 95);
            inputBox.TabIndex = 6;
            inputBox.TabStop = false;
            inputBox.Text = "Тип ввода";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(6, 71);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(77, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Из файла";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(6, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(83, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Генерация";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(66, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Ручной";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripTextBox1 });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 27);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            toolStripTextBox1.Text = "Сортировать";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new System.Drawing.Point(12, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(146, 183);
            dataGridView1.TabIndex = 8;
            dataGridView1.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Числа для сортировки";
            Column1.Name = "Column1";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Method, Iterationss, Time });
            dataGridView2.Location = new System.Drawing.Point(418, 30);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(343, 150);
            dataGridView2.TabIndex = 9;
            // 
            // Method
            // 
            Method.HeaderText = "Метод";
            Method.Name = "Method";
            // 
            // Iterationss
            // 
            Iterationss.HeaderText = "Итерации";
            Iterationss.Name = "Iterationss";
            // 
            // Time
            // 
            Time.HeaderText = "Время";
            Time.Name = "Time";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Location = new System.Drawing.Point(245, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(105, 78);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сортировка по:";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(7, 49);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(84, 19);
            radioButton4.TabIndex = 2;
            radioButton4.TabStop = true;
            radioButton4.Text = "Убыванию";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new System.Drawing.Point(7, 30);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new System.Drawing.Size(98, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Возрастанию";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Sortings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(inputBox);
            Controls.Add(sortGroup);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Sortings";
            Text = "Sortings";
            sortGroup.ResumeLayout(false);
            sortGroup.PerformLayout();
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox bubble;
        private System.Windows.Forms.CheckBox inserts;
        private System.Windows.Forms.CheckBox fast;
        private System.Windows.Forms.CheckBox shake;
        private System.Windows.Forms.CheckBox swamp;
        private System.Windows.Forms.GroupBox sortGroup;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iterationss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}