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

namespace Animate1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Page.PageCircle pageCircle = new Page.PageCircle();
        private Page.Path path = new Page.Path();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCircle_Click(object sender, RoutedEventArgs e)
        {
            this.contentPage.Content = this.pageCircle;
        }

        private void btnPath_Click(object sender, RoutedEventArgs e)
        {
            this.contentPage.Content = this.path;
        }
    }
}
