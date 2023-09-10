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

namespace HW_26._08._23_3_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       public void PressKey(object sender)
        {
          if (resultTextBlock.Text == "0")
                {
                    resultTextBlock.Text = resultTextBlock.Text.Substring(0, resultTextBlock.Text.Length - 1);
                }
                Button button = (Button)sender;
                string buttonText = button.Content.ToString();
                resultTextBlock.Text += buttonText;        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PressKey(sender);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PressKey(sender);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PressKey(sender);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Result.Text = resultTextBlock.Text;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            resultTextBlock.Text ="0";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            PressKey(sender);

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            if (resultTextBlock.Text.Length > 0)
            {
                resultTextBlock.Text = resultTextBlock.Text.Substring(0, resultTextBlock.Text.Length - 1);
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            resultTextBlock.Text = "0";
        }
    }
}
