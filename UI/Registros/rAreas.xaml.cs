using IncripcionesWPF.BLL;
using IncripcionesWPF.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IncripcionesWPF.UI.Registros
{
    /// <summary>
    /// Interaction logic for rAreas.xaml
    /// </summary>
    public partial class rAreas : Window
    {
        private Areas areas = new Areas();
        public rAreas()
        {
            InitializeComponent();
            this.DataContext = areas;
        }
        private void Limpiar()
        {
            this.areas = new Areas();
            this.DataContext = areas;
        }
        private bool Validar()
        {
            String mensajeValidacion = "";

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                DescripcionTextBox.Focus();
                mensajeValidacion = "La descripcion no puede estar vacio";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }
        private bool ValidarDescripcion()
        {
            var paso = AreasBLL.ExisteArea(DescripcionTextBox.Text);
            String mensajeValidacion = "";

            if (paso)
            {
                DescripcionTextBox.Focus();
                mensajeValidacion = "El area ya Existe!";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", 
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var areas = AreasBLL.Buscar(Utilidades.ToInt(AreaIdTextBox.Text));

            if (areas != null)
            {
                this.areas = areas;
            }
            else
            {
                this.areas = new Areas();
            }
            this.DataContext = this.areas;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            if (!ValidarDescripcion())
                return;

            var paso = AreasBLL.Guardar(areas);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (AreasBLL.Eliminar(Utilidades.ToInt(AreaIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
