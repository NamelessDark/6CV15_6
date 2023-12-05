namespace beta_isw
{
    partial class Form9
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
            label5 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(74, 9);
            label5.Name = "label5";
            label5.Size = new Size(350, 15);
            label5.TabIndex = 24;
            label5.Text = "NUMERO DE MAQUINA";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 26);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 33;
            textBox1.Text = "10";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(343, 129);
            button1.Margin = new Padding(3, 2, 3, 0);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 34;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 35;
            label1.Text = "IP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 138);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 23);
            textBox2.TabIndex = 36;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(96, 165);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(141, 23);
            textBox3.TabIndex = 38;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 37;
            label2.Text = "MAC ADRESS";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(511, 191);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Name = "Form9";
            Text = "PRIMER INICIO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
    }
}