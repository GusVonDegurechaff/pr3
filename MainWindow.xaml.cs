using System.ComponentModel;
using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Калькулятор
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double x = 0;
        double y = 0;
        double z = 0;

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            x = Convert.ToDouble(InputX.Text);
            y = Convert.ToDouble(InputX.Text);
            z = Convert.ToDouble(InputX.Text);
            double zxc = 0;
            zxc = Math.Pow(Math.Sqrt(8 + Math.Pow(Math.Abs(x - y),2) + 1), 3) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2) - Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);
            CalculateAnswer.Items.Add($"Результат u = {zxc}");
        }
    }
}