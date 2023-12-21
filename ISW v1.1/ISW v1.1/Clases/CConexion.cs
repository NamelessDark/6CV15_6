using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISW_v1._1.Clases
{
     class CConexion
    {


        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "labor";
        static string usuario = "root";
        static string password = "";
        static string port = "3306";

         static string conecct = "server =" + servidor + ";" + "port =" + port + ";" + "userid =" + usuario + ";" + "password =" + password + ";" + "database =" + bd + ";";



        public MySqlConnection establecer()
        {
            conex.Close();
            try
            {

                conex.ConnectionString = conecct;
                conex.Open();
             //   MessageBox.Show("good");


            }
            catch (MySqlException e)
            {

                MessageBox.Show("error" + e.ToString());

            }

            return conex;
        }



    }
}
