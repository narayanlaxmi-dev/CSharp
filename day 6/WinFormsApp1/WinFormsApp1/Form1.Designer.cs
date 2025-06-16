namespace WinFormsApp1
{
    partial class FormFirst
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(322, 196);
            button1.Name = "button1";
            button1.Size = new Size(100, 39);
            button1.TabIndex = 0;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(322, 174);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "pending";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(445, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(86, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(557, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(99, 34);
            listBox1.TabIndex = 3;
            // 
            // FormFirst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources.m;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormFirst";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
    }
}
