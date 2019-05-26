using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp3.BLL
{
    public class Poligono
    {
        private int Lados;
        private float Alto;
        private float Largo;
        private float Ancho;
        private float Radio;


        public int lados {
            get
            {
                return Lados;
            }
            set
            {
                if (lados <= 0)
                    lados = 1;
                    Lados = value;

            }
        }
        public float alto
        {
            get
            {
                return Alto;
            }
            set
            {
                if (alto <= 0)
                    alto = 1;
                Alto = value;

            }
        }
        public float largo
        {
            get
            {
                return Largo;
            }
            set
            {
                if (largo <= 0)
                    largo = 1;
                Largo = value;

            }
        }
        public float ancho
        {
            get
            {
                return Ancho;
            }
            set
            {
                if (ancho <= 0)
                    ancho = 1;
                Ancho = value;

            }
        }
        public float radio
        {
            get
            {
                return Radio;
            }
            set
            {
                if (radio <= 0)
                    radio = 1;
                Radio = value;

            }
        }

        public Poligono(int lado,float largo, float ancho,float alto,float radio)
        {
            this.Lados = lado;
            this.Largo = largo;
            this.Ancho = ancho;
            this.Alto = alto;
            this.Radio = radio;
        }

        public Poligono(float largo, float ancho)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        public Poligono(float radio)
        {
            Radio = radio;
        }

        public Poligono(int lados)
        {
            Lados = lados;
        }

        public override string ToString()
        {
            String texto = "";
            texto += "Ancho: " + Ancho.ToString() + "Largo" + Largo.ToString()
            + " Alto: " + Alto.ToString() + "Radio: " + Radio.ToString() + "Lado : " + Lados.ToString();
            return texto;
        }
    }
}
