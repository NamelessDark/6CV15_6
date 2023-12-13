namespace ISW_ALUMNADO_v1._1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(128, 0, 64);
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(326, 146);
            label1.Name = "label1";
            label1.Size = new Size(145, 35);
            label1.TabIndex = 0;
            label1.Text = "Boleta/Folio";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(256, 189);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 47);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(258, 293);
            textBox2.MaxLength = 10;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(281, 47);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.FromArgb(128, 0, 64);
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(328, 250);
            label2.Name = "label2";
            label2.Size = new Size(145, 35);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(313, 358);
            button1.Name = "button1";
            button1.Size = new Size(185, 58);
            button1.TabIndex = 4;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(621, 471);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 9;
            label3.Text = "SISTEMAS OPERATIVOS\r\n";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 471);
            label4.Name = "label4";
            label4.Size = new Size(167, 20);
            label4.TabIndex = 8;
            label4.Text = "CICLO ESCOLAR: 2024-1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 500);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}
