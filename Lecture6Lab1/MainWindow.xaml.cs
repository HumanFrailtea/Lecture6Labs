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

namespace Lecture6Lab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try {
                int operation = operationBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftBox.Text);
                decimal rightHand = Convert.ToDecimal(rightBox.Text);
                decimal result = 0;

                switch(operation)
                {
                    case 0:
                        result = leftHand + rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 1:
                        result = leftHand - rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 2:
                        result = leftHand * rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 3:
                        result = leftHand / rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    case 4:
                        result = leftHand % rightHand;
                        resultBox.Text = result.ToString();
                        break;
                    default:
                        result = 0;
                        MessageBox.Show("No operation selected.");
                        break;

                }
            }
            catch (DivideByZeroException )
                    {
                MessageBox.Show("Divide by Zero.");

            }
        }
        }
    }

