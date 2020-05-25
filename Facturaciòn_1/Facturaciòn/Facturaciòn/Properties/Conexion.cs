using System;
using System.Data;
using Gtk;
using MySql.Data.MySqlClient;

namespace Facturaciòn.Properties
{
    public class conexion
    {
        #region Variables y Atributos

        private String cadena = String.Empty;
        public MySqlConnection con { get; set; }
        public MySqlCommand msc { get; set; }
        public IDataReader idr { get; set; }

        #endregion

        #region Constructor

        public conexion()
        {
            cadena = cadenaConexion();
            con = new MySqlConnection();
            msc = new MySqlCommand();
        }

        #endregion

        public string cadenaConexion()
        {
            MySqlConnectionStringBuilder scb = new MySqlConnectionStringBuilder();
            scb.Server = "localhost";
            scb.UserID = "root";
            scb.Database = "Inventario y facturación ";
            scb.Password = "isi1234";

            return scb.ConnectionString;
        }

        #region Metodos
        public void Open()
        {
            if (con.State == ConnectionState.Open)
            {
                return;
            }
            else
            {
                con.ConnectionString = cadena;

                try
                {
                    con.Open();
                    Console.WriteLine("Conectado a la base de Datos!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
        public void Close()
        {
            if (con.State == ConnectionState.Closed)
            {
                return;
            }
            else
            {
                con.Close();
            }
        }

        public Int32 Ejecutar(CommandType ct, String consulta)
        {
            int retorno = 0;
            msc.Connection = con;
            msc.CommandType = ct;
            msc.CommandText = consulta;

            try
            {
                retorno = msc.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            return retorno;
        }

        public IDataReader Leer(CommandType ct, String consulta)
        {
            idr = null;
            msc.Connection = con;
            msc.CommandType = ct;
            msc.CommandText = consulta;

            try
            {
                idr = msc.ExecuteReader();
            }
            catch
            {
                throw;
            }
            return idr;
        }
        #endregion
        class MainClass
        {


            public class Conexion
    {
        public Conexion()
        {
        }
    }
}
    }
}
