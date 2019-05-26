using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp3.BLL
{
    public class Estudiante
    {

        public string NombreEstudiante { get ; set; }
        public string Matricula { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Estudiante()
        {
            NombreEstudiante = String.Empty;
            Matricula = string.Empty;
            FechaIngreso = DateTime.Now;
        }

        public Estudiante(string nombre,string matricula, DateTime fecha)
        {
            NombreEstudiante = nombre;
            Matricula = matricula;
            FechaIngreso = fecha;
        }

        public string Agregar()
        {
            string estudiante;
            estudiante = $"Estudiante: {NombreEstudiante} Matricula: {Matricula} Fecha de Ingreso: {FechaIngreso}";

            return estudiante;
        }
    }
}
