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

            MateriaComboBox.ItemsSource = MateriasBLL.GetList();
            MateriaComboBox.SelectedValuePath = "MateriaId";
            MateriaComboBox.DisplayMemberPath = "Nombre";

            AreaComboBox.ItemsSource = AreasBLL.GetAreas();
            MateriaComboBox.SelectedValuePath = "AreaId";
            MateriaComboBox.DisplayMemberPath = "Descripcion";
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoverButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
