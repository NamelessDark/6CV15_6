namespace beta_isw
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(120, 0, 64);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(1, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(917, 38);
            label1.TabIndex = 0;
            label1.Text = "INSTITUTO POLITECNICO NACIONAL UNIDAD CULHUACAN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(0, 40);
            button1.Margin = new Padding(3, 2, 3, 0);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 1;
            button1.Text = "ASISTENCIA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 96);
            button2.Margin = new Padding(3, 2, 3, 0);
            button2.Name = "button2";
            button2.Size = new Size(156, 54);
            button2.TabIndex = 2;
            button2.Text = "GRUPOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(917, 338);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "SOFTWARE LABORATORISTA";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}