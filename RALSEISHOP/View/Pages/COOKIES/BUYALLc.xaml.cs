using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.BOOK;
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

namespace RALSEISHOP.View.Pages.COOKIES
{
    /// <summary>
    /// Логика взаимодействия для BUYALLc.xaml
    /// </summary>
    public partial class BUYALLc : Page
    {
        public BUYALLc()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYCOOKIES_SECONDb());
        }
    }
}
