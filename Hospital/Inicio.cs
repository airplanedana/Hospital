using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Inicio
    {
        public static void Main(string[] args)
        {
            // Instanciamos el manager para hacer todas las gestiones
            Manager manager = new Manager();
            Connection conexion = new Connection();

            manager.Iniciar(conexion);

            conexion.HacerNonQuery("INSERT INTO hospital VALUES (1, 'Dana', 'Hola', 20, 0)");
            conexion.HacerQuery("SELECT * FROM hospital");

            conexion.HacerNonQuery("UPDATE hospital SET nombre = 'Dana Changed' WHERE id = 1");
            conexion.HacerQuery("SELECT * FROM hospital");

            conexion.HacerNonQuery("DELETE FROM hospital WHERE id = 1");
        }
    }
}
