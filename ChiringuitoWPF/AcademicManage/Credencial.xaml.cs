using ChiringuitoDAO.Implementation;
using ChiringuitoDAO.Model;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows;


namespace ChiringuitoWPF.AcademicManage
{
    /// <summary>
    /// Lógica de interacción para Credencial.xaml
    /// </summary>
    public partial class Credencial : Window
    {
        User t;
        UserImpl implUser;
        byte op = 0;
        public Credencial()
        {
            InitializeComponent();
        }


        public class PasswordHasher
        {
            public static string ComputeMD5Hash(string input)
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Convertir los bytes del hash a una cadena hexadecimal
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        sb.Append(hashBytes[i].ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
        }
        public class UserNameGenerator
        {
            public static string GenerateUserName(string name, string lastName)
            {
                // Obtener las primeras letras del nombre y apellidos
                StringBuilder userNameBuilder = new StringBuilder();
                userNameBuilder.Append(name.Substring(0, 2));
                userNameBuilder.Append(lastName.Substring(0, 2));


                // Agregar números aleatorios
                Random random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    userNameBuilder.Append(random.Next(10)); // Agregar un número aleatorio del 0 al 9
                }

                return userNameBuilder.ToString();
            }
        }
        public class PasswordGenerator
        {
            private static Random random = new Random();

            public static string GeneratePassword(int length)
            {
                const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
                const string digits = "0123456789";
                const string specialChars = "!*/";

                // Garantizar que la contraseña tenga al menos una letra mayúscula, una minúscula, un dígito y un carácter especial
                string password = new string(new char[]
                {
            upperCase[random.Next(upperCase.Length)],
            lowerCase[random.Next(lowerCase.Length)],
            digits[random.Next(digits.Length)],
            specialChars[random.Next(specialChars.Length)]
                });

                // Completar la longitud de la contraseña con caracteres aleatorios de los conjuntos anteriores
                string allChars = upperCase + lowerCase + digits + specialChars;
                password += new string(Enumerable.Repeat(allChars, length - 4)
                                                 .Select(s => s[random.Next(s.Length)]).ToArray());

                // Mezclar los caracteres de la contraseña para evitar patrones predecibles
                return new string(password.ToCharArray().OrderBy(s => (random.Next(2) % 2) == 0).ToArray());
            }
        }
        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            this.op = 1;
            string userName = UserNameGenerator.GenerateUserName(TextName.Text, TextPrimer.Text);
            string contraseña = PasswordGenerator.GeneratePassword(8); // Generar la contraseña de 8 caracteres
            string rol = "Cliente";

            switch (this.op)
            {
                case 1:
                    //Insert
                    try
                    {

                        t = new User(userName, TextName.Text, TextPrimer.Text, TextSegundo.Text, textMail.Text, contraseña, DatePickerFecha.SelectedDate.Value, rol);
                        implUser = new UserImpl();
                        int n = implUser.Insert(t);
                        if (n > 0)
                        {
                            MessageBox.Show("Registro Insertado");
                            MessageBox.Show($"Nombre de usuario: {userName}\nContraseña: {contraseña}", "Credenciales Generadas");
                            btnSiguiente.IsEnabled = false;
                        }
                        else
                        {
                            MessageBox.Show("no se realizaron cambios");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
            ;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
