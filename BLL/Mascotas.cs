using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp3.BLL
{
    public class Mascotas
    {
        public struct Dueño
        {
            private string Nombre;
            private string Cedula;
            private Mascota mascota;
            

            public struct Mascota
            {
                private string Nombre;
                private string TipoMascota;
                private string Raza;
                public Mascota(string n, string tm, string r)
                {
                    this.Nombre = n;
                    this.TipoMascota = tm;
                    this.Raza = r;
                }
            }

            public Dueño(string n,string c,string nm,string tm,string r)
            {
                this.Nombre = n;
                this.Cedula = c;
                this.mascota = new Mascota(nm,tm,r);
            }
            public string listar(string nm,string tm,string r)
            {
                string lista;
                lista = ($"Dueño: {this.Nombre} Cedula: {this.Cedula} Mascota: {nm} Tipo de Mascota: {tm} Raza: {r}");
                return lista;
            }
        }
    }
}
