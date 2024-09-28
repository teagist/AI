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

namespace gifDemo
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

        private void UserBox_EnterButton(object sender, KeyEventArgs e)
        {
            MessageBox.Show("enter");
            if (/*e.Key == Key.Enter*/ Keyboard.IsKeyDown(Key.Enter))
            {
                //UserBox.AcceptsReturn = true;
                //UserBox.Document.Blocks.Clear();
                //AlfredBox.Document.Blocks.Clear();
                //AlfredBox.Document.Blocks.Add(new Paragraph(new Run("Yes sir.")));

                MessageBox.Show("Enter key is hit");
            }

            // MessageBox.Show("Enter was hit");
        }
    }
}
