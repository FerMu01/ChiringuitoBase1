using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace ChiringuitoWPF
{
    /// <summary>
    /// Lógica de interacción para winModUSer.xaml
    /// </summary>
    public partial class winModUSer : Window
    {
        User t;
        UserImpl implUser;
        public winModUSer()
        {
            InitializeComponent();
        }
        void Select()
        {
            implUser = new UserImpl();
            try
            {
                dvgData.ItemsSource = null;
                dvgData.ItemsSource = implUser.Select().DefaultView;
                dvgData.Columns[0].Visibility = Visibility.Collapsed;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Select();
        }

        private void dvgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dvgData.Items.Count > 0 && dvgData.SelectedItem != null)
            {
                try
                {
                    DataRowView dataRowView = (DataRowView)dvgData.SelectedItem;
                    byte id = byte.Parse(dataRowView.Row.ItemArray[0].ToString());

                    t = null;
                    implUser = new UserImpl();
                    t = implUser.Get(id);
                    if (t != null)
                    {
                        textName.Text = t.Name;
                        textLast.Text = t.LastName;
                        textSecond.Text = t.SecondSurname;
                        textEmail.Text = t.Email;
                        DatePickerFecha.SelectedDate = t.BirthDate;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                t.Name = textName.Text;
                t.LastName = textLast.Text;
                t.Email = textEmail.Text;
                t.BirthDate = DatePickerFecha.SelectedDate.Value;

                implUser = new UserImpl();
                int n = implUser.Update(t);
                if (n > 0)
                {
                    Select();
                    MessageBox.Show("Registro Modificado");
                    stackBox.IsEnabled = false;
                    DatePickerFecha.IsEnabled = false;
                }
                else
                {
                    MessageBox.Show("No se registraron Cambios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            stackBox.IsEnabled = true;
            DatePickerFecha.IsEnabled = true;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea borrar ", "Eliminacion", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                if (t != null)
                {
                    try
                    {
                        implUser = new UserImpl();
                        int n = implUser.Delete(t);
                        if (n > 0)
                        {
                            Select();
                            MessageBox.Show("Registro eliminado");
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron cambios");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
