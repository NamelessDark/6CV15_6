using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISW_v1._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        

         
        private void Form2_Load(object sender, EventArgs e)
        {
            Clases.CConexion obetoconexion = new Clases.CConexion();
            obetoconexion.establecer();
            string query = "select * from ctl_asistencia where ID_Lab = 'L1'";
            string query2 = "select * from ctl_asistencia where ID_Lab = 'L2'";
            MySqlCommand comando = new MySqlCommand(query,obetoconexion.establecer());
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;

            MySqlCommand comando2 = new MySqlCommand(query2, obetoconexion.establecer());
            MySqlDataAdapter data2 = new MySqlDataAdapter(comando2);
            DataTable tabla2 = new DataTable();
            data2.Fill(tabla2);
            dataGridView2.DataSource = tabla2;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
