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

            if (string.IsNullOrWhiteSpace(CorreoTextBox.Text))
            {
                TelefonoTextBox.Focus();
                mensajeValidacion = "El Correo no puede estar vacio";
            }

            if(mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }

        private bool ValidarCorreo()
        {
            var paso = EstudiantesBLL.ExisteCorreo(CorreoTextBox.Text);
            String mensajeValidacion = "";

            if (paso)
            {
                CorreoTextBox.Focus();
                mensajeValidacion = "El Correo Existe";
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

            if (!ValidarCorreo())
                return;

            var paso = EstudiantesBLL.Guardar(estudiante);
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (EstudiantesBLL.Eliminar(Utilidades.ToInt(EstudianteIdTextBox.Text)))
            {
                Limpiar();
                MessageBox.Show("Registro Eliminado", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
