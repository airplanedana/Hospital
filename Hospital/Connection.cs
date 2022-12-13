using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Hospital
{
    internal class Connection
    {
        private string connectionString;
        private SqlConnection conexion;

        public Connection()
        {
            connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=hospital;Integrated Security=True";
        }

        public void Start()
        {
            try
            {
                // Creamos la conexión con el connection string
                this.conexion = new SqlConnection(this.connectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void HacerQuery(string queryString)
        {
            try
            {
                // Creamos el objeto con el comando SQL
                SqlCommand query = new SqlCommand(queryString, this.conexion);

                // Abrimos la conexion
                this.conexion.Open();

                // Ejecutamos el comando y guardamos el resultado en un DataReader
                SqlDataReader resultado = query.ExecuteReader();

                while (resultado.Read())
                {
                    // Mostramos el resultado con los nombres de los campos
                    Console.WriteLine(resultado["nombre"] + ",  " + resultado["ubicacion"] + ",  " + resultado["camas_disponibles"]);
                }

                resultado.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                this.conexion.Close();
            }
        }

        public void HacerNonQuery(string queryString)
        {
            try
            {
                // Abrimos la conexion
                this.conexion.Open();

                // Creamos el objecto con el comando SQL
                SqlCommand query = new SqlCommand(queryString, this.conexion);

                int rowsAffected = query.ExecuteNonQuery();
                Console.WriteLine("Filas = " + rowsAffected);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                this.conexion.Close();
            }
        }
    }
}
