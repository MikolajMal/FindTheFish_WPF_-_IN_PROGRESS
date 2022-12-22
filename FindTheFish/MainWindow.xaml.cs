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
        ImageBrush? currentBrush = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClicked_RosaStoi(object sender, RoutedEventArgs e)
        {
            currentBrush = (ImageBrush)RosaStoi.Background;
        }

        private void ButtonClicked_RosaLezy(object sender, RoutedEventArgs e)
        {
            currentBrush = (ImageBrush)RosaLezy.Background;
        }

        private void ButtonClicked_RosaPatrzy(object sender, RoutedEventArgs e)
        {
            currentBrush = (ImageBrush)RosaPatrzy.Background;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            if (button != null && currentBrush != null) button.Background = currentBrush;
        }
    }
}
