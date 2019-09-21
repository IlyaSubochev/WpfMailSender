using System;
using System.Windows;


namespace WpfTestMailSender
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SendEndWindow : Window
    {
        public SendEndWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
