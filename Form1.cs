using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosLibroCSharp3.BLL;

namespace EjerciciosLibroCSharp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            ProductosListBox.HorizontalScrollbar = true;
            Productos.Producto P = new Productos.Producto();
            P.agregarProductos(NombreProductoTextBox.Text,Convert.ToInt32(CodigoProductoTextBox.Text),Convert.ToDateTime(FechaVencimientoDateTimePicker.Value), Convert.ToInt32(CantidadProductoTextBox.Text),Convert.ToDouble(PrecioProductoTextBox.Text));
            ProductosListBox.Items.Add(P.Listar());
        }

        private void AgregarMascotaButton_Click(object sender, EventArgs e)
        {
            MascotasListBox.HorizontalScrollbar = true;
            Mascotas.Dueño d = new Mascotas.Dueño(NombreProductoTextBox.Text,CedulaTextBox.Text,NombreMascotaTextBox.Text,TipoMascotaTextBox.Text,RazaTextBox.Text);
            MascotasListBox.Items.Add(d.listar(NombreMascotaTextBox.Text,TipoMascotaTextBox.Text,RazaTextBox.Text));
        }

        private void CalcularInventarioTextBox_Click(object sender, EventArgs e)
        {
            Inventario.Productos P = new Inventario.Productos(Convert.ToDouble(CantArtVendTextBox.Text),Convert.ToDouble(PrecioPorunidadTextbox.Text),Convert.ToDouble(ImpuestoPorArticuloTextBox.Text),Convert.ToDouble(GastosTextBox.Text));
            CalcularInventarioListBox.Items.Add(P.Inventario());
        }

        private void AgregarEstudianteButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante(Convert.ToString(NombreEstudianteTextBox.Text),Convert.ToString(MatriculaTextBox.Text),Convert.ToDateTime(FechaIngresoDateTimePicker.Value));
            EstudianteListBox.Items.Add(estudiante.Agregar());
        }

       
    }
}
