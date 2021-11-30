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
    /// Interaction logic for rMaterias.xaml
    /// </summary>
    public partial class rMaterias : Window
    {
        private Materias materias = new Materias();
        public rMaterias()
        {
            InitializeComponent();
            this.DataContext = materias;    
        }
        private bool Validar()
        {
            String mensajeValidacion = "";
            if (string.IsNullOrWhiteSpace(CodigoMateriaTextBox.Text))
            {
                CodigoMateriaTextBox.Focus();
                mensajeValidacion = "El codigo de la materia no puede estar vacio";
            }
            if (string.IsNullOrWhiteSpace(NombreMateriaTextBox.Text))
            {
                NombreMateriaTextBox.Focus();
                mensajeValidacion = "El nombre de la materia no debe estar vacio";
            }
            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return mensajeValidacion.Length == 0;
        }
        private bool ValidarMateria()
        {
            var paso = MateriasBLL.ExisteCodigo(CodigoMateriaTextBox.Text);
            String mensajeValidacion = "";

            if (paso)
            {
                CodigoMateriaTextBox.Focus();
                mensajeValidacion = "Este codigo de la materia ya existe!";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }
        private bool VAlidarNombre()
        {
            var paso = MateriasBLL.ExisteNombre(NombreMateriaTextBox.Text);
            String mensajeValidacion = "";

            if (paso)
            {
                NombreMateriaTextBox.Focus();
                mensajeValidacion = "Ya existe esta materia!";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }
        public void Limpiar()
        {
            this.materias = new Materias();
            this.DataContext = materias;
        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var materias = MateriasBLL.Buscar(Utilidades.ToInt(MateriaIdTextBox.Text));
            if (materias != null)
            {
                this.materias = materias;
            }
            else
            {
                this.materias = new Materias();
                MessageBox.Show("No se ha encontrado", "Error", 
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.DataContext = this.materias;
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;
            if (!ValidarMateria())
                return;
            if(!VAlidarNombre())
                return;

            var paso = MateriasBLL.Guardar(this.materias);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado exitosamente", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se ha guardado exitosamente", "Error", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (MateriasBLL.Eliminar(Utilidades.ToInt(MateriaIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Se ha eliminado exitosamente", "Exito",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se ha eliminado exitosamente", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
