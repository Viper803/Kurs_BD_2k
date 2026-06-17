namespace BD_Kurs
{
    partial class Trips
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
            label4 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F);
            label4.Location = new Point(12, 7);
            label4.Name = "label4";
            label4.Size = new Size(356, 65);
            label4.TabIndex = 30;
            label4.Text = "Путевые листы";
            // 
            // button3
            // 
            button3.Location = new Point(599, 256);
            button3.Name = "button3";
            button3.Size = new Size(189, 41);
            button3.TabIndex = 29;
            button3.Text = "Найти поездки до данной точки";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(599, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 206);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 27;
            label3.Text = "Поездки до данной точки";
            // 
            // button2
            // 
            button2.Location = new Point(599, 383);
            button2.Name = "button2";
            button2.Size = new Size(189, 39);
            button2.TabIndex = 26;
            button2.Text = "Найти поездки водителя";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(599, 354);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 333);
            label2.Name = "label2";
            label2.Size = new Size(189, 15);
            label2.TabIndex = 24;
            label2.Text = "Найти поездки данного водителя";
            // 
            // button1
            // 
            button1.Location = new Point(599, 162);
            button1.Name = "button1";
            button1.Size = new Size(189, 24);
            button1.TabIndex = 23;
            button1.Text = "Найти поездки из данной точки";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(599, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 112);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 21;
            label1.Text = "Поездки из точки:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(563, 369);
            dataGridView1.TabIndex = 20;
            // 
            // button4
            // 
            button4.Location = new Point(735, 7);
            button4.Name = "button4";
            button4.Size = new Size(53, 23);
            button4.TabIndex = 31;
            button4.Text = "Назад";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Trips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Trips";
            Text = "Trips";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button4;
    }
}