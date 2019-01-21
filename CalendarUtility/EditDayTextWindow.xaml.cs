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
using System.Windows.Threading;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for EditDayTextWindow.xaml
    /// </summary>
    public partial class EditDayTextWindow : Window
    {
        public EditDayTextWindow()
        {
            InitializeComponent();

            Calendar cal = new Calendar();

            int choice = CalendarUtility.Properties.Settings.Default.buttonChoice;
            switch (choice)
            {
                case 1:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day1;
                    this.Title = cal.Month.Content + " " + cal.day1Label2.Content.ToString();
                    break;
                case 2:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day2;
                    this.Title = cal.Month.Content + " " + cal.day2Label2.Content.ToString();
                    break;
                case 3:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day3;
                    this.Title = cal.Month.Content + " " + cal.day3Label2.Content.ToString();
                    break;
                case 4:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day4;
                    this.Title = cal.Month.Content + " " + cal.day4Label2.Content.ToString();
                    break;
                case 5:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day5;
                    this.Title = cal.Month.Content + " " + cal.day5Label2.Content.ToString();
                    break;
                case 6:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day6;
                    this.Title = cal.Month.Content + " " + cal.day6Label2.Content.ToString();
                    break;
                case 7:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day7;
                    this.Title = cal.Month.Content + " " + cal.day7Label2.Content.ToString();
                    break;
                case 8:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day8;
                    this.Title = cal.Month.Content + " " + cal.day8Label2.Content.ToString();
                    break;
                case 9:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day9;
                    this.Title = cal.Month.Content + " " + cal.day9Label2.Content.ToString();
                    break;
                case 10:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day10;
                    this.Title = cal.Month.Content + " " + cal.day10Label2.Content.ToString();
                    break;
                case 11:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day11;
                    this.Title = cal.Month.Content + " " + cal.day11Label2.Content.ToString();
                    break;
                case 12:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day12;
                    this.Title = cal.Month.Content + " " + cal.day12Label2.Content.ToString();
                    break;
                case 13:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day13;
                    this.Title = cal.Month.Content + " " + cal.day13Label2.Content.ToString();
                    break;
                case 14:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day14;
                    this.Title = cal.Month.Content + " " + cal.day14Label2.Content.ToString();
                    break;
                case 15:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day15;
                    this.Title = cal.Month.Content + " " + cal.day15Label2.Content.ToString();
                    break;
                case 16:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day16;
                    this.Title = cal.Month.Content + " " + cal.day16Label2.Content.ToString();
                    break;
                case 17:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day17;
                    this.Title = cal.Month.Content + " " + cal.day17Label2.Content.ToString();
                    break;
                case 18:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day18;
                    this.Title = cal.Month.Content + " " + cal.day18Label2.Content.ToString();
                    break;
                case 19:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day19;
                    this.Title = cal.Month.Content + " " + cal.day19Label2.Content.ToString();
                    break;
                case 20:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day20;
                    this.Title = cal.Month.Content + " " + cal.day20Label2.Content.ToString();
                    break;
                case 21:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day21;
                    this.Title = cal.Month.Content + " " + cal.day21Label2.Content.ToString();
                    break;
                case 22:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day22;
                    this.Title = cal.Month.Content + " " + cal.day22Label2.Content.ToString();
                    break;
                case 23:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day23;
                    this.Title = cal.Month.Content + " " + cal.day23Label2.Content.ToString();
                    break;
                case 24:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day24;
                    this.Title = cal.Month.Content + " " + cal.day24Label2.Content.ToString();
                    break;
                case 25:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day25;
                    this.Title = cal.Month.Content + " " + cal.day25Label2.Content.ToString();
                    break;
                case 26:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day26;
                    this.Title = cal.Month.Content + " " + cal.day26Label2.Content.ToString();
                    break;
                case 27:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day27;
                    this.Title = cal.Month.Content + " " + cal.day27Label2.Content.ToString();
                    break;
                case 28:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day28;
                    this.Title = cal.Month.Content + " " + cal.day28Label2.Content.ToString();
                    break;
                case 29:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day29;
                    this.Title = cal.Month.Content + " " + cal.day29Label2.Content.ToString();
                    break;
                case 30:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day30;
                    this.Title = cal.Month.Content + " " + cal.day30Label2.Content.ToString();
                    break;
                case 31:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day31;
                    this.Title = cal.Month.Content + " " + cal.day31Label2.Content.ToString();
                    break;
                case 32:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day32;
                    this.Title = cal.Month.Content + " " + cal.day32Label2.Content.ToString();
                    break;
                case 33:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day33;
                    this.Title = cal.Month.Content + " " + cal.day33Label2.Content.ToString();
                    break;
                case 34:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day34;
                    this.Title = cal.Month.Content + " " + cal.day34Label2.Content.ToString();
                    break;
                case 35:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day35;
                    this.Title = cal.Month.Content + " " + cal.day35Label2.Content.ToString();
                    break;
                case 36:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day36;
                    this.Title = cal.Month.Content + " " + cal.day36Label2.Content.ToString();
                    break;
                case 37:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day37;
                    this.Title = cal.Month.Content + " " + cal.day37Label2.Content.ToString();
                    break;
                case 38:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day38;
                    this.Title = cal.Month.Content + " " + cal.day38Label2.Content.ToString();
                    break;
                case 39:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day39;
                    this.Title = cal.Month.Content + " " + cal.day39Label2.Content.ToString();
                    break;
                case 40:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day40;
                    this.Title = cal.Month.Content + " " + cal.day40Label2.Content.ToString();
                    break;
                case 41:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day41;
                    this.Title = cal.Month.Content + " " + cal.day41Label2.Content.ToString();
                    break;
                case 42:
                    myTextBox.Text = CalendarUtility.Properties.Settings.Default.day42;
                    this.Title = cal.Month.Content + " " + cal.day42Label2.Content.ToString();
                    break;
                }
            }

        private void Window_Closed(object sender, EventArgs e)
        {
            int choice = CalendarUtility.Properties.Settings.Default.buttonChoice;
            switch (choice)
            {
                case 1:
                    CalendarUtility.Properties.Settings.Default.day1 = myTextBox.Text;
                    break;
                case 2:
                    CalendarUtility.Properties.Settings.Default.day2 = myTextBox.Text;
                    break;
                case 3:
                    CalendarUtility.Properties.Settings.Default.day3 = myTextBox.Text;
                    break;
                case 4:
                    CalendarUtility.Properties.Settings.Default.day4 = myTextBox.Text;
                    break;
                case 5:
                    CalendarUtility.Properties.Settings.Default.day5 = myTextBox.Text;
                    break;
                case 6:
                    CalendarUtility.Properties.Settings.Default.day6 = myTextBox.Text;
                    break;
                case 7:
                    CalendarUtility.Properties.Settings.Default.day7 = myTextBox.Text;
                    break;
                case 8:
                    CalendarUtility.Properties.Settings.Default.day8 = myTextBox.Text;
                    break;
                case 9:
                    CalendarUtility.Properties.Settings.Default.day9 = myTextBox.Text;
                    break;
                case 10:
                    CalendarUtility.Properties.Settings.Default.day10 = myTextBox.Text;
                    break;
                case 11:
                    CalendarUtility.Properties.Settings.Default.day11 = myTextBox.Text;
                    break;
                case 12:
                    CalendarUtility.Properties.Settings.Default.day12 = myTextBox.Text;
                    break;
                case 13:
                    CalendarUtility.Properties.Settings.Default.day13 = myTextBox.Text;
                    break;
                case 14:
                    CalendarUtility.Properties.Settings.Default.day14 = myTextBox.Text;
                    break;
                case 15:
                    CalendarUtility.Properties.Settings.Default.day15 = myTextBox.Text;
                    break;
                case 16:
                    CalendarUtility.Properties.Settings.Default.day16 = myTextBox.Text;
                    break;
                case 17:
                    CalendarUtility.Properties.Settings.Default.day17 = myTextBox.Text;
                    break;
                case 18:
                    CalendarUtility.Properties.Settings.Default.day18 = myTextBox.Text;
                    break;
                case 19:
                    CalendarUtility.Properties.Settings.Default.day19 = myTextBox.Text;
                    break;
                case 20:
                    CalendarUtility.Properties.Settings.Default.day20 = myTextBox.Text;
                    break;
                case 21:
                    CalendarUtility.Properties.Settings.Default.day21 = myTextBox.Text;
                    break;
                case 22:
                    CalendarUtility.Properties.Settings.Default.day22 = myTextBox.Text;
                    break;
                case 23:
                    CalendarUtility.Properties.Settings.Default.day23 = myTextBox.Text;
                    break;
                case 24:
                    CalendarUtility.Properties.Settings.Default.day24 = myTextBox.Text;
                    break;
                case 25:
                    CalendarUtility.Properties.Settings.Default.day25 = myTextBox.Text;
                    break;
                case 26:
                    CalendarUtility.Properties.Settings.Default.day26 = myTextBox.Text;
                    break;
                case 27:
                    CalendarUtility.Properties.Settings.Default.day27 = myTextBox.Text;
                    break;
                case 28:
                    CalendarUtility.Properties.Settings.Default.day28 = myTextBox.Text;
                    break;
                case 29:
                    CalendarUtility.Properties.Settings.Default.day29 = myTextBox.Text;
                    break;
                case 30:
                    CalendarUtility.Properties.Settings.Default.day30 = myTextBox.Text;
                    break;
                case 31:
                    CalendarUtility.Properties.Settings.Default.day31 = myTextBox.Text;
                    break;
                case 32:
                    CalendarUtility.Properties.Settings.Default.day32 = myTextBox.Text;
                    break;
                case 33:
                    CalendarUtility.Properties.Settings.Default.day33 = myTextBox.Text;
                    break;
                case 34:
                    CalendarUtility.Properties.Settings.Default.day34 = myTextBox.Text;
                    break;
                case 35:
                    CalendarUtility.Properties.Settings.Default.day35 = myTextBox.Text;
                    break;
                case 36:
                    CalendarUtility.Properties.Settings.Default.day36 = myTextBox.Text;
                    break;
                case 37:
                    CalendarUtility.Properties.Settings.Default.day37 = myTextBox.Text;
                    break;
                case 38:
                    CalendarUtility.Properties.Settings.Default.day38 = myTextBox.Text;
                    break;
                case 39:
                    CalendarUtility.Properties.Settings.Default.day39 = myTextBox.Text;
                    break;
                case 40:
                    CalendarUtility.Properties.Settings.Default.day40 = myTextBox.Text;
                    break;
                case 41:
                    CalendarUtility.Properties.Settings.Default.day41 = myTextBox.Text;
                    break;
                case 42:
                    CalendarUtility.Properties.Settings.Default.day42 = myTextBox.Text;
                    break;
            }
            CalendarUtility.Properties.Settings.Default.Save();
            CalendarUtility.Properties.Settings.Default.Upgrade();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MyTextBox_Loaded(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(DispatcherPriority.ContextIdle, new Action(delegate () { myTextBox.Focus(); }));
        }
    }
}
