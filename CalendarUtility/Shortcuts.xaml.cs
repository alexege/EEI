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

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for Shortcuts.xaml
    /// </summary>
    public partial class Shortcuts : Page
    {

        public Shortcuts()
        {
            InitializeComponent();
            Properties.Settings.Default.Upgrade();

            //if (Properties.Settings.Default.shortcutImage1 == "")
            //{
            //    Properties.Settings.Default.shortcutImage1 = (@"D:\Programming\C#\CalendarUtility\CalendarUtility\ShortcutImages2\Internet\Youtube.png");
            //}
        }

        //private void buttonLabel1_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    //System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.action);
        //}

        //private void editSCButton1(object sender, RoutedEventArgs e)
        //{
        //    EditShortcutWindow escw = new EditShortcutWindow();
        //    escw.Show();
        //}

        //private void scButton01_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutImage3);
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutImage3);
        //}

        
        int scButtonSelection;
        private void scButton1_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 1;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction1);
        }

        private void scButton2_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 2;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction2);
        }

        private void scButton3_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 3;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction3);
        }

        private void scButton4_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 4;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction4);
        }

        private void scButton5_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 5;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction5);
        }

        private void scButton6_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 6;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction6);
        }

        private void scButton7_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 7;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction7);
        }

        private void scButton8_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 8;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction8);
        }

        private void scButton9_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 9;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction9);
        }

        private void scButton10_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 10;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction10);
        }

        private void scButton11_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 11;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction11);
        }

        private void scButton12_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 12;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction12);
        }

        private void scButton13_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 13;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction13);
        }

        private void scButton14_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 14;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction14);
        }

        private void scButton15_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 15;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction15);
        }

        private void scButton16_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 16;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction16);
        }

        private void scButton17_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 17;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction17);
        }

        private void scButton18_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 18;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction18);
        }

        private void scButton19_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 19;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction19);
        }

        private void scButton20_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 20;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction20);
        }

        private void scButton21_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 21;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction21);
        }

        private void scButton22_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 22;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction22);
        }

        private void scButton23_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 23;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction23);
        }

        private void scButton24_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 24;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction24);
        }

        private void scButton25_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 25;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction25);
        }

        private void scButton26_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 26;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction26);
        }

        private void scButton27_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 27;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction27);
        }

        private void scButton28_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 28;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction28);
        }

        private void scButton29_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 29;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction29);
        }

        private void scButton30_Click(object sender, RoutedEventArgs e)
        {
            scButtonSelection = 30;
            System.Diagnostics.Process.Start(CalendarUtility.Properties.Settings.Default.shortcutAction30);
        }




        //Edit button Split here

        private void scButton1_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 1;
            string myVal = Properties.Settings.Default.shortcutImage1;
            EditShortcutWindow esw1 = new EditShortcutWindow(myVal);
            esw1.Show();
            //scButtonSelection = 1;
            //EditShortcutWindow escw = new EditShortcutWindow();

            ////scButton1Image.Source = 

            //string path = Properties.Settings.Default.shortcutImage1;
            //escw.editImageTextBox.Text = path;
            //string path2 = Properties.Settings.Default.shortcutAction1;
            //escw.editFunctionTextBox.Text = path2;

            //escw.Show();
        }
        private void scButton2_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 2;
            string myVal2 = Properties.Settings.Default.shortcutImage2;
            EditShortcutWindow esw2 = new EditShortcutWindow(myVal2);
            esw2.Show();
        }

        private void scButton3_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 3;
            string myVal3 = Properties.Settings.Default.shortcutImage3;
            EditShortcutWindow esw3 = new EditShortcutWindow(myVal3);
            esw3.Show();
        }

        private void scButton4_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 4;
            string myVal4 = Properties.Settings.Default.shortcutImage4;
            EditShortcutWindow esw4 = new EditShortcutWindow(myVal4);
            esw4.Show();
        }

        private void scButton5_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 5;
            string myVal5 = Properties.Settings.Default.shortcutImage5;
            EditShortcutWindow esw5 = new EditShortcutWindow(myVal5);
            esw5.Show();
        }

        private void scButton6_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 6;
            string myVal6 = Properties.Settings.Default.shortcutImage6;
            EditShortcutWindow esw6 = new EditShortcutWindow(myVal6);
            esw6.Show();
        }

        private void scButton7_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 7;
            string myVal7 = Properties.Settings.Default.shortcutImage7;
            EditShortcutWindow esw7 = new EditShortcutWindow(myVal7);
            esw7.Show();
        }

        private void scButton8_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 8;
            string myVal8 = Properties.Settings.Default.shortcutImage8;
            EditShortcutWindow esw8 = new EditShortcutWindow(myVal8);
            esw8.Show();
        }

        private void scButton9_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 9;
            string myVal9 = Properties.Settings.Default.shortcutImage9;
            EditShortcutWindow esw9 = new EditShortcutWindow(myVal9);
            esw9.Show();
        }

        private void scButton10_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 10;
            string myVal10 = Properties.Settings.Default.shortcutImage10;
            EditShortcutWindow esw10 = new EditShortcutWindow(myVal10);
            esw10.Show();
        }

        private void scButton11_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 11;
            string myVal11 = Properties.Settings.Default.shortcutImage11;
            EditShortcutWindow esw11 = new EditShortcutWindow(myVal11);
            esw11.Show();
        }

        private void scButton12_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 12;
            string myVal12 = Properties.Settings.Default.shortcutImage12;
            EditShortcutWindow esw12 = new EditShortcutWindow(myVal12);
            esw12.Show();
        }

        private void scButton13_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 13;
            string myVal13 = Properties.Settings.Default.shortcutImage13;
            EditShortcutWindow esw13 = new EditShortcutWindow(myVal13);
            esw13.Show();
        }

        private void scButton14_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 14;
            string myVal14 = Properties.Settings.Default.shortcutImage14;
            EditShortcutWindow esw14 = new EditShortcutWindow(myVal14);
            esw14.Show();
        }

        private void scButton15_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 15;
            string myVal15 = Properties.Settings.Default.shortcutImage15;
            EditShortcutWindow esw15 = new EditShortcutWindow(myVal15);
            esw15.Show();
        }

        private void scButton16_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 16;
            string myVal16 = Properties.Settings.Default.shortcutImage16;
            EditShortcutWindow esw16 = new EditShortcutWindow(myVal16);
            esw16.Show();
        }

        private void scButton17_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 17;
            string myVal17 = Properties.Settings.Default.shortcutImage17;
            EditShortcutWindow esw17 = new EditShortcutWindow(myVal17);
            esw17.Show();
        }

        private void scButton18_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 18;
            string myVal18 = Properties.Settings.Default.shortcutImage18;
            EditShortcutWindow esw18 = new EditShortcutWindow(myVal18);
            esw18.Show();
        }

        private void scButton19_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 19;
            string myVal19 = Properties.Settings.Default.shortcutImage19;
            EditShortcutWindow esw19 = new EditShortcutWindow(myVal19);
            esw19.Show();
        }

        private void scButton20_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 20;
            string myVal20 = Properties.Settings.Default.shortcutImage20;
            EditShortcutWindow esw20 = new EditShortcutWindow(myVal20);
            esw20.Show();
        }

        private void scButton21_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 21;
            string myVal21 = Properties.Settings.Default.shortcutImage21;
            EditShortcutWindow esw21 = new EditShortcutWindow(myVal21);
            esw21.Show();
        }

        private void scButton22_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 22;
            string myVal22 = Properties.Settings.Default.shortcutImage22;
            EditShortcutWindow esw22 = new EditShortcutWindow(myVal22);
            esw22.Show();
        }

        private void scButton23_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 23;
            string myVal23 = Properties.Settings.Default.shortcutImage23;
            EditShortcutWindow esw23 = new EditShortcutWindow(myVal23);
            esw23.Show();
        }

        private void scButton24_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 24;
            string myVal24 = Properties.Settings.Default.shortcutImage24;
            EditShortcutWindow esw24 = new EditShortcutWindow(myVal24);
            esw24.Show();
        }

        private void scButton25_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 25;
            string myVal25 = Properties.Settings.Default.shortcutImage25;
            EditShortcutWindow esw25 = new EditShortcutWindow(myVal25);
            esw25.Show();
        }

        private void scButton26_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 26;
            string myVal26 = Properties.Settings.Default.shortcutImage26;
            EditShortcutWindow esw26 = new EditShortcutWindow(myVal26);
            esw26.Show();
        }

        private void scButton27_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 27;
            string myVal27 = Properties.Settings.Default.shortcutImage27;
            EditShortcutWindow esw27 = new EditShortcutWindow(myVal27);
            esw27.Show();
        }

        private void scButton28_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 28;
            string myVal28 = Properties.Settings.Default.shortcutImage28;
            EditShortcutWindow esw28 = new EditShortcutWindow(myVal28);
            esw28.Show();
        }

        private void scButton29_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 29;
            string myVal29 = Properties.Settings.Default.shortcutImage29;
            EditShortcutWindow esw29 = new EditShortcutWindow(myVal29);
            esw29.Show();
        }

        private void scButton30_Edit(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.buttonNumber = 30;
            string myVal30 = Properties.Settings.Default.shortcutImage30;
            EditShortcutWindow esw30 = new EditShortcutWindow(myVal30);
            esw30.Show();
        }

        //Reset click events
        private void scButton1_Reset(object sender, RoutedEventArgs e)
        {
            //Set button1 image back to default

            Properties.Settings.Default.buttonNumber = 1;
            string myVal = Properties.Settings.Default.shortcutImage1;
            EditShortcutWindow esw1 = new EditShortcutWindow(myVal);
            esw1.Show();
        }
    }
}
