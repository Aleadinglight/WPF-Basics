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

namespace windowsXAML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock txb = sender as TextBlock;
            txb.Text = "Changed";
        }

        private void buttonHover(object sender, DependencyPropertyChangedEventArgs e)
        {
            Button btn = sender as Button;
            btn.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 0));
        }
    }
}
