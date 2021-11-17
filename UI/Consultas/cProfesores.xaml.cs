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
    /// Interaction logic for cProfesores.xaml
    /// </summary>
    public partial class cProfesores : Window
    {
        public cProfesores()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Profesores>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProfesoresBLL.GetList(e => e.ProfesorId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = ProfesoresBLL.GetList(e => e.Nombres.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 2:
                        listado = ProfesoresBLL.GetList(e => e.Apellidos.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;

                    case 3:
                        listado = ProfesoresBLL.GetList(e => e.Correo.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                }
            }
            else
            {
                listado = ProfesoresBLL.GetList(c => true);
            }

            if (DesdeDataPicker.SelectedDate != null)
                listado = ProfesoresBLL.GetList(c => c.FechaIngreso.Date >= DesdeDataPicker.SelectedDate);

            if (HastaDataPicker.SelectedDate != null)
                listado = ProfesoresBLL.GetList(c => c.FechaIngreso.Date <= HastaDataPicker.SelectedDate);

            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
