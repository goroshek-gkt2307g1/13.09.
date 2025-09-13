using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _13._09_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            button.IsEnabled = false;

            await Button_Timer(button);

            button.IsEnabled = true;
            button.Content = "Отключить кнопку";
        }

        private async Task Button_Timer(System.Windows.Controls.Button button)
        {
            for (int i = 10; i > 0; i--)
            {
                await Dispatcher.InvokeAsync(() =>
                {
                    button.Content = $"{i}";
                });
                await Task.Delay(1000);
            }
        }
    }
}