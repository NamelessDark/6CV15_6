namespace ISW_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable; // Establece el formulario sin borde
            this.Paint += new PaintEventHandler(DibujarBorde);
        }

        private void DibujarBorde(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private Form activeForm = null;
        public void openMinForms(Form hijo)
        {
            if (activeForm != null)

                activeForm.Close();

            activeForm = hijo;

            hijo.TopLevel = false;

            hijo.FormBorderStyle = FormBorderStyle.None;

            hijo.Dock = DockStyle.Fill;

            PanelesSecundarios.Controls.Add(hijo);

            PanelesSecundarios.Tag = hijo;

            hijo.BringToFront();

            hijo.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAssis_Click(object sender, EventArgs e)
        {
            openMinForms(new Form2());
        }

        private void BtnGrupos_Click(object sender, EventArgs e)
        {
            openMinForms(new Form3());
        }
    }
}
