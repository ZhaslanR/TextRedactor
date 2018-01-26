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

namespace TextRedactorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string text = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void pasteButton_Click(object sender, RoutedEventArgs e)
        {
            TextSelection textSelection = textBox.Selection;
            if(textSelection != null)
            {
                textSelection.Text = text;
            }
        }

        private void copyButton_Click(object sender, RoutedEventArgs e)
        {
            TextSelection textSelection = textBox.Selection;
            if (textSelection != null)
            {
                text = textSelection.Text;
            }
        }

        private void cutButton_Click(object sender, RoutedEventArgs e)
        {
            TextSelection textSelection = textBox.Selection;
            if (textSelection != null)
            {
                text = textSelection.Text;
                textSelection.Text = "";
            }
        }
    }
}
