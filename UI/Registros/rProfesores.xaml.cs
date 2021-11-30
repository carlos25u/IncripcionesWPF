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
    /// Interaction logic for rProfesores.xaml
    /// </summary>
    public partial class rProfesores : Window
    {
        private Profesores profesor = new Profesores();
        public rProfesores()
        {
            InitializeComponent();
            this.DataContext = profesor;

            AreaComboBox.ItemsSource = AreasBLL.GetAreas();
            AreaComboBox.SelectedValuePath = "AreaId";
            AreaComboBox.DisplayMemberPath = "Descripcion";

            MateriaComboBox.ItemsSource = MateriasBLL.GetMaterias();
            MateriaComboBox.SelectedValuePath = "MateriaId";
            MateriaComboBox.DisplayMemberPath = "Nombre";
        }
        private bool Validar()
        {
            String mensajeValidacion = "";

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                NombreTextBox.Focus();
                mensajeValidacion = "El nombre no puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(ApellidoTextBox.Text))
            {
                ApellidoTextBox.Focus();
                mensajeValidacion = "El apellido no  puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(direccionTextBox.Text))
            {
                direccionTextBox.Focus();
                mensajeValidacion = "La direccion no  puede estar vacio";
            }

            if (telefonoTextBox.Text.Length == 0)
            {
                telefonoTextBox.Focus();
                mensajeValidacion = "El telefono no  puede estar vacio";
            }

            if (celularTextBox.Text.Length == 0)
            {
                celularTextBox.Focus();
                mensajeValidacion = "El celular no  puede estar vacio";
            }

            if (FechaingresoDatePicker.Text.Length == 0)
            {
                FechaingresoDatePicker.Focus();
                mensajeValidacion = "La fecha de ingreso no  puede estar vacio";
            }

            if (FechaNacimientoDatePicker.Text.Length == 0)
            {
                FechaNacimientoDatePicker.Focus();
                mensajeValidacion = "La fecha de nacimiento no  puede estar vacio";
            }

            if (string.IsNullOrWhiteSpace(CorreoTextBox.Text))
            {
                CorreoTextBox.Focus();
                mensajeValidacion = "El correo no  puede estar vacio";
            }

            if (AreaComboBox.Text.Length == 0)
            {
                AreaComboBox.Focus();
                mensajeValidacion = "Debe de seleccionar una area";
            }

            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return mensajeValidacion.Length == 0;
        }

        private bool ValidarCorreo()
        {
            var paso = ProfesoresBLL.ExisteCorreo(CorreoTextBox.Text);
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

        private bool ValidarDetalle()
        {
            String mensajeValidacion = "";

            if (MateriaComboBox.Text.Length == 0)
            {
                MateriaComboBox.Focus();
                mensajeValidacion = "Debes seleccionar una materia";
            }
            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return mensajeValidacion.Length == 0;
        }
        private bool ValidarRemover()
        {
            String mensajeValidacion = "";

            if (DetalleDataGrid.SelectedItem == null)
            {
                DetalleDataGrid.Focus();
                mensajeValidacion = "Debes seleccionar una materia para remover";
            }
            if (mensajeValidacion.Length > 0)
            {
                MessageBox.Show(mensajeValidacion, "Fallo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return mensajeValidacion.Length == 0;
        }

        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = profesor;
        }

        private void Limpiar()
        {
            this.profesor = new Profesores();
            this.DataContext = profesor;

            FechaingresoDatePicker.SelectedDate = DateTime.Now;

        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Profesores encontrado = ProfesoresBLL.Buscar(Utilidades.ToInt(ProfesorIdTextBox.Text));

            if (encontrado != null)
            {
                profesor = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("El profesor no existe", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarDetalle())
                return;
            profesor.Detalle.Add(new ProfesoresDetalle
            {
                ProfesorId = profesor.ProfesorId,
                Materias = (Materias)MateriaComboBox.SelectedItem
            });

            Cargar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidarRemover())
                return;
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                profesor.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
                Cargar();
            }
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validar())
                return;

            if (!ValidarCorreo())
                return;
           
            var paso = ProfesoresBLL.Guardar(profesor);

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

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProfesoresBLL.Eliminar(Utilidades.ToInt(ProfesorIdTextBox.Text)))
            {
                MessageBox.Show("Se elimino con exito", "Exito", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
