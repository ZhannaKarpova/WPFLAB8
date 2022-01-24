using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPFLAB8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight == FontWeights.Normal)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else textBox.FontWeight = FontWeights.Normal;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Italic)
            {
                textBox.FontStyle = FontStyles.Normal;
            }
            else textBox.FontStyle = FontStyles.Italic;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations == null)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else textBox.TextDecorations = null;
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }
        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы(*txt)|*.txt|все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы(*txt)|*.txt|все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ открыт");
        }
        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Документ сохранен");
        }
        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

