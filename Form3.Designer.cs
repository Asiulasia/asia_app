namespace asia_app
{
    partial class Form3
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
            ListViewItem listViewItem7 = new ListViewItem("Monitor CRD");
            ListViewItem listViewItem8 = new ListViewItem("Monitor LCD/LED");
            ListViewItem listViewItem9 = new ListViewItem("Monitor OLED");
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 212);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "cena";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 215);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 2;
            label2.Text = "zł";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 212);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(263, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9 });
            listView1.Location = new Point(303, 79);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ListView listView1;
    }
}