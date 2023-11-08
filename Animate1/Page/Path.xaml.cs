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

/*
 * Author: Joey
 * Reference: https://blog.csdn.net/pandawangyt/article/details/110818853
 * 
 * 1. M0,0 : X,Y軸,設定畫線的原點, ex: M0,100  M100,100
 * 2. L100,0 : 畫線,從之前最後一點,畫到現在的 100,0 點
 * 3. H200 : 從之前最後一點,畫橫線到X的相對位置, 也可以設 H-100 (這是用絕對座標,絕對座標是以第一項的M0,0開始)
 * 4. V20 : 從之前最後一點,畫垂直線到目標位置
 * 5. M0,100 A5,10 -10 0 0 40,100 (Part 2)
 *   M0,100是起點 40,100是終點
 *   A5,10 -10 0 0 : 畫弧,弧的橢圓半徑是5和10, 旅轉-10度,不是大弧,不是順時針
 * 6. M100,100 A50,50 0 0 1 140,100
 *   M100,100是起點 140,100是終點
 *   A50,50 0 0 1 : 畫弧,弧的橢圓半徑是50和50, 旅轉-10度,不是大弧,不是順時針
 */
namespace Animate1.Page
{
    /// <summary>
    /// Path.xaml 的互動邏輯
    /// </summary>
    public partial class Path : UserControl
    {
        public Path()
        {
            InitializeComponent();
        }
    }
}
