using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Datos
{
    public class DBConnection
    {
        public SqlConnection con;

        public DBConnection()
        {
            string cadena = "Data Source=DESKTOP-DQVMASA;Initial Catalog=SecureTechSolutions;Integrated Security=True;Persist Security Info=False;Pooling=False;Multiple Active Result Sets=False;Encrypt=False;Trust Server Certificate=False;Command Timeout=0";
            con = new SqlConnection(cadena);
        }

        public SqlConnection AbrirConexion()
        {
            con.Open();
            return con;
        }

        public void CerrarConexion()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //probar conexion
        public static void Probar()
        {
            try
            {
                DBConnection db = new DBConnection();
                SqlConnection con = db.AbrirConexion();

                SqlCommand cmd = new SqlCommand("SELECT 1", con);
                int resultado = (int)cmd.ExecuteScalar();

                db.CerrarConexion();

                Console.WriteLine("Conexion OK 👍 Resultado: " + resultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion ❌ " + ex.Message);
            }
        }
    }
}
