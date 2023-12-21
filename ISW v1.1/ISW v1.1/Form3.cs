using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISW_v1._1
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buscar el formulario principal en la colección de formularios abiertos
            Form formularioPrincipal = Application.OpenForms["Form1"];

            if (formularioPrincipal != null)
            {
                // Si se encuentra el formulario principal, crear Form4 y pasar el formulario principal como argumento
                Form4 formulario4 = new Form4((Form1)formularioPrincipal);
                formulario4.Show();
            }
            else
            {
                // Manejar la situación si el formulario principal no está abierto
                MessageBox.Show("El formulario principal no está abierto.");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Clases.CConexion obetoconexion = new Clases.CConexion();
            obetoconexion.establecer();
            string query = "select * from ctl_asistencia";
            MySqlCommand comando = new MySqlCommand(query, obetoconexion.establecer());
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            string query = "SELECT * FROM ctl_asistencia WHERE " +
                   "ID_Asistencia = @search OR " +
                   "ID_Clase = @search OR " +
                   "ID_Alumno = @search OR " +
                   "ID_Profesor = @search OR " +
                   "ID_Horario = @search OR " +
                   "ID_Lab = @search OR " +
                   "ID_Maquina = @search;";

            // Resto del código...
            Clases.CConexion obetoconexion = new Clases.CConexion();
            obetoconexion.establecer();
            MySqlCommand comando = new MySqlCommand(query, obetoconexion.establecer());
            comando.Parameters.AddWithValue("@search", search);
            MySqlDataAdapter data = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            if (tabla.Rows.Count > 0)
            {
                // Si se encontraron coincidencias, muestra los resultados
                dataGridView1.DataSource = tabla;
            }
            else
            {
                // Si no se encontraron coincidencias, muestra todos los datos de la tabla
                query = "SELECT * FROM ctl_asistencia;";
                comando = new MySqlCommand(query, obetoconexion.establecer());
                MySqlDataAdapter allData = new MySqlDataAdapter(comando);
                DataTable allDataTable = new DataTable();
                allData.Fill(allDataTable);
                dataGridView1.DataSource = allDataTable;
            }
        }
    }
}
