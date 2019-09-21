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
using System.Windows.Shapes;

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class WindowEr : Window
    {
        public WindowEr()
        {
            InitializeComponent();
        }
        public void ErrorMessage(string message)
        {
            ErLabel.Content = message;
            ErLabel.FontSize = 12;           
        }
        private void BtnErOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
