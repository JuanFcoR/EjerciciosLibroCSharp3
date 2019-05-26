using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp3.BLL
{
    public class Inventario
    {
        public class Productos
        {
            
            private double ArtVendidos;
            private double PrecioArtVendidos;
            private double GastosArt;
            private double ImpuestoArt;

            //Constructor de la clase
            public Productos()
            {
                //Inicializando los datos de la clase
                ArtVendidos1 = 0;
                PrecioArtVendidos1 = 0;
                GastosArt1 = 0;
                ImpuestoArt1 = 0;
            }

            public Productos(double art,double precio,double Impuesto,double gastos)
            {
                //Inicializando los datos de la clase
                ArtVendidos1 = art;
                PrecioArtVendidos1 = precio;
                GastosArt1 = gastos;
                ImpuestoArt1 = Impuesto;
            }

            public double ArtVendidos1 { get => ArtVendidos; set => ArtVendidos = value; }
            public double PrecioArtVendidos1 { get => PrecioArtVendidos; set => PrecioArtVendidos = value; }
            public double ImpuestoArt1 { get => ImpuestoArt; set => ImpuestoArt = value; }
            public double GastosArt1 { get => GastosArt; set => GastosArt = value; }

            
            public string Inventario()
            {
                double ganancias = 0;
                ganancias = (ArtVendidos1 * PrecioArtVendidos) - (GastosArt1 + ImpuestoArt1);
                string inventario = $"Inventario = {ganancias}";
                return inventario;
            }
        }
    }
}
