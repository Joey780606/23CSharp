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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Animate1.Page
{
    /// <summary>
    /// PageCircle.xaml 的互動邏輯
    /// </summary>
    public partial class PageCircle : UserControl
    {
        public PageCircle()
        {
            InitializeComponent();
        }

        // Start / Stop Timer

        DispatcherTimer _timer = new DispatcherTimer();
        int counter = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            TimerLabel.Text = counter.ToString();

            if (counter == 100)
            {
                _timer.Stop();
                TimerLabel.Text = "0".ToString();
            }

        }

        private void StartTimer()
        {
            cpb_uc.Visibility = Visibility.Visible;

            if (counter > 0)
            {
                _timer.Tick -= timer_Tick;
                counter = 0;
            }

            _timer.Interval = TimeSpan.FromMilliseconds(188);
            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        private void StopTimer()
        {
            if (counter > 0)
            {
                _timer.Tick -= timer_Tick;
                counter = 0;
            }

            _timer.Stop();
            cpb_uc.Visibility = Visibility.Collapsed;
            TimerLabel.Text = "0".ToString();
        }

        private void StartAnimation()   //Joey: 重要,這樣黃色圓型才能夠動
        {
            ((Storyboard)cpb_uc.Resources["ProgressBarAnimation"]).Begin();
        }

        private void StopAnimation()    //Joey: 重要,這樣黃色圓型可以停止
        {
            ((Storyboard)cpb_uc.Resources["ProgressBarAnimation"]).Stop();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)   //Joey: 重要,開始計時和動畫
        {
            StartTimer();
            StartAnimation();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            StopTimer();
            StopAnimation();
        }

    }


}
