namespace BD_Kurs
{
    partial class Drivers
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
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(563, 369);
            dataGridView1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(599, 262);
            button3.Name = "button3";
            button3.Size = new Size(189, 41);
            button3.TabIndex = 18;
            button3.Text = "Найти водителя с нужным опытом";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(599, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 23);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(599, 212);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 16;
            label3.Text = "Опыт водителя:";
            // 
            // button2
            // 
            button2.Location = new Point(599, 377);
            button2.Name = "button2";
            button2.Size = new Size(189, 39);
            button2.TabIndex = 15;
            button2.Text = "Найти водителя по номеру прав";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(599, 348);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 23);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(599, 327);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 13;
            label2.Text = "Номер прав водителя";
            // 
            // button1
            // 
            button1.Location = new Point(599, 156);
            button1.Name = "button1";
            button1.Size = new Size(189, 24);
            button1.TabIndex = 12;
            button1.Text = "Найти водителя";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(599, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(599, 106);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 10;
            label1.Text = "ФИО водителя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F);
            label4.Location = new Point(12, 1);
            label4.Name = "label4";
            label4.Size = new Size(236, 65);
            label4.TabIndex = 19;
            label4.Text = "Водители";
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
            // Drivers
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
            Name = "Drivers";
            Text = "Информация о водителях";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Button button4;
    }
}