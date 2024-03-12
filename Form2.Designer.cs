namespace asia_app
{
    partial class Form2
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(112, 358);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Intel i3", "Intel i5", "AMD Ryzen 5" });
            comboBox1.Location = new Point(198, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(199, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(199, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(245, 358);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 47);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 7;
            label1.Text = "Procesor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 125);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 8;
            label2.Text = "Dysk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 125);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 9;
            label3.Text = "zł";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 47);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 10;
            label4.Text = "zł";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(198, 177);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dysk HDD";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(198, 205);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 19);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Dysk SSD";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(198, 230);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 19);
            radioButton3.TabIndex = 13;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dysk SSHD";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}