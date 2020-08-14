using System;
using System.Collections;
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

namespace GetLotto
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

        private void btnLotto_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            var lottoList = new ArrayList();
            var result = "";

            while (lottoList.Count < 6)
            {
                var temp = rand.Next(1, 45);
                if (lottoList.IndexOf(temp) == -1)
                    lottoList.Add(temp);
            }

            lottoList.Sort();

            foreach (var i in lottoList)
            {
                result += i + ",";
            }
            result = result.Remove(result.Length - 1);
            

            tbLotto.Text = result;
        }
    }
}
