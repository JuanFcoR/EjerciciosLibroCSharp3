using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLibroCSharp3.BLL
{
    public class Productos
    {
        public struct Producto
        {
            public static string Nombre;
            public static int Codigo;
            public static DateTime FechaVencimiento;
            public static int Cantidad;
            public static double Precio;

            public void agregarProductos(string nombre, int codigo, DateTime fecha, int cantidad, double precio)
            {
                Producto.Nombre = nombre;
                Producto.Codigo = codigo;
                Producto.FechaVencimiento = fecha;
                Producto.Cantidad = cantidad;
                Producto.Precio = precio;
            }

            public string Listar()
            {
                string lista;
                lista = ($"Nombre: {Producto.Nombre} Codigo: {Producto.Codigo} Fecha de vencimiento: {Producto.FechaVencimiento} Cantidad: {Producto.Cantidad} Precio: {Producto.Precio}");
                return lista;
            }
            

        }

        

    }
}
