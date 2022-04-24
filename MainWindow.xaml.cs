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

namespace BasicCalculator
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


        private void btnmult_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                string numberboxstring1 = numberbox1.Text.ToString();
                string numberboxstring2 = numberbox2.Text.ToString();

                double numberboxdouble1 = double.Parse(numberboxstring1);
                double numberboxdouble2 = double.Parse(numberboxstring2);

                double numberboxdouble3 = (numberboxdouble1) * (numberboxdouble2);

                answerbox1.Text = numberboxdouble3.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Error! You may only enter numbers. Try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Stop);

            }

        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string numberboxstring1 = numberbox1.Text.ToString();
                string numberboxstring2 = numberbox2.Text.ToString();

                double numberboxdouble1 = double.Parse(numberboxstring1);
                double numberboxdouble2 = double.Parse(numberboxstring2);

                double numberboxdouble3 = (numberboxdouble1) - (numberboxdouble2);

                answerbox1.Text = numberboxdouble3.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Error! You may only enter numbers. Try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Stop);

            }

        }

        private void btnplus_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string numberboxstring1 = numberbox1.Text.ToString();
                string numberboxstring2 = numberbox2.Text.ToString();
                double numberboxdouble1 = double.Parse(numberboxstring1);
                double numberboxdouble2 = double.Parse(numberboxstring2);

                double numberboxdouble3 = (numberboxdouble1) + (numberboxdouble2);

                answerbox1.Text = numberboxdouble3.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Error! You may only enter numbers. Try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Stop);

            }


        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                string numberboxstring1 = numberbox1.Text.ToString();
                string numberboxstring2 = numberbox2.Text.ToString();
                double numberboxdouble1 = double.Parse(numberboxstring1);
                double numberboxdouble2 = double.Parse(numberboxstring2);

                double numberboxdouble3 = (numberboxdouble1) / (numberboxdouble2);

                answerbox1.Text = numberboxdouble3.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error! You may only enter numbers. Try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Stop);

            }


        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {


            numberbox1.Text = "0";
            numberbox2.Text = "0";
            answerbox1.Text = "Answer appears here.";

        }

        
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Created by Christian Gibson\n2022, All Rights Reserved.", "About", MessageBoxButton.OK, MessageBoxImage.Information);

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Enter a number in the leftmost box, and the rightmost box.\nThen, select an operation to perform.\nThe answer will appear in the bottom box.", "Help", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }


}
