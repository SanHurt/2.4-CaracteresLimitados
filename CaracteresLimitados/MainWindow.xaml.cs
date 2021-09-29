
using System.Windows;


namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int contador;
        const string CARACTERES_MAXIMOS = "/140";
        public MainWindow()
        {
            InitializeComponent();
            
            contadorTextBox.Text = contador.ToString() + CARACTERES_MAXIMOS;
        }
        public void ActualizarContador()
        {
            contador = textoTextBox.Text.Length;
            contadorTextBox.Text = contador.ToString() + CARACTERES_MAXIMOS;
            if (contador == 140)
                textoTextBox.IsReadOnly = true;
        }

        private void textoTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            ActualizarContador();
        }
    }
}
