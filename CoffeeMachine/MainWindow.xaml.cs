using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CoffeeMachine
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Automatic auto = new Automatic();
            auto.DrinkBeginMade += Auto_DrinkBeginMade;
            auto.Make(new Espresso());
        }

        private void Auto_DrinkBeginMade(object sender, EventArgs e)
        {
            DateTime a = DateTime.Now;

            //while (DateTime.Now != a.AddSeconds(2))
            //    continue;
            Ready.Background = new ImageBrush(new BitmapImage(new Uri(@"D:\Загрузки\CoffeeMachine-dev\CoffeeMachine-dev\CoffeeMachine\images\processing1.png")));
            Thread.Sleep(3000);
            Ready.Background = new ImageBrush(new BitmapImage(new Uri(@"D:\Загрузки\CoffeeMachine-dev\CoffeeMachine-dev\CoffeeMachine\images\processing2.png")));
        }
    }
}
