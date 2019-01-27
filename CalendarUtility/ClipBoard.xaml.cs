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
using System.Windows.Interop;
using System.Runtime.InteropServices;
using System.Windows.Threading;
using System.Threading;
using System.Collections.ObjectModel;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for ClipBoard.xaml
    /// </summary>
    public partial class ClipBoard : Page
    {
        public ClipBoard()
        {
            InitializeComponent();
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            string copyData = Clipboard.GetText();
            //Clipboard.SetData(DataFormats.Text, (object)copyData);
            ClipBoardListBox.Items.Add(copyData);
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            if(ClipBoardListBox.SelectedItem != null)
            {
                string getClipValue = ClipBoardListBox.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.Text, (object)getClipValue);
                MessageBox.Show("Copied '" + getClipValue + "' to clipboard");
            } else
            {
                MessageBox.Show("Please select an item to copy.");
            }
            //ClipBoardListBox.SelectedItem
            //string copyData = Clipboard.GetText();
            //Clipboard.SetData(DataFormats.Text, (object)copyData);
            //clipBoardPage.ClipBoardListBox.Items.Add(copyData);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(ClipBoardListBox.SelectedItem != null)
            {
                ClipBoardListBox.Items.Remove(ClipBoardListBox.SelectedItem);
            }else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClipBoardListBox.Items.Clear();
        }
    }
}
