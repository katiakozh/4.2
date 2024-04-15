namespace лаба_11_з2
{
    partial class Form1
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(20, 625);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(183, 54);
            button1.TabIndex = 0;
            button1.Text = "Сгенерировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(20, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(514, 592);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(540, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(527, 548);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(540, 566);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(527, 38);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(943, 632);
            button2.Name = "button2";
            button2.Size = new Size(124, 54);
            button2.TabIndex = 4;
            button2.Text = "Вывод";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 625);
            button3.Name = "button3";
            button3.Size = new Size(153, 54);
            button3.TabIndex = 5;
            button3.Text = "Сохранить ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(705, 641);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(232, 38);
            textBox2.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(370, 625);
            button5.Name = "button5";
            button5.Size = new Size(151, 54);
            button5.TabIndex = 7;
            button5.Text = "Отчистка";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
    }
}
