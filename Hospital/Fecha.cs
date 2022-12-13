using System;
using System.Collections.Generic;

namespace Hospital
{
    internal class Fecha
    {
        private int año;
        private int mes;
        private int dia;
        private DateTime fecha;

        public Fecha(int año, int mes, int dia)
        {
            this.año = año;
            this.mes = mes;
            this.dia = dia;
            this.fecha = new DateTime(año, mes, dia);
        }

        public int GetAño() { return this.año; }
        public int GetMes() { return this.mes; }
        public int GetDia() { return this.dia; }
        public void SetAño(int año) { this.año = año; }
        public void SetMes(int mes) { this.mes = mes; }
        public void SetDia(int dia) { this.dia = dia; }

        public override string ToString()
        {
            return this.fecha.ToString("dd/M/yyyy");
        }
    }
}
