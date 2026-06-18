namespace BD_Kurs
{
    partial class Cars
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
            dataGridView1 = new DataGridView();
            label4 = new Label();
            button4 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(776, 369);
            dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F);
            label4.Location = new Point(12, 1);
            label4.Name = "label4";
            label4.Size = new Size(303, 65);
            label4.TabIndex = 10;
            label4.Text = "Автомобили";
            // 
            // button4
            // 
            button4.Location = new Point(735, 12);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 32;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(572, 40);
            button2.Name = "button2";
            button2.Size = new Size(145, 23);
            button2.TabIndex = 38;
            button2.Text = "Показать всю таблицу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(439, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 37;
            // 
            // button1
            // 
            button1.Location = new Point(572, 11);
            button1.Name = "button1";
            button1.Size = new Size(145, 24);
            button1.TabIndex = 36;
            button1.Text = "Найти данные";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(439, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 23);
            textBox1.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 44);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 41;
            label2.Text = "Выбрать столбец:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 15);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 40;
            label3.Text = "Найти:";
            // 
            // Cars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Name = "Cars";
            Text = "З";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Button button4;
        private Button button2;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
    }
}