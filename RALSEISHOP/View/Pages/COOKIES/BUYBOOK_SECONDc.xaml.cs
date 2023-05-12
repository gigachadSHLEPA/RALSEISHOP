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
    /// Логика взаимодействия для BUYBOOK_SECONDc.xaml
    /// </summary>
    public partial class BUYBOOK_SECONDc : Page
    {
        public BUYBOOK_SECONDc()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYBOOK_SECONDtoP2_COOKIES_());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYALLbb());
        }
    }
}
