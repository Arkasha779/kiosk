using System.Windows;

namespace kiosk
{
    /// <summary>
    /// Логика взаимодействия для Mesto.xaml
    /// </summary>
    public partial class Mesto : Window
    {
        public Mesto()
        {
            InitializeComponent();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            Close();
        }
    }
}
