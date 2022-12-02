using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    internal class Paciente : Persona
    {
        private int diasIngresado;
        private List<string> diagnosticos;
        private List<char> pronosticos;
        private List<string> medicaciones;
        private List<string> pruebas;

        public Paciente(string dni, string nombre, int edad, string direccion, int diasIngresado) : base(dni, nombre, edad, direccion)
        {
            this.diasIngresado = diasIngresado;
            this.diagnosticos = new List<string>();
            this.pronosticos = new List<char>();
            this.medicaciones = new List<string>();
            this.pruebas = new List<string>();
        }

        public int GetDiasIngresado() { return this.diasIngresado; }
        public List<string> GetDiagnosticos() { return this.diagnosticos; }
        public List<char> GetPronosticos() { return this.pronosticos; }
        public List<string> GetMedicaciones() { return this.medicaciones; }
        public List<string> GetPruebas() { return this.pruebas; }
        public void SetDiasIngresado(int diasIngresado) { this.diasIngresado = diasIngresado; }
        public void SetDiagnosticos(List<string> diagnosticos) { this.diagnosticos = diagnosticos; }
        public void SetPronosticos(List<char> pronosticos) { this.pronosticos = pronosticos; }
        public void SetMedicaciones(List<string> medicaciones) { this.medicaciones = medicaciones; }
        public void SetPruebas(List<string> pruebas) { this.pruebas = pruebas; }

        public void RecibirDiagnostico(string diagnostico)
        {
            if (!this.diagnosticos.Contains(diagnostico))
                this.diagnosticos.Add(diagnostico);
            else
                throw new Exception("Este diagnostica ya se ha recibido.");
        }

        public void RecibirPronostico(char pronostico)
        {
            this.pronosticos.Add(pronostico);
        }

        public void RecibirPrueba(string prueba)
        {
            this.pruebas.Add(prueba);
        }
    }
}
