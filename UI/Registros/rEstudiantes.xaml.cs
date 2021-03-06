using IncripcionesWPF.BLL;
using IncripcionesWPF.Entidades;
using System;
using System.Windows;

namespace IncripcionesWPF.UI.Registros
{
    /// <summary>
    /// Interaction logic for rEstudiantes.xaml
    /// </summary>
    public partial class rEstudiantes : Window
    {
        private Estudiantes estudiante = new Estudiantes();
        public rEstudiantes()
        {
            InitializeComponent();
            this.DataContext = estudiante;
        }

        private void Limpiar()
        {
            this.estudiante = new Estudiantes();
            this.DataContext = estudiante;
        }

        private bool Validar()
        {
            String mensajeValidacion = "";


            if (FechaNacimientoDatePicker.Text.Length == 0)
            {
                FechaNacimientoDatePicker.Focus();
                mensajeValidacion = "La fecha no puede estar vacia";
            }

            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                nombreTextBox.Focus();
                mensajeValidacion = "El nombre no puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                ApellidoTextBox.Focus();
                mensajeValidacion = "El Apellido no puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                ApellidoTextBox.Focus();
                mensajeValidacion = "La direccion no puede estar vacia";
            }

            if (string.IsNullOrWhiteSpace(TelefonoTextBox.Text))
            {
                TelefonoTextBox.Focus();
                mensajeValidacion = "El telefono no puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(CelularTextBox.Text))
            {
                CelularTextBox.Focus();
                mensajeValidacion = "El celular no puede estar vacio";
            }
            if (CelularTextBox.Text.Length != 13)
            {
                CelularTextBox.Focus();
                mensajeValidacion = "Debe de darle formato al celular";
            }
            if (string.IsNullOrWhiteSpace(CorreoTextBox.Text))
            {
                TelefonoTextBox.Focus();
                mensajeValidacion = "El Correo no puede estar vacio";
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
            var estudiantes = EstudiantesBLL.Buscar(Utilidades.ToInt(EstudianteIdTextBox.Text));

            if (estudiantes != null)
            {
                this.estudiante = estudiantes;
            }
            else
            {
                this.estudiante = new Estudiantes();
            }
            this.DataContext = this.estudiante;
        }

        private void nuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void guardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            var paso = EstudiantesBLL.Guardar(estudiante);
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

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (EstudiantesBLL.Eliminar(Utilidades.ToInt(EstudianteIdTextBox.Text)))
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
        private void CelularTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 48 && ascci <= 57 ||ascci == 45)
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Este caracter no es permitido!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private void TelefonoTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {

            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));

            if (ascci >= 48 && ascci <= 57 || ascci == 45) 
                e.Handled = false;
            else
            {
                e.Handled = true;
                MessageBox.Show("Este caracter no es permitido!", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }
    }
}
