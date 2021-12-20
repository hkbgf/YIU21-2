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

namespace WpfApp6
{
    /// <summary>
    /// MyConstellation.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MyConstellation : Page
    {
        public MyConstellation()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Jan.xaml", UriKind.Relative));

        private void Button_Click_1(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Feb.xaml", UriKind.Relative));

        private void Button_Click_2(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Mar.xaml", UriKind.Relative));

        private void Button_Click_3(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Apr.xaml", UriKind.Relative));

        private void Button_Click_4(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/May.xaml", UriKind.Relative));

        private void Button_Click_5(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Jun.xaml", UriKind.Relative));

        private void Button_Click_6(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Jul.xaml", UriKind.Relative));

        private void Button_Click_7(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Aug.xaml", UriKind.Relative));

        private void Button_Click_8(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Sep.xaml", UriKind.Relative));

        private void Button_Click_9(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Oct.xaml", UriKind.Relative));

        private void Button_Click_10(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Nov.xaml", UriKind.Relative));

        private void Button_Click_11(object sender, RoutedEventArgs e) => NavigationService.Navigate(new Uri("/Dec.xaml", UriKind.Relative));
    }
}
