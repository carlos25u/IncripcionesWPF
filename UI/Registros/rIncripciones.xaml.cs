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
    /// Interaction logic for rIncripciones.xaml
    /// </summary>
    public partial class rIncripciones : Window
    {
        private Incripciones incripcion = new Incripciones();
        public rIncripciones()
        {
            InitializeComponent();
            this.DataContext = incripcion;

            EstudianteComboxBox.ItemsSource = EstudiantesBLL.GetEstudiantes();
            EstudianteComboxBox.SelectedValuePath = "EstudianteId";
            EstudianteComboxBox.DisplayMemberPath = "Nombre";

            CursosComboxBox.ItemsSource = CursosBLL.GetCursos();
            CursosComboxBox.SelectedValuePath = "CursoId";
            CursosComboxBox.DisplayMemberPath = "Nombre";
        }

        public void Limpiar()
        {
            this.incripcion = new Incripciones();
            this.DataContext = incripcion;

            FechaDatePicker.SelectedDate = DateTime.Now;
        }

        private bool Validar()
        {
            String mensajeValidacion = "";

            if (FechaDatePicker.Text.Length  == 0)
            {
                FechaDatePicker.Focus();
                mensajeValidacion = "La Fecha no puede estar vacio";
            }

            if (EstudianteComboxBox.Text.Length == 0)
            {
                EstudianteComboxBox.Focus();
                mensajeValidacion = "Debe de selecionar un Estudiante";
            }

            if (CursosComboxBox.Text.Length == 0)
            {
                CursosComboxBox.Focus();
                mensajeValidacion = "Debe de selecionar un Curso";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var incripcion = IncripcionesBLL.Buscar(Utilidades.ToInt(incripcionIdTextBox.Text));

            if (incripcion != null)
            {
                this.incripcion = incripcion;
            }
            else
            {
                this.incripcion = new Incripciones();
                MessageBox.Show("No se ha encontrado", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.DataContext = this.incripcion;
        }

        private void nuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = IncripcionesBLL.Guardar(incripcion);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado exitosamente", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se ha guardado exitosamente", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (IncripcionesBLL.Eliminar(Utilidades.ToInt(incripcionIdTextBox.Text)))
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
