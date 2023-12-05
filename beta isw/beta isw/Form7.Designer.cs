namespace beta_isw
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            label14 = new Label();
            vScrollBar1 = new VScrollBar();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ControlLight;
            label14.Location = new Point(154, 8);
            label14.Name = "label14";
            label14.Size = new Size(123, 15);
            label14.TabIndex = 36;
            label14.Text = "PROFESOR: CALZADA\r\n";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(154, 44);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(26, 286);
            vScrollBar1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, 44);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(269, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(982, 224);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 26;
            label8.Text = "label8";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ControlLight;
            label4.Location = new Point(56, 44);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 22;
            label4.Text = "REGISTRO\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Location = new Point(56, 8);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 21;
            label3.Text = "GRUPO: 6CV11\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLight;
            label2.Location = new Point(338, 315);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 20;
            label2.Text = "CICLO ESCOLAR 2024-1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Location = new Point(293, 8);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 19;
            label1.Text = "MATERIA: SISTEMAS OPERATIVOS";
            // 
            // button1
            // 
            button1.Location = new Point(192, 286);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(131, 44);
            button1.TabIndex = 38;
            button1.Text = "REABRIR GRUPO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(56, 61);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(74, 20);
            button2.TabIndex = 39;
            button2.Text = "10-10-2024";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(518, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label14);
            Controls.Add(vScrollBar1);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form7";
            Text = "REGISTRO DE GRUPOS";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private VScrollBar vScrollBar1;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}