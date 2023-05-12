using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.BOOK;
using RALSEISHOP.View.Pages.COOKIES;
using RALSEISHOP.View.Pages.PIE;
using RALSEISHOP.View.Pages.SWORD;
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

namespace RALSEISHOP.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для RALSEIAWAKEP2.xaml
    /// </summary>
    public partial class RALSEIAWAKEP2 : Page
    {
        public RALSEIAWAKEP2()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new RALSEIAWAKE());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYPIE_FIRSTP());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYBOOK_FIRSTb());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYCOOKIES_FIRSTc());
        }
    }
}
