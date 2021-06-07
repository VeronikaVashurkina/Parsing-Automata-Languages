namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(193, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод строки";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(193, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сообщение об ошибках";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(193, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(193, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Идентификаторы";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(633, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Константы";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(637, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(288, 31);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(634, 354);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 124);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(197, 354);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(289, 124);
            this.listBox2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(641, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 73);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(641, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 70);
            this.label7.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 566);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

