using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
 * Author: Joey
 * Reference 1: https://learn.microsoft.com/zh-tw/dotnet/desktop/wpf/graphics-multimedia/animation-overview?view=netframeworkdesktop-4.8
 */
namespace Animate1.Page
{
    /// <summary>
    /// Animation.xaml 的互動邏輯
    /// </summary>
    public partial class Animation : UserControl
    {
        public Animation()
        {
            InitializeComponent();
        }

        private void btnSpan_Click(object sender, RoutedEventArgs e)
        {
            //https://www.youtube.com/watch?v=qK90unxfrXw 19:22, 19:59
            var WidthAnimation = new DoubleAnimation()
            {
                To = 200,
                Duration = TimeSpan.FromSeconds(0.5)
            };
            var HeightAnimation = new DoubleAnimation()
            {
                To = 100,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            WidthAnimation.Completed += new EventHandler(span_Completed);

            tbSpan.BeginAnimation(TextBlock.WidthProperty, WidthAnimation);
            tbSpan.BeginAnimation(TextBlock.HeightProperty, HeightAnimation);


            /*
            //因為連續下就馬上變動,還是要等時間跑完再下1
            var WidthAnimation2 = new DoubleAnimation()
            {
                To = 100,
                Duration = TimeSpan.FromSeconds(1)
            };
            var HeightAnimation2 = new DoubleAnimation()
            {
                To = 50,
                Duration = TimeSpan.FromSeconds(1)
            };

            tbSpan.BeginAnimation(TextBlock.WidthProperty, WidthAnimation2);
            tbSpan.BeginAnimation(TextBlock.HeightProperty, HeightAnimation2);
            */
        }

        void span_Completed(object sender, EventArgs e)
        {
            var WidthAnimation2 = new DoubleAnimation()
            {
                To = 100,
                Duration = TimeSpan.FromSeconds(1)
            };
            var HeightAnimation2 = new DoubleAnimation()
            {
                To = 50,
                Duration = TimeSpan.FromSeconds(1)
            };

            tbSpan.BeginAnimation(TextBlock.WidthProperty, WidthAnimation2);
            tbSpan.BeginAnimation(TextBlock.HeightProperty, HeightAnimation2);
        }

        private void btnTextSpan_Click(object sender, RoutedEventArgs e)
        {
            var FontSideAnimation = new DoubleAnimation()
            {
                To = 40,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            FontSideAnimation.Completed += new EventHandler(textSpan_Completed);

            tbSpan.BeginAnimation(TextBlock.FontSizeProperty, FontSideAnimation);
        }

        void textSpan_Completed(object sender, EventArgs e)
        {
            var FontSideAnimation = new DoubleAnimation()
            {
                To = 20,
                Duration = TimeSpan.FromSeconds(0.5)
            };

            tbSpan.BeginAnimation(TextBlock.FontSizeProperty, FontSideAnimation);
        }

        private void btnColor_Click(object sender, RoutedEventArgs e)
        {   // 這個會失敗
            var FontColorAnimation = new ColorAnimation()
            {
                From = Colors.Black,
                To = Colors.Red,
                Duration = TimeSpan.FromSeconds(3),
                FillBehavior = FillBehavior.Stop
            };
            tbSpan.Foreground = new SolidColorBrush(Colors.Red);
            //tbSpan.BeginAnimation(TextBlock.ForegroundProperty , FontColorAnimation);
        }

        private void btnFadeInOut_Click(object sender, RoutedEventArgs e)
        {
            //Sameple from: Reference 1
        }
    }
}
