using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.BOOK;
using RALSEISHOP.View.Pages.MONEY.COOKIESm;
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
    /// Логика взаимодействия для BUYCOOKIES_FIRSTc.xaml
    /// </summary>
    public partial class BUYCOOKIES_FIRSTc : Page
    {
        public BUYCOOKIES_FIRSTc()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYCOOKIES_FIRSTtoP2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYBOOK_SECONDc());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYPIE_SECONDc());
        }
    }
}
