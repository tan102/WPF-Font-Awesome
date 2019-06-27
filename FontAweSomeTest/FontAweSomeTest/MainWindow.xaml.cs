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

namespace FontAweSomeTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnWrapPanelLoaded(object sender, RoutedEventArgs e)
        {
            var wrap = (WrapPanel)sender;

            var dic = this.Resources.MergedDictionaries.First();

            foreach(var key in dic.Keys)
            {
                wrap.Children.Add(new TextBlock() { Text = dic[key].ToString() });
            }

        }
    }
}
