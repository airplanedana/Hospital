using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Manager
    {
        List<Hospital> hospitales = new List<Hospital>();

        /* 
         * TODO: crear diccionario de pruebas
         */

        public void Iniciar()
        {
            hospitales.Add(new Hospital("Hospital 1", "Barcelona"));

            bool repetir = true;

            while (repetir)
            {
                // Mostrar menu con opciones
                int opc = 0;

                while (opc != 1 && opc != 2 && opc != 3 && opc != 4 && opc != 5 && opc != 6)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bienvenido. Que le gustaria hacer? ");
                    Console.WriteLine("1. Ingresar a un nuevo paciente.");
                    Console.WriteLine("2. Dar el alta a un paciente existente.");
                    Console.WriteLine("3. Realizar una prueba a un paciente.");
                    Console.WriteLine("4. Asignar medicación a un paciente.");
                    Console.WriteLine("5. Notificar muerte.");
                    Console.WriteLine("6. Salir");

                    opc = Convert.ToInt32(Console.ReadLine());
                }
                try
                {
                    switch (opc)
                    {
                        case 1:
                            Console.WriteLine("Cuantos dias será ingresado? ");
                            int dias = Convert.ToInt32(Console.ReadLine());

                            Paciente paciente = hospitales[0].IngresarPaciente(CrearPersona(), dias);
                            Console.WriteLine("Paciente ingresado correctamente");

                            if (paciente != null)
                            {
                                Console.WriteLine("Indique el diagnostico: ");
                                string diagnostico = Console.ReadLine();

                                Console.WriteLine("Indique el pronostico: (G/M/L - grave/medio/leve)");
                                char pronostico = Convert.ToChar(Console.ReadLine());

                                paciente.RecibirDiagnostico(diagnostico);
                                paciente.RecibirPronostico(pronostico);

                                Console.WriteLine("Diagnostico y pronostico recibidos");
                            }
                            break;

                        case 2:
                            hospitales[0].DarAltaPaciente(ObtenerPaciente());
                            Console.WriteLine("Paciente dado de alta correctamente");
                            break;

                        case 3:
                            RealizarPrueba(ObtenerPaciente());
                            Console.WriteLine("Prueba realizada correctamente");
                            break;

                        case 4:
                            AsignarMedicacion(ObtenerPaciente());
                            Console.WriteLine("Medicacion asignada correctamente");
                            break;

                        case 5:
                            NotificarMuerte(ObtenerPaciente());
                            Console.WriteLine("Muerte notificada correctamente");
                            break;

                        case 6:
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
                Console.WriteLine("Pacientes ingresados actualmente: ");
                foreach (Paciente paciente in hospitales[0].GetPacientes())
                {
                    Console.WriteLine(paciente.GetDni() + " - " + paciente.GetNombre());
                    foreach (string diagnostico in paciente.GetDiagnosticos())
                    {
                        Console.Write(diagnostico + "\t");
                    }
                    Console.WriteLine();
                }
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

        private void RealizarPrueba(Paciente paciente)
        {
            if (paciente != null)
            {
                string prueba;

                Console.WriteLine("Indique que prueba realizar: ");
                prueba = Console.ReadLine();

                // Añadir prueba a diccionario

                paciente.RecibirPrueba(prueba);
            }
            else
                throw new Exception("Paciente no encontrado.");
        }
        private Medicamento CrearMedicamento()
        {
            string nombre, indicaciones, efectosSecundarios, dosis, efectosAdversos;
            double precio;

            Console.WriteLine("Por favor, introduzca los datos del Medicamento a asignar: ");
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Indicaciones: ");
            indicaciones = Console.ReadLine();
            Console.WriteLine("Efectos secundarios: ");
            efectosSecundarios = Console.ReadLine();
            Console.WriteLine("Dosis: ");
            dosis = Console.ReadLine();
            Console.WriteLine("Efectos adversos: ");
            efectosAdversos = Console.ReadLine();
            Console.WriteLine("Precio: ");
            precio = Convert.ToDouble(Console.ReadLine());

            return new Medicamento(nombre, indicaciones, efectosSecundarios, dosis, efectosAdversos, precio);
        }

        private void AsignarMedicacion(Paciente paciente)
        {
            if (paciente != null)
            {
                Medicamento medicacion = CrearMedicamento();

                paciente.RecibirMedicacion(medicacion);
            }
            else
                throw new Exception("Paciente no encontrado.");
        }

        private void NotificarMuerte(Paciente paciente)
        {
            if (paciente != null)
            {
                string fecha = "";

                Console.WriteLine("Ingrese la fecha de muerte: ");
                fecha = Console.ReadLine();
                
                hospitales[0].IngresarCuerpo(paciente, fecha);

            }
            else
                throw new Exception("Paciente no encontrado.");
        }
    }
}
