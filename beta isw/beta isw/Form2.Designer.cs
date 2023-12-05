namespace beta_isw
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
            textBox1 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "BOLETA";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button4
            // 
            button4.Location = new Point(305, 161);
            button4.Margin = new Padding(3, 3, 3, 0);
            button4.Name = "button4";
            button4.Size = new Size(178, 72);
            button4.TabIndex = 5;
            button4.Text = "ACEPTAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(782, 353);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "ALUMNADO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button4;
    }
}