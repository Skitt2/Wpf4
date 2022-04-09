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

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double summDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * summDollar;
            resSum.Text = resDollar.ToString();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double summEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * summEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate2.Text);
            double summGriv = Convert.ToDouble(sum2.Text);
            double resGriv = rateGriv * summGriv;
            resSum2.Text = resGriv.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate3.Text);
            double summDram = Convert.ToDouble(sum3.Text);
            double resDram = rateDram * summDram;
            resSum3.Text = resDram.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double origlnch = Convert.ToDouble(original.Text);
            double resInch = origlnch * 0.305;
            resConv.Text = resInch.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double origFt = Convert.ToDouble(original1.Text);
            double resFt = origFt * 0.025;
            resConv1.Text = resFt.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double origMile = Convert.ToDouble(original2.Text);
            double resMile = origMile * 1609.34;
            resConv2.Text = resMile.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double origVerst = Convert.ToDouble(original3.Text);
            double resVerst = origVerst * 1066.8;
            resConv3.Text = resVerst.ToString();
        }
    }
}
