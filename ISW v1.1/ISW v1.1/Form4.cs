using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISW_v1._1
{
    public partial class Form4 : Form
    {

        private Form1 formulario;

        public Form4(Form1 principal)
        {
            InitializeComponent();
            this.formulario = principal;
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            formulario.openMinForms(new Form7());
           
        }
    }
}
