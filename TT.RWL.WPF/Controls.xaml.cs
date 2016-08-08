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

namespace TT.RWL.WPF
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void viewAllButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editSelectedButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void createNewButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteSelectedButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void showDeniedMsgBox()
        {
            MessageBox.Show("DENIED", "Denied", MessageBoxButton.OK, MessageBoxImage.Stop);
        }

        private void showApprovedMsgBox()
        {
            MessageBox.Show("APPROVED", "Approved", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void showCorrectMessageBox(bool rightPermission)
        {
            if (rightPermission)
            {
                showApprovedMsgBox();
            }
            else
            {
                showDeniedMsgBox();
            }
        }

        private void setLabelcontent(Label label, string content)
        {
            label.Content = content;
        }

        private void enableButton(bool permission, Button button)
        {
            if (!permission)
            {
                button.IsEnabled = false;
                button.Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                button.IsEnabled = true;
                button.Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
