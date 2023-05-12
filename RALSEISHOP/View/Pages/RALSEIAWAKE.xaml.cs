using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.COOKIES;
using RALSEISHOP.View.Pages.HAT;
using RALSEISHOP.View.Pages.MOSS;
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
    /// Логика взаимодействия для RALSEIAWAKE.xaml
    /// </summary>
    public partial class RALSEIAWAKE : Page
    {
        public RALSEIAWAKE()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new RALSEIAWAKEP2());
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYMOSS_FIRSTm());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYSWORD_FIRSTs());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYHAT_FIRSTh());
        }
    }
}




