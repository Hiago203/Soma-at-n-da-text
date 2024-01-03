namespace Soma_até_n_da_text
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
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(104, 236);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(151, 285);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 207);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "1 a 5";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(132, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 379);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private ListBox listBox1;
    }
}