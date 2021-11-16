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
    /// Interaction logic for cMaterias.xaml
    /// </summary>
    public partial class cMaterias : Window
    {
        public cMaterias()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Materias>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0: //Nombre
                        listado = MateriasBLL.GetList(e => e.Nombre.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 1: //Codigo
                        listado = MateriasBLL.GetList(e => e.CodigoMateria.ToLower().Contains(CriterioTextBox.Text.ToLower()));
                        break;
                    case 2: //MateriaId
                        listado = MateriasBLL.GetList(e => e.MateriaId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = MateriasBLL.GetList(e => true);

            }
            DatosDataGrid.ItemsSource = null;
            DatosDataGrid.ItemsSource = listado;
        }
    }
}
