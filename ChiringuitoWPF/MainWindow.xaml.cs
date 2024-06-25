using ChiringuitoWPF.AcademicManage;
using System;
using System.Windows;
using System.Windows.Input;

namespace ChiringuitoWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            winAdmin winadmi = new winAdmin();
            // Crear una instancia de Credencial
            Application.Current.MainWindow.Close();

            winadmi.Show();
        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            Credencial credencial = new Credencial();
            // Crear una instancia de Credencial
            Application.Current.MainWindow.Close();

            credencial.Show();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Border_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Credencial winAdmin = new Credencial();
            winAdmin.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Border_MouseLeftButtonUp_1(object sender, MouseButtonEventArgs e)
        {
            winBranchReg winBranch = new winBranchReg();
            winBranch.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Border_MouseLeftButtonUp_2(object sender, MouseButtonEventArgs e)
        {
            winModUSer winModUSer = new winModUSer();
            winModUSer.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void mail_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mail_Click_1(object sender, RoutedEventArgs e)
        {
            borderMod.Visibility = Visibility.Visible;
            borRegUsuario.Visibility = Visibility.Visible;
            borRegSucursal.Visibility = Visibility.Hidden;
            borModSucursal.Visibility = Visibility.Hidden;
            bormodiSucur.Visibility = Visibility.Hidden;
        }

        private void chrome_Click(object sender, RoutedEventArgs e)
        {
            borRegSucursal.Visibility = Visibility.Visible;
            borModSucursal.Visibility = Visibility.Visible;
            bormodiSucur.Visibility = Visibility.Visible;
            borderMod.Visibility = Visibility.Hidden;
            borRegUsuario.Visibility = Visibility.Hidden;
        }

        private void bormodiSucur_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            winBranchMod winBranchMod = new winBranchMod();
            winBranchMod.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
