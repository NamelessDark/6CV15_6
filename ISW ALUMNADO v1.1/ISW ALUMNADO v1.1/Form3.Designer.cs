namespace ISW_ALUMNADO_v1._1
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
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 27);
            textBox3.TabIndex = 45;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 323);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 44;
            label2.Text = "MAC ADRESS";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 43;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 287);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 42;
            label1.Text = "IP";
            // 
            // button1
            // 
            button1.Location = new Point(610, 369);
            button1.Margin = new Padding(3, 3, 3, 0);
            button1.Name = "button1";
            button1.Size = new Size(178, 72);
            button1.TabIndex = 41;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 27);
            textBox1.TabIndex = 40;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.Location = new Point(193, 108);
            label5.Name = "label5";
            label5.Size = new Size(400, 20);
            label5.TabIndex = 39;
            label5.Text = "NUMERO DE MAQUINA";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Name = "Form3";
            Text = "PRIMER INICIO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label5;
    }
}