
using System.Windows;


namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ActualizarContador()
        {
            contador = textoTextBox.Text.Length;
            contadorTextBox.Text = contador.ToString();
        }

        private void textoTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ActualizarContador();
            if (contador >= 140)
                textoTextBox.IsReadOnly = true;
            
        }
    }
}
