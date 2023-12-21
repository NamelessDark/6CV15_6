namespace ISW_v1._1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            BtnGrupos = new Button();
            BtnAssis = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            PanelesSecundarios = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(BtnGrupos);
            panel1.Controls.Add(BtnAssis);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 453);
            panel1.TabIndex = 0;
            // 
            // BtnGrupos
            // 
            BtnGrupos.BackColor = SystemColors.GradientInactiveCaption;
            BtnGrupos.Dock = DockStyle.Top;
            BtnGrupos.FlatAppearance.BorderSize = 0;
            BtnGrupos.FlatAppearance.MouseDownBackColor = Color.White;
            BtnGrupos.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 0, 64);
            BtnGrupos.FlatStyle = FlatStyle.Flat;
            BtnGrupos.ForeColor = SystemColors.ActiveCaptionText;
            BtnGrupos.Location = new Point(0, 270);
            BtnGrupos.Name = "BtnGrupos";
            BtnGrupos.Size = new Size(230, 50);
            BtnGrupos.TabIndex = 2;
            BtnGrupos.Text = "GRUPOS";
            BtnGrupos.TextAlign = ContentAlignment.MiddleLeft;
            BtnGrupos.UseVisualStyleBackColor = false;
            BtnGrupos.Click += BtnGrupos_Click;
            // 
            // BtnAssis
            // 
            BtnAssis.BackColor = SystemColors.Highlight;
            BtnAssis.Dock = DockStyle.Top;
            BtnAssis.FlatAppearance.BorderSize = 0;
            BtnAssis.FlatAppearance.MouseDownBackColor = Color.White;
            BtnAssis.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 0, 64);
            BtnAssis.FlatStyle = FlatStyle.Flat;
            BtnAssis.ForeColor = SystemColors.GradientInactiveCaption;
            BtnAssis.Location = new Point(0, 220);
            BtnAssis.Name = "BtnAssis";
            BtnAssis.Size = new Size(230, 50);
            BtnAssis.TabIndex = 1;
            BtnAssis.Text = "ASISTENCIA";
            BtnAssis.TextAlign = ContentAlignment.MiddleLeft;
            BtnAssis.UseVisualStyleBackColor = false;
            BtnAssis.Click += BtnAssis_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 220);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 0, 64);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(230, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1252, 56);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial Narrow", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(169, 9);
            label1.Name = "label1";
            label1.Size = new Size(929, 40);
            label1.TabIndex = 0;
            label1.Text = "INSTITUTO POLITECNICO NACIONAL ESIME UNIDAD CULHUACAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelesSecundarios
            // 
            PanelesSecundarios.BackColor = SystemColors.ActiveCaptionText;
            PanelesSecundarios.BackgroundImage = (Image)resources.GetObject("PanelesSecundarios.BackgroundImage");
            PanelesSecundarios.BackgroundImageLayout = ImageLayout.Stretch;
            PanelesSecundarios.Dock = DockStyle.Fill;
            PanelesSecundarios.Location = new Point(230, 56);
            PanelesSecundarios.Name = "PanelesSecundarios";
            PanelesSecundarios.Size = new Size(1252, 397);
            PanelesSecundarios.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1482, 453);
            Controls.Add(PanelesSecundarios);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SOFTWARE ENCARGADO";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel PanelesSecundarios;
        private Button BtnGrupos;
        private Button BtnAssis;
    }
}
