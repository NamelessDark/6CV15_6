﻿namespace beta_isw
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Location = new Point(352, 19);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Location = new Point(315, 72);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 2;
            label2.Text = "NUMERO DE BOLETA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(254, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(272, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 421);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 6;
            label4.Text = "CICLO ESCOLAR: 2024-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(621, 421);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 7;
            label3.Text = "SISTEMAS OPERATIVOS\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(304, 128);
            button1.Margin = new Padding(3, 3, 3, 0);
            button1.Name = "button1";
            button1.Size = new Size(178, 72);
            button1.TabIndex = 8;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "ALUMNADO REGISTRO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label label3;
        private Button button1;
    }
}