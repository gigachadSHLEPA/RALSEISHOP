using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.BOOK;
using RALSEISHOP.View.Pages.HAT;
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

namespace RALSEISHOP.View.Pages.MONEY.BOOKm
{
    /// <summary>
    /// Логика взаимодействия для BUYALLtoP2_BOOK_.xaml
    /// </summary>
    public partial class BUYALLtoP2_BOOK_ : Page
    {
        public BUYALLtoP2_BOOK_()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYALLbb());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
