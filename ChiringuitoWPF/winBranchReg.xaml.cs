using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using Microsoft.Maps.MapControl.WPF;
using Microsoft.Win32;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace ChiringuitoWPF
{
    public partial class winBranchReg : Window
    {
        Branch t;
        BranchImpl implBranch;
        Location location;
        string imageBase64;

        public winBranchReg()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Guarda la imagen en el sistema de archivos
                string directoryPath = @"C:\Images\Branches";
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                string filePath = Path.Combine(directoryPath, $"{Guid.NewGuid()}.png");
                File.WriteAllBytes(filePath, Convert.FromBase64String(imageBase64));

                // Guarda solo la ruta del archivo en la base de datos
                t = new Branch(
                    textName.Text,
                    textAdress.Text,
                    location.Latitude,
                    location.Longitude,
                    textNumber.Text,
                    filePath, // Guarda la ruta del archivo
                    byte.Parse(cbxCiudad.SelectedValue.ToString()),
                    byte.Parse(cbxTipo.SelectedValue.ToString())
                );

                implBranch = new BranchImpl();
                int n = implBranch.Insert(t);
                if (n >= 0)
                {
                    MessageBox.Show("Registro Insertado");
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


        void LoadType()
        {
            try
            {
                Tipoimpl tipoImpl = new Tipoimpl();
                DataTable table = tipoImpl.Select();
                cbxTipo.ItemsSource = table.DefaultView;
                cbxTipo.DisplayMemberPath = "name";
                cbxTipo.SelectedValuePath = "id";
                cbxTipo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadComboCity()
        {
            try
            {
                CityImpl cityImpl = new CityImpl();
                DataTable table = cityImpl.Select();
                cbxCiudad.ItemsSource = table.DefaultView;
                cbxCiudad.DisplayMemberPath = "name";
                cbxCiudad.SelectedValuePath = "id";
                cbxCiudad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            MapSucu.ZoomLevel++;
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            MapSucu.ZoomLevel--;
        }

        private void btnCalle_Click(object sender, RoutedEventArgs e)
        {
            MapSucu.Focus();
            MapSucu.Mode = new RoadMode();
        }

        private void btnSatelite_Click(object sender, RoutedEventArgs e)
        {
            MapSucu.Focus();
            MapSucu.Mode = new AerialMode(true);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadComboCity();
            LoadType();
        }

        private void MapSucu_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            var mouseClick = e.GetPosition((UIElement)sender);
            location = MapSucu.ViewportPointToLocation(mouseClick);

            Pushpin pushpin = new Pushpin();
            pushpin.Location = location;

            MapSucu.Children.Clear();
            MapSucu.Children.Add(pushpin);
        }

        private void btnSubirImagen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (.png;.jpeg;.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                byte[] imageBytes = File.ReadAllBytes(filePath);
                imageBase64 = Convert.ToBase64String(imageBytes);

                // Mostrar la imagen en la UI
                uploadedImage.Source = new BitmapImage(new Uri(filePath));
            }
        }
    }
}
