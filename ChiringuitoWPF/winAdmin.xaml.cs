using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using System;
using System.Data;
using System.Windows;

namespace ChiringuitoWPF.AcademicManage
{
    /// <summary>
    /// Lógica de interacción para winAdmin.xaml
    /// </summary>
    public partial class winAdmin : Window
    {
        public winAdmin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            UserImpl userImpl = new UserImpl();
            try
            {
                DataTable table = userImpl.Login(textUsername.Text, textPassword.Password);
                if (table.Rows.Count > 0)
                {
                    SessionClass.ID = short.Parse(table.Rows[0][0].ToString());
                    SessionClass.SessionUserName = table.Rows[0][1].ToString();
                    SessionClass.SessionRole = table.Rows[0][2].ToString();
                    MainWindow menu = new MainWindow();
                    menu.Show();
                    this.Visibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Nombre de usuario y/o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
