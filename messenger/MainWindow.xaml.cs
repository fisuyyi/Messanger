using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace messenger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public object p;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void JoinToChat_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
            if (IPAddress.Text == "")
            {
                ErrorText.Text = "Заполните поле с IP-адресом";
            }
            else if (Regex.IsMatch(IPAddress.Text, pattern, RegexOptions.IgnoreCase) != true)
            {
                ErrorText.Text = "Вы ввели неправильный формат IP-адреса";
            }
            else if (Login.Text == "")
            {
                ErrorText.Text = "Введите имя пользователя";
            }
            else
            {
                Hide();
                new JoinMessage(Login.Text, IPAddress.Text).Show();
            }
        }

        private void NewChat_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "")
            {
                ErrorText.Text = "Введите имя пользователя";
            }
            else
            {
                Hide();
                new JoinMessage(Login.Text).Show();
            }
        }
        
    }
}
