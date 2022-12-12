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
        private string fecha;

        public Cuerpo(string codigo, string nombre, string fecha)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecha = fecha;
        }

        public string GetCodigo() { return this.codigo; }
        public string GetNombre() { return this.nombre; }
        public string GetFecha() { return this.fecha; }
        public void SetCodigo(string codigo) { this.codigo = codigo; }
        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetFecha(string fecha) { this.fecha = fecha; }
    }
}
