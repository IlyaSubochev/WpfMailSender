using MailSender.Controls;
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

namespace MailSender
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

        private void MiClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void TabItemSwitcher_OnLeftButtonClick(object sender, EventArgs e)
        {
            if (!(sender is TabItemSwitcher switcher)) return;
            MainTabControl.SelectedIndex--;
            if (MainTabControl.SelectedIndex == 0)
            {
                switcher.LeftButtonVisible = false;
            }
            else if (MainTabControl.SelectedIndex == -1)
            {
                MainTabControl.SelectedIndex = 0;
            }
            else
            {
                switcher.LeftButtonVisible = true;
                switcher.RightButtonVisible = true;
            }
            
           
            
        }




        private void TabItemSwitcher_OnRightButtonClick(object sender, EventArgs e)
        {
            if (!(sender is TabItemSwitcher switcher)) return;
            MainTabControl.SelectedIndex++;
            if (MainTabControl.SelectedIndex == 3)
            {
                switcher.RightButtonVisible = false;
            }
            else if (MainTabControl.SelectedIndex == -1)
            {
                MainTabControl.SelectedIndex = 0;
            }
            else
            {
                switcher.RightButtonVisible = true;
                switcher.LeftButtonVisible = true;
            }
            
            


        }
    }
}
