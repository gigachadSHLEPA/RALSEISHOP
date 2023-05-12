using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.COOKIES;
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

namespace RALSEISHOP.View.Pages.MONEY.COOKIESm
{
    /// <summary>
    /// Логика взаимодействия для BUYBOOK_SECONDtoP2_COOKIES_.xaml
    /// </summary>
    public partial class BUYBOOK_SECONDtoP2_COOKIES_ : Page
    {
        public BUYBOOK_SECONDtoP2_COOKIES_()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYBOOK_SECONDc());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
