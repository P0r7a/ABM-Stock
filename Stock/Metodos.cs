using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Stock
{
    class Metodos
    {
        //Metodos generales para el programa

        //cargo la cadena de conexion en el string
        public static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Proyecto.accdb");
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath;


        //Metodo para lectura de la base de datos recibiendo la consulta SQL
        public DataTable connR(string sSQL)
        {          
            //instancio el objeto Connection y le asigno la cadena
            OleDbConnection cnn = new OleDbConnection(cadenaConexion);
            //me aseguro que el DataSet este vacio (por alguna secion anterior)
            if (cnn.State == ConnectionState.Open) cnn.Close(); // Si la conexion quedo abierta la cierro
            //abro la conexion
            cnn.Open();
            //instancio el objeto DataAdapter y le asigno la consulta y la conexion
            OleDbDataAdapter da = new OleDbDataAdapter(sSQL, cnn);
            //instancio el objeto DataTable
            DataTable dt = new DataTable();
            //Lleno el DataTable Con los datos
            //recibidos de la Base de datos del DataAdapter
            da.Fill(dt);
            //Cierro la conexion
            cnn.Close();
            //libero la memoria
            cnn.Dispose();
            //retorno el DataTable
            return (dt);
        }

        //Metodo para escritura en la base de datos recibiendo la consulta SQL
        public int connW(string sSQL)
        {
            //instancio el objeto Connection y le asigno la cadena
            OleDbConnection cnn = new OleDbConnection(cadenaConexion);
            //abro la conexion
            cnn.Open();
            //instancio el objeto Command y le asigno la consulta y la conexion
            OleDbCommand cmd = new OleDbCommand(sSQL,cnn);
            //Guardo el ExecuteNonQuery en la int resultado
            int resultado = cmd.ExecuteNonQuery();
            //cierro la conexion
            cnn.Close();
            //libero la memoria
            cnn.Dispose();
            //retorno el resultado
            return(resultado);
        }


        //Metodo para verificar un uruario existente
        //recibiendo la consulta
        public bool Ex(string sSQL) 
        {
            //Llamo el metodo de lectura de la base de datos
            DataTable dt = connR(sSQL);
            //Verifico si hay alguna conincidencia
            if (dt.Rows.Count > 0)
            {
                //Si la hay retorno true
                return (true);
            }
            else
            {
                //Si la hay retorno false
                return (false);
            }
        }


        public List<string> ConnR_DR(string sSQL, string N ) 
        {
            //instancio el objeto Connection y le asigno la cadena
            OleDbConnection cnn = new OleDbConnection(cadenaConexion);
            //abro la conexion
            cnn.Open();
            //instancio el objeto Command y le asigno la consulta y la conexion
            OleDbCommand cmd = new OleDbCommand(sSQL, cnn);
            OleDbDataReader DR = cmd.ExecuteReader();

            List<string> columnaEle = new List<string>();

            

            while (DR.Read())
            {
                columnaEle.Add(DR[N].ToString());
            }

            //cierro la conexion
            cnn.Close();
            //libero la memoria
            cnn.Dispose();
            //retorno el resultado
            return columnaEle;
        }

        public bool SiNo(string msg) 
        {
            using (var confirmationForm = new frmSiNo(msg))
            {
                confirmationForm.ShowDialog();

                if (confirmationForm.UsuarioDijoSi)
                {
                    return (true);
                }
                else
                {
                    return (false);
                }
            }
        }
        public bool CharVer(char L)
        {
            if (!((Char.IsLetterOrDigit(L)) || L == '\b'))
            {
                return(true);
            }
            else
            {
                return(false);
            }
        }
    }
}
