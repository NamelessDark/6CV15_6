namespace ISW_v1._1
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
            button1 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = SystemColors.ControlLight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(24, 414);
            button1.Name = "button1";
            button1.Size = new Size(178, 72);
            button1.TabIndex = 9;
            button1.Text = "NUEVO GRUPO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 125);
            panel1.TabIndex = 10;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ControlLight;
            label8.Location = new Point(911, 79);
            label8.Name = "label8";
            label8.Size = new Size(204, 20);
            label8.TabIndex = 17;
            label8.Text = "LABORATORIO";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ControlLight;
            label7.Location = new Point(701, 79);
            label7.Name = "label7";
            label7.Size = new Size(204, 20);
            label7.TabIndex = 16;
            label7.Text = "HORARIO";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ControlLight;
            label6.Location = new Point(637, 79);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 15;
            label6.Text = "TURNO";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(551, 79);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 14;
            label5.Text = "CICLO";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(309, 79);
            label4.Name = "label4";
            label4.Size = new Size(236, 20);
            label4.TabIndex = 13;
            label4.Text = "PROFESOR";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(99, 79);
            label3.Name = "label3";
            label3.Size = new Size(204, 20);
            label3.TabIndex = 12;
            label3.Text = "MATERIA";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(36, 79);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 11;
            label2.Text = "GRUPO";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(942, 27);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(36, 28);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 9;
            label1.Text = "BUSCAR GRUPO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 283);
            panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1150, 283);
            dataGridView1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1150, 500);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1150, 500);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel2;
        private DataGridView dataGridView1;
    }
}