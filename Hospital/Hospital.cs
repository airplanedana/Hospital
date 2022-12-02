using System;
using System.Collections.Generic;

namespace Hospital
{
    internal class Hospital
    {
        private string nombre;
        private string ubicacion;
        private int camasDisponibles;
        private int camasOcupadas;
        private List<Paciente> pacientes;

        public Hospital(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.camasDisponibles = 20;
            this.camasOcupadas = 0;
            this.pacientes = new List<Paciente>();
        }

        public string GetNombre() { return this.nombre; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public string GetUbicacion() { return this.ubicacion; }
        public void SetUbicacion(string ubicacion) { this.ubicacion = ubicacion;}
        public int GetCamasDisponibles() { return this.camasDisponibles; }
        public void SetCamasDisponibles(int camasDisponibles) { this.camasDisponibles = camasDisponibles; }
        public int GetCamasOcupadas() { return this.camasOcupadas; }
        public void SetCamasOcupadas(int camasOcupadas) { this.camasOcupadas = camasOcupadas; }
        public List<Paciente> GetPacientes() { return this.pacientes; }
        public void SetPacientes(List<Paciente> pacientes) { this.pacientes = pacientes; }



    }
}
