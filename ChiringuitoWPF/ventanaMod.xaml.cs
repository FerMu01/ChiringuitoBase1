using System.Windows;

namespace ChiringuitoWPF
{
    /// <summary>
    /// Lógica de interacción para ventanaMod.xaml
    /// </summary>
    public partial class ventanaMod : Window
    {
        public ventanaMod(string detalletext)
        {
            InitializeComponent();
            txtName.Text = detalletext;
        }
    }
}
