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

            manager.Iniciar();
        }
    }
}
