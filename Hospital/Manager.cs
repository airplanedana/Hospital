using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Manager
    {
        List<Hospital> hospitales = new List<Hospital>();

        public void Iniciar()
        {
            hospitales.Add(new Hospital("Hospital 1", "Barcelona"));

            // Mostrar menu con opciones
            int opc = 0;

            while (opc != 1 && opc != 2 && opc != 3 && opc != 4 && opc != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido. Que le gustaria hacer? ");
                Console.WriteLine("1. Ingresar a un nuevo paciente.");
                Console.WriteLine("2. Dar el alta a un paciente existente.");
                Console.WriteLine("3. Realizar una prueba a un paciente.");
                Console.WriteLine("4. Asignar medicación a un paciente.");
                Console.WriteLine("5. Dar el alta a un paciente por muerte o curado.");

                opc = Convert.ToInt32(Console.ReadLine());
            }

            switch (opc)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                default:
                    break;
            }
        }
    }
}
