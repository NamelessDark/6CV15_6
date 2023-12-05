using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beta_isw
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form registro_del_grupo = new Form12();
            registro_del_grupo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form asistencias_pasadas = new Form8();
            asistencias_pasadas .Show();
        }
    }
}
