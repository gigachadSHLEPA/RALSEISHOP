using RALSEISHOP.Core;
using RALSEISHOP.View.Pages.HAT;
using RALSEISHOP.View.Pages.MONEY.BOOKm;
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

namespace RALSEISHOP.View.Pages.BOOK
{
    /// <summary>
    /// Логика взаимодействия для BUYALLbb.xaml
    /// </summary>
    public partial class BUYALLbb : Page
    {
        public BUYALLbb()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Core1.MyCore.Navigate(new BUYALLtoP2_BOOK_());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
