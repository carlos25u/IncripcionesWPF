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

namespace IncripcionesWPF.UI.Consultas
{
    /// <summary>
    /// Interaction logic for cEstudiantes.xaml
    /// </summary>
    public partial class cEstudiantes : Window
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Estudiantes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = EstudiantesBLL.GetList(e => e.EstudianteId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = EstudiantesBLL.GetList(e => e.Nombre.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 2:
                        listado = EstudiantesBLL.GetList(e => e.Apellido.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 3:
                        listado = EstudiantesBLL.GetList(e => e.Correo.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = EstudiantesBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = EstudiantesBLL.GetList(c => c.FechaNacimiento.Date >= DesdeDataPicker.SelectedDate);

            if (HastaDataPicker.SelectedDate != null)
                listado = EstudiantesBLL.GetList(c => c.FechaNacimiento.Date <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;

        }
    }
}
