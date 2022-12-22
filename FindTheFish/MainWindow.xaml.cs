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

namespace FindTheFish
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageSource? currentImage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClicked_RosaStoi(object sender, RoutedEventArgs e)
        {
            currentImage = RosaStoi.Source;
        }

        private void ButtonClicked_RosaLezy(object sender, RoutedEventArgs e)
        {
            currentImage = RosaLezy.Source;
        }

        private void ButtonClicked_RosaPatrzy(object sender, RoutedEventArgs e)
        {
            currentImage = RosaPatrzy.Source;
        }

        private void Field_Clicked(object sender, MouseButtonEventArgs e)
        {
            Image? image = sender as Image;
            if (image != null && currentImage != null) image.Source = currentImage;
        }
    }
}
