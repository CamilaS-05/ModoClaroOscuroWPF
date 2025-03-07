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

namespace ModoClaroOscuroWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool modoOscuro = true;

        public MainWindow()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void InicializarUI()
        {
            MessageBox.Show("Inicializando UI");
            string imagePath = "C:\\Users\\kmyte\\source\\repos\\ModoClaroOscuroWPF\\ModoClaroOscuroWPF\\imagen\\libro.png";
            if (System.IO.File.Exists(imagePath))
            {
                pbPostImagen.Source = new BitmapImage(new Uri(imagePath));
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra en la ruta especificada.");
            }
            CambiarTema();
        }

        private void CambiarTextoBoton()
        {
            btnToggleModo.Content = modoOscuro ? "🌞 Modo Claro" : "🌙 Modo Oscuro";
        }

        private void CambiarTema()
        {
            var fondo = modoOscuro ? Brushes.Black : Brushes.White;
            var texto = modoOscuro ? Brushes.White : Brushes.Black;
            var botonFondo = modoOscuro ? Brushes.Gray : Brushes.LightGray;
            var botonTexto = modoOscuro ? Brushes.White : Brushes.Black;

            this.Background = fondo;
            lblPostUsuario.Foreground = texto;
            lblPostTexto.Foreground = texto;
            btnToggleModo.Background = botonFondo;
            btnToggleModo.Foreground = botonTexto;
        }

        private void BtnToggleModo_Click(object sender, RoutedEventArgs e)
        {
            modoOscuro = !modoOscuro;
            CambiarTema();
            CambiarTextoBoton();
        }
    }
}
