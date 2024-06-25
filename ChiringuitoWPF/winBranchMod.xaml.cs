using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace ChiringuitoWPF
{
    /// <summary>
    /// Lógica de interacción para winBranchMod.xaml
    /// </summary>
    public partial class winBranchMod : Window
    {
        Branch t;
        BranchImpl implBranch;
        public winBranchMod()
        {
            InitializeComponent();
        }
        void Select()
        {
            implBranch = new BranchImpl();
            try
            {
                dvgData.ItemsSource = null;
                dvgData.ItemsSource = implBranch.Select().DefaultView;
                dvgData.Columns[0].Visibility = Visibility.Collapsed;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Visibility = Visibility.Collapsed;
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
                    implBranch = new BranchImpl();
                    t = implBranch.Get(id);
                    if (t != null)
                    {
                        textName.Text = t.Name;
                        textAdress.Text = t.Adress;
                        textNumber.Text = t.NumberContact;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                t.Name = textName.Text;
                t.Adress = textAdress.Text;
                t.NumberContact = textNumber.Text;

                implBranch = new BranchImpl();
                int n = implBranch.Update(t);
                if (n > 0)
                {
                    Select();
                    MessageBox.Show("Registro Modificado");

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

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea borrar ", "Eliminacion", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                if (t != null)
                {
                    try
                    {
                        implBranch = new BranchImpl();
                        int n = implBranch.Delete(t);
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
    }
}
