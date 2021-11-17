using IncripcionesWPF.UI.Consultas;
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
            rUsuarios usuario = new rUsuarios();
            usuario.Show();
        }

        private void RegistroEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rEstudiantes registroEstudiantes = new rEstudiantes();
            registroEstudiantes.Show();
        }

        private void ConsultasUsuarioMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios usuarios = new cUsuarios();
            usuarios.Show();
        }

        private void ConsultasEstudianteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cEstudiantes ConsultasEstudiantes = new cEstudiantes();
            ConsultasEstudiantes.Show();
        }

        private void RegistroProfesoresMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProfesores registroProfesores = new rProfesores();
            registroProfesores.Show();
        }

        private void RegistroCursosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCursos cursos = new rCursos(); 
            cursos.Show();
        }

        private void RegistroMateriasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rMaterias materias = new rMaterias();
            materias.Show();
        }

        private void ConsultasProfesoresMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cProfesores consultasprofesores = new cProfesores();
            consultasprofesores.Show();
        }

        private void ConsultasCursosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cCursos cursos = new cCursos();
            cursos.Show();
        }


        private void ConsultasMateriasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cMaterias materias = new cMaterias();
            materias.Show();
        }

        private void RegistroIncripcionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rIncripciones registrosIncripciones = new rIncripciones();
            registrosIncripciones.Show();
        }

        private void ConsultasIncripcionMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cIncripciones consultas = new cIncripciones();
            consultas.Show();

        }

        private void RegistroRolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rRoles registroRoles = new rRoles();
            registroRoles.Show();
        }

        private void ConsultasRolesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cRoles consultasRoles = new cRoles();
            consultasRoles.Show();
        }

        private void RegistroAreasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rAreas areas = new rAreas(); 
            areas.Show();   
        }

        private void ConsultasAreasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cAreas areas = new cAreas();
            areas.Show();
        }
    }
}
