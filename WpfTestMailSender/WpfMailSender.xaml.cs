using System.Windows;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System;

namespace WpfTestMailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WpfMailSender : Window
    {
        
        public WpfMailSender()
        {
            InitializeComponent();           
        }
        private void btnSendEmail_Click( object sender, RoutedEventArgs e)
        {
            EmailSendServiceClass emailSend = new EmailSendServiceClass();
            emailSend.SendMessages(txtHeader.Text, txtBody.Text);
        }
        private void BtnTest_Click(object sender, RoutedEventArgs e)
        {
            WindowEr sew = new WindowEr();
            sew.Show();
        }
    }
}
