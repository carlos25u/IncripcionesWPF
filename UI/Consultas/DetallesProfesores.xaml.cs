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
    /// Interaction logic for DetallesProfesores.xaml
    /// </summary>
    public partial class DetallesProfesores : Window
    {
        public DetallesProfesores()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<ProfesoresDetalle>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProfesoresDetalleBLL.GetList(e => e.Profesores.ProfesorId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = ProfesoresDetalleBLL.GetList(e => e.Materias.MateriaId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = ProfesoresDetalleBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = ProfesoresDetalleBLL.GetList(c => c.Profesores.FechaIngreso.Date >= DesdeDataPicker.SelectedDate);

            if (HastaDataPicker.SelectedDate != null)
                listado = ProfesoresDetalleBLL.GetList(c => c.Profesores.FechaIngreso.Date <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
