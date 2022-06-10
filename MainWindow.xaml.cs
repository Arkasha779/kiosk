using System.Windows;

namespace kiosk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Mesto mes = new Mesto();
            mes.Show();
            Close();
        }
    }
}
