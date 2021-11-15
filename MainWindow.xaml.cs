using IncripcionesWPF.UI.Registros;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IncripcionesWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistroUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegistroEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEstudiantes registroEstudiantes = new rEstudiantes();
            registroEstudiantes.Show();
        }

        private void ConsultasUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConsultasEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
