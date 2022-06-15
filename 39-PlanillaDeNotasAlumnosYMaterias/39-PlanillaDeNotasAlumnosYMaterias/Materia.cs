using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _39_PlanillaDeNotasAlumnosYMaterias
{
    class Materia
    {
        internal int materia;

        public string nombre { get; set; }

        public List<decimal> notas { get; set; }

        public decimal CalcularProm()
        {
            decimal aux = 0;
            foreach(decimal x in notas)
            {
                aux += x;
            }
            return aux / notas.Count;
        }
        public Materia()
        {
            this.notas = new List<decimal>();
        }
    }
}
