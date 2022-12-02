using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Persona
    {
        private string dni;
        private string nombre;
        private int edad;
        private string direccion;

        public Persona(string dni, string nombre, int edad, string direccion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            this.direccion = direccion;
        }

        public string GetDni() { return this.dni; }
        public string GetNombre() { return this.nombre; }
        public int GetEdad() { return this.edad; }
        public string GetDireccion() { return this.direccion; }
        public void SetDni(string dni) { this.dni = dni; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetEdad(int edad) { this.edad = edad; }
        public void SetDireccion(string direccion) { this.direccion = direccion; }


    }
}
