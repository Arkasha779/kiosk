using System;
using System.Windows;
using System.Windows.Controls;

namespace kiosk
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        int summ;
        public Menu()
        {
            InitializeComponent();
        }

        private void Bt_Chuez_Click(object sender, RoutedEventArgs e)
        {
            summ += 69;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Чизбургер с Луком\t\t\t\t\t\t 69 р.");
        }

        private void Bt_Hambyrger_Click(object sender, RoutedEventArgs e)
        {
            summ += 55;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Лонгер\t\t\t\t\t\t\t\t  55 р.");
        }

        private void Bt_Big_Mak_Click(object sender, RoutedEventArgs e)
        {

            summ += 99;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Шефбургер Джуниор\t\t\t\t\t\t 99 р.");
        }

        private void Bt_Chefbyrger_Click(object sender, RoutedEventArgs e)
        {
            summ += 134;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Шефбургер\t\t\t\t\t\t  134 р.");
        }

        private void Bt_File_FIsh_Click(object sender, RoutedEventArgs e)
        {
            summ += 149;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Шефбургер Де Люкс\t\t\t\t\t  149 р.");
        }

        private void Bt_Makchiken_Click(object sender, RoutedEventArgs e)
        {
            summ += 129;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Чизбургер Де Люкс\t\t\t\t\t 129 р.");
        }

        private void Bt_Cola_Mak_Click(object sender, RoutedEventArgs e)
        {
            summ += 119;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Миринда\t\t\t\t\t\t 119 р.");
        }

        private void Bt_Cola_KFC_Click(object sender, RoutedEventArgs e)
        {
            summ += 119;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "7UP\t\t\t\t\t\t\t 119 р.");
        }

        private void Bt_Limonad_Click(object sender, RoutedEventArgs e)
        {
            summ += 119;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Липтон\t\t\t\t\t\t\t 119 р.");
        }

        private void Bt_Coffi_Click(object sender, RoutedEventArgs e)
        {
            summ += 119;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Pepsi \t\t\t\t\t\t\t 119 р.");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = 1000;
            string f = "1234";
            if (summ >= a)
            {
                MessageBox.Show("Ведите пин-код ");

                if (f == "1234")
                {

                    MessageBox.Show("Пин-код введен правильно!");

                }

            }
            MessageBox.Show("Спасибо за покупку!");
            MainWindow g = new MainWindow();
            Close();

            // c.Close();
            g.Show();
        }

        private void Bt_Maclo_Click(object sender, RoutedEventArgs e)
        {
            summ += 149;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Твистер Оригинальный\t\t\t\t\t 149 р.");
        }

        private void Bt_Ikra_Click(object sender, RoutedEventArgs e)
        {
            summ += 199;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "БоксМастер\t\t\t\t\t\t 199 р.");
        }

        private void Bt_Grib_Click(object sender, RoutedEventArgs e)
        {
            summ += 55;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Ай-Твистер\t\t\t\t\t\t\t 55 р.");
        }

        private void Bt_Betchina_Click(object sender, RoutedEventArgs e)
        {
            summ += 99;
            Lb_Sum.Content = "Цена: " + summ;
            tbfin.AppendText(Environment.NewLine + "Твистер Джуниор\t\t\t\t\t\t 99 р.");
        }

        private void tbfin_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbfin.IsReadOnly = true;

        }
    }
}
