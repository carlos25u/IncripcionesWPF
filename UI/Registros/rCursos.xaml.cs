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
    /// Interaction logic for rCursos.xaml
    /// </summary>
    public partial class rCursos : Window
    {
        private Cursos cursos = new Cursos();

        public rCursos()
        {
            InitializeComponent();
            this.DataContext = cursos;

            MateriaComboBox.ItemsSource = MateriasBLL.GetMaterias();
            MateriaComboBox.SelectedValuePath = "MateriaId";
            MateriaComboBox.DisplayMemberPath = "Nombre";
        }
        private void Cargar()
        {
            this.DataContext = null;
            this.DataContext = cursos;
        }
        private void Limpiar()
        {
            this.cursos = new Cursos();
            this.DataContext = cursos;
        }
        private bool Validar()
        {
            String mensajeValidacion = "";

            if (string.IsNullOrWhiteSpace(CodigoTextBox.Text))
            {
                CodigoTextBox.Focus();
                mensajeValidacion = "El codigo no puede estar vacio";
            }
            if (NombreTextBox.Text.Length == 0)
            {
                NombreTextBox.Focus();
                mensajeValidacion = "El nombre no  puede estar vacio";
            }

            if (MateriaComboBox.SelectedIndex.ToString() == null)
            {
                MateriaComboBox.Focus();
                mensajeValidacion = "Debes seleccionar un elemnto de la lista";
            }
            return mensajeValidacion.Length == 0;

        }
        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            Cursos encontrado = CursosBLL.Buscar(Utilidades.ToInt(CursoIdTextBox.Text));
            if (encontrado != null)
            {
                cursos = encontrado;
                Cargar();
            }
            else
            {
                Limpiar();
                MessageBox.Show("No existe en la base de datos", "Fallo",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            cursos.Detalle.Add(new CursosDetalle
            {
                CursoId = cursos.CursoId,
                Materias = (Materias)MateriaComboBox.SelectedItem

            });
            Cargar();
        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {
            if (DetalleDataGrid.Items.Count >= 1 && DetalleDataGrid.SelectedIndex <= DetalleDataGrid.Items.Count - 1)
            {
                cursos.Detalle.RemoveAt(DetalleDataGrid.SelectedIndex);
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
            var paso = CursosBLL.Guardar(cursos);

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
            if (CursosBLL.Eliminar(Utilidades.ToInt(CursoIdTextBox.Text)))
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
