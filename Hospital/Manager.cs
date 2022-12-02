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

            bool repetir = true;

            while (repetir)
            {
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
                    Console.WriteLine("5. Salir");

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                try
                {
                    switch (opc)
                    {
                        case 1:
                            hospitales[0].IngresarPaciente(CrearPersona());
                            Console.WriteLine("Paciente ingresado correctamente");
                            break;

                        case 2:
                            hospitales[0].DarAltaPaciente(ObtenerPaciente());
                            Console.WriteLine("Paciente dado de alta correctamente");
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            repetir = false;
                            break;

                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
            }
        }

        private Persona CrearPersona()
        {
            string dni, nombre, direccion;
            int edad;

            Console.WriteLine("Por favor, introduzca los datos de la Persona a ingresar: ");
            Console.WriteLine("DNI: ");
            dni = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Direccion: ");
            direccion = Console.ReadLine();

            return new Persona(dni, nombre, edad, direccion);
        }

        private Paciente ObtenerPaciente()
        {
            string dni;

            Console.WriteLine("Por favor, introduzca el DNI del paciente a buscar: ");
            dni = Console.ReadLine();

            foreach (Paciente paciente in hospitales[0].GetPacientes())
            {
                if (paciente.GetDni().Equals(dni))
                {
                    return paciente;
                }
            }

            return null;
        }
    }
}
