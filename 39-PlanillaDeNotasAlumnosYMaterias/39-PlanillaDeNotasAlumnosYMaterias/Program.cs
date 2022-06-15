using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _39_PlanillaDeNotasAlumnosYMaterias
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Alumno> Alumnos = new List<Alumno>(); /*Se establece la lista de la alumnos antes 
                                                         pedir los datos al usuarios*/

            for (int i=0; i < 10; i++) /*Pimero se debe iniciar al FOR*/
            {
            
                Alumno a = new Alumno(); /*ANTES de pedir los datos se debe CREAR el objeto deseado*/
                Console.WriteLine("Ingrese el nombre del alumno:");
                a.Nombre = Console.ReadLine();


                Materia m = new Materia();
                Console.WriteLine("Ingrese el nombre de la materia:");
                m.nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del alumno:");
                m.notas.Add(Convert.ToInt32(Console.ReadLine()));
                

                a.materias.Add(m);
                Alumnos.Add(a);
            }
            foreach(Alumno a in Alumnos)
            {
                Console.WriteLine(a.Nombre);

                foreach (Materia m in a.materias)
                {
                    Console.WriteLine("Promedio por Materia", m.materia);
                    Console.WriteLine(m.CalcularProm());
                }
                Console.WriteLine("Promedio General");
                Console.WriteLine(a.CalcPromGral());
            }
        }
    }
}
