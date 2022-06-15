using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _39_PlanillaDeNotasAlumnosYMaterias
{
    class Alumno
    {
        public string Nombre { get; set; }

        public List<Materia>materias { get; set; }

        public decimal CalcPromGral()
        {
            decimal aux = 0;
            foreach (Materia M in materias)
            {
                aux += M.CalcularProm();
            }
            return aux / materias.Count;
        }
    }
}
