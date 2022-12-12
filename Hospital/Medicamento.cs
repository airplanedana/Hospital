using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Medicamento
    {
        private string nombre;
        private string indicaciones;
        private string efectosSecundarios;
        private string dosis;
        private string efectosAdversos;
        private double precio;

        public Medicamento(string nombre)
        {
            this.nombre = nombre;
            this.indicaciones = "";
            this.efectosSecundarios = "";
            this.dosis = "";
            this.efectosAdversos = "";
            this.precio = 0;
        }

        public Medicamento(string nombre, string indicaciones, string efectosSecundarios, string dosis, string efectosAdversos, double precio) : this(nombre)
        {
            this.indicaciones = indicaciones;
            this.efectosSecundarios = efectosSecundarios;
            this.dosis = dosis;
            this.efectosAdversos = efectosAdversos;
            this.precio = precio;
        }

        public string GetNombre() { return this.nombre; }
        public string GetIndicaciones() { return this.indicaciones; }
        public string GetEfectosSecundarios() { return this.efectosSecundarios; }
        public string GetDosis() { return this.dosis; }
        public string GetEfectosAdversos() { return this.efectosAdversos; }
        public double GetPrecio() { return this.precio; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetIndicaciones(string indicaciones) { this.indicaciones = indicaciones; }
        public void SetEfectosSecundarios(string efectosSecundarios) { this.efectosSecundarios = efectosSecundarios; }
        public void SetDosis(string dosis) { this.dosis = dosis; }
        public void SetEfectosAdversos(string efectosAdversos) { this.efectosAdversos = efectosAdversos; }
        public void SetPrecio(double precio) { this.precio = precio; }


    }
}
