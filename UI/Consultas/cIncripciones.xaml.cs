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
    /// Interaction logic for cIncripciones.xaml
    /// </summary>
    public partial class cIncripciones : Window
    {
        public cIncripciones()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Incripciones>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = IncripcionesBLL.GetList(e => e.IncripcionId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = IncripcionesBLL.GetList(e => e.Estudiantes.EstudianteId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 2:
                        listado = IncripcionesBLL.GetList(e => e.Cursos.CursoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = IncripcionesBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = IncripcionesBLL.GetList(c => c.Fecha.Date >= DesdeDataPicker.SelectedDate);

            if (HastaDataPicker.SelectedDate != null)
                listado = IncripcionesBLL.GetList(c => c.Fecha.Date <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
