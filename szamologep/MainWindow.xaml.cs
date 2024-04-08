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

namespace szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int szam1 = 0;
        string input= string.Empty;
        string operand1= string.Empty;
        string operand2 = string.Empty;
        char operation;
        double vegertek = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content += "1";
            input +="1";

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content += "2";
            input +="2";
        }   

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content += "3";
            input +="3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content += "4";
            input +="4";  
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content += "5";
            input +="5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content += "6";
            input +="6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content+="7";
            input +="7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content += "8";
            input +="8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
           
            lblkiiras.Content += "9";
            input +="9";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            
            lblkiiras.Content += "0";
            input +="0";
        }

        private void btnosszeadas_Click(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            lblkiiras.Content += "+";
            input +="+";
            input = string.Empty;
        }

        private void btnkivonas_Click(object sender, RoutedEventArgs e)
        {
            operand1 += input;
            lblkiiras.Content+= "-";
            input +="-";
            input = string.Empty;
        } 

        private void btntorles_Click(object sender, RoutedEventArgs e)
        {
            lblkiiras.Content = "";
        }

        private void btnosztas_Click(object sender, RoutedEventArgs e)
        {
            operand1 += input;
            lblkiiras.Content += "/";
            input +="/";
            input = string.Empty;
        }

        private void btnszorzas_Click(object sender, RoutedEventArgs e)
        {   
            operand1 += input;
            lblkiiras.Content += "*";
            input+="*";
            input = string.Empty;
        }

        private void btnegyenlo_Click(object sender, RoutedEventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            if (operation=='+')
            {
                 var numbers = lblkiiras.Content.ToString().Split('+');
                szam1= int.Parse(numbers[0])+ int.Parse(numbers[1]);
                lblkiiras.Content = szam1;
                
            }
            
        }
    }
}