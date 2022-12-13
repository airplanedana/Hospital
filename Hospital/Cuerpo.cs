using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Cuerpo
    {
        private string codigo;
        private string nombre;
        private Fecha fecha;

        public Cuerpo(string codigo, string nombre, Fecha fecha)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public string GetCodigo() { return this.codigo; }
        public string GetNombre() { return this.nombre; }
        public Fecha GetFecha() { return this.fecha; }
        public void SetCodigo(string codigo) { this.codigo = codigo; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetFecha(Fecha fecha) { this.fecha = fecha; }
    }
}
