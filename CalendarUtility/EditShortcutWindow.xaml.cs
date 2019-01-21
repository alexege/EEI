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
using System.Windows.Shapes;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for EditShortcutWindow.xaml
    /// </summary>
    public partial class EditShortcutWindow : Window
    {
        public EditShortcutWindow(string _value)
        {
            InitializeComponent();
            string value = _value;
            editImageTextBox.Text = value;

            int choice = CalendarUtility.Properties.Settings.Default.buttonNumber;
            switch (choice)
            {
                case 1:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage1;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction1;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage1;
                    break;
                case 2:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage2;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction2;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage2;
                    break;
                case 3:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage3;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction3;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage3;
                    break;
                case 4:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage4;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction4;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage4;
                    break;
                case 5:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage5;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction5;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage5;
                    break;
                case 6:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage6;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction6;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage6;
                    break;
                case 7:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage7;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction7;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage7;
                    break;
                case 8:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage8;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction8;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage8;
                    break;
                case 9:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage9;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction9;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage9;
                    break;
                case 10:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage10;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction10;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage10;
                    break;
                case 11:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage11;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction11;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage11;
                    break;
                case 12:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage12;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction12;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage12;
                    break;
                case 13:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage13;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction13;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage13;
                    break;
                case 14:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage14;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction14;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage14;
                    break;
                case 15:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage15;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction15;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage15;
                    break;
                case 16:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage16;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction16;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage16;
                    break;
                case 17:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage17;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction17;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage17;
                    break;
                case 18:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage18;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction18;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage18;
                    break;
                case 19:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage19;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction19;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage19;
                    break;
                case 20:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage20;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction20;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage20;
                    break;
                case 21:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage21;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction21;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage21;
                    break;
                case 22:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage22;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction22;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage22;
                    break;
                case 23:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage23;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction23;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage23;
                    break;
                case 24:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage24;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction24;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage24;
                    break;
                case 25:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage25;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction25;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage25;
                    break;
                case 26:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage26;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction26;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage26;
                    break;
                case 27:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage27;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction27;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage27;
                    break;
                case 28:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage28;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction28;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage28;
                    break;
                case 29:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage29;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction29;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage29;
                    break;
                case 30:
                    editImageTextBox.Text = Properties.Settings.Default.shortcutImage30;
                    editFunctionTextBox.Text = Properties.Settings.Default.shortcutAction30;
                    Properties.Settings.Default.currentImage = Properties.Settings.Default.shortcutImage30;
                    break;
            }
            //int shortcutButtonIndex = CalendarUtility.Properties.Settings.Default.shortcutButtonChoice;
            //switch (shortcutButtonIndex)
            //{
            //    case 1:
            //        //buttonLabel1.Textx = CalendarUtility.Properties.Settings.Default.day1;
            //        break;
        }

        //scImageButton filedialog
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Edit Image";
            //dlg.InitialDirectory = Environment.GetFolderPath();                           //Set default filepath of 
            //dlg.DefaultExt = ".txt";
            //dlg.Filter = "Text documents (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if(result == true)
            {
                string filename = dlg.FileName;
                editImageTextBox.Text = filename;
                Properties.Settings.Default.currentImage = dlg.FileName;

            }
        }

        //scFunctionButton filedialog
        private void button_Click1(object sender, RoutedEventArgs e)
        {
            if (editFunctionTextBox.Text == "")
            {
                Microsoft.Win32.OpenFileDialog dlg2 = new Microsoft.Win32.OpenFileDialog();
                dlg2.FileName = "Edit Function";
                Nullable<bool> result2 = dlg2.ShowDialog();

                if (result2 == true)
                {
                    string filename2 = dlg2.FileName;
                    editFunctionTextBox.Text = filename2;
                }
            } else
            {
                System.Diagnostics.Process.Start(editFunctionTextBox.Text);
            }
        }

        private void labelExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            int choice = CalendarUtility.Properties.Settings.Default.buttonNumber;
            switch (choice)
            {
                case 1:
                    Properties.Settings.Default.shortcutImage1 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction1 = editFunctionTextBox.Text;
                    break;
                case 2:
                    Properties.Settings.Default.shortcutImage2 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction2 = editFunctionTextBox.Text;
                    break;
                case 3:
                    Properties.Settings.Default.shortcutImage3 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction3 = editFunctionTextBox.Text;
                    break;
                case 4:
                    Properties.Settings.Default.shortcutImage4 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction4 = editFunctionTextBox.Text;
                    break;
                case 5:
                    Properties.Settings.Default.shortcutImage5 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction5 = editFunctionTextBox.Text;
                    break;
                case 6:
                    Properties.Settings.Default.shortcutImage6 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction6 = editFunctionTextBox.Text;
                    break;
                case 7:
                    Properties.Settings.Default.shortcutImage7 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction7 = editFunctionTextBox.Text;
                    break;
                case 8:
                    Properties.Settings.Default.shortcutImage8 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction8 = editFunctionTextBox.Text;
                    break;
                case 9:
                    Properties.Settings.Default.shortcutImage9 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction9 = editFunctionTextBox.Text;
                    break;
                case 10:
                    Properties.Settings.Default.shortcutImage10 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction10 = editFunctionTextBox.Text;
                    break;
                case 11:
                    Properties.Settings.Default.shortcutImage11 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction11 = editFunctionTextBox.Text;
                    break;
                case 12:
                    Properties.Settings.Default.shortcutImage12 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction12 = editFunctionTextBox.Text;
                    break;
                case 13:
                    Properties.Settings.Default.shortcutImage13 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction13 = editFunctionTextBox.Text;
                    break;
                case 14:
                    Properties.Settings.Default.shortcutImage14 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction14 = editFunctionTextBox.Text;
                    break;
                case 15:
                    Properties.Settings.Default.shortcutImage15 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction15 = editFunctionTextBox.Text;
                    break;
                case 16:
                    Properties.Settings.Default.shortcutImage16 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction16 = editFunctionTextBox.Text;
                    break;
                case 17:
                    Properties.Settings.Default.shortcutImage17 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction17 = editFunctionTextBox.Text;
                    break;
                case 18:
                    Properties.Settings.Default.shortcutImage18 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction18 = editFunctionTextBox.Text;
                    break;
                case 19:
                    Properties.Settings.Default.shortcutImage19 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction19 = editFunctionTextBox.Text;
                    break;
                case 20:
                    Properties.Settings.Default.shortcutImage20 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction20 = editFunctionTextBox.Text;
                    break;
                case 21:
                    Properties.Settings.Default.shortcutImage21 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction21 = editFunctionTextBox.Text;
                    break;
                case 22:
                    Properties.Settings.Default.shortcutImage22 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction22 = editFunctionTextBox.Text;
                    break;
                case 23:
                    Properties.Settings.Default.shortcutImage23 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction23 = editFunctionTextBox.Text;
                    break;
                case 24:
                    Properties.Settings.Default.shortcutImage24 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction24 = editFunctionTextBox.Text;
                    break;
                case 25:
                    Properties.Settings.Default.shortcutImage25 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction25 = editFunctionTextBox.Text;
                    break;
                case 26:
                    Properties.Settings.Default.shortcutImage26 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction26 = editFunctionTextBox.Text;
                    break;
                case 27:
                    Properties.Settings.Default.shortcutImage27 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction27 = editFunctionTextBox.Text;
                    break;
                case 28:
                    Properties.Settings.Default.shortcutImage28 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction28 = editFunctionTextBox.Text;
                    break;
                case 29:
                    Properties.Settings.Default.shortcutImage29 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction29 = editFunctionTextBox.Text;
                    break;
                case 30:
                    Properties.Settings.Default.shortcutImage30 = editImageTextBox.Text;
                    Properties.Settings.Default.shortcutAction30 = editFunctionTextBox.Text;
                    break;
            }
            //editImageTextBox.Text = Properties.Settings.Default.currentImage;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

        }

        private void labelExit_MouseEnter(object sender, MouseEventArgs e)
        {
            labelExit.Background = Brushes.White;
            labelExit.Foreground = Brushes.Red;
        }

        private void labelExit_MouseLeave(object sender, MouseEventArgs e)
        {
            labelExit.Background = Brushes.Red;
            labelExit.Foreground = Brushes.White;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
