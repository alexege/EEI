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
    public partial class Calendar : Page
    {
        int buttonPos;

        public Calendar()
        {
            InitializeComponent();
            monthOfYear();
            getDay();
            setDayOfWeekForegroundColor();
            setDayOfWeekBorderColor();

        }

        public void setDayOfWeekBorderColor()
        {
            var labels = new List<Label> { day1Label, day2Label, day3Label, day4Label, day5Label, day6Label, day7Label, day8Label, day9Label, day10Label, day11Label, day12Label, day13Label, day14Label, day15Label, day16Label, day17Label, day18Label, day19Label, day20Label, day21Label, day22Label, day23Label, day24Label, day25Label, day26Label, day27Label, day28Label, day29Label, day30Label, day31Label, day32Label, day33Label, day34Label, day35Label, day36Label, day37Label, day38Label, day39Label, day40Label, day41Label, day42Label };
            var labels2 = new List<Label> { day1Label2, day2Label2, day3Label2, day4Label2, day5Label2, day6Label2, day7Label2, day8Label2, day9Label2, day10Label2, day11Label2, day12Label2, day13Label2, day14Label2, day15Label2, day16Label2, day17Label2, day18Label2, day19Label2, day20Label2, day21Label2, day22Label2, day23Label2, day24Label2, day25Label2, day26Label2, day27Label2, day28Label2, day29Label2, day30Label2, day31Label2, day32Label2, day33Label2, day34Label2, day35Label2, day36Label2, day37Label2, day38Label2, day39Label2, day40Label2, day41Label2, day42Label2 };

            for(int i = 0; i < labels.Count; i++)
            {
                if(labels2[i].Content.ToString() == DateTime.Now.Date.ToString("dd"))
                {
                    labels2[i].BorderThickness = new Thickness(3);
                    labels2[i].BorderBrush = Brushes.Yellow;
                }
            }
        }

        public void setDayOfWeekForegroundColor()
        {
            //Get day of week
            string day = DateTime.Now.DayOfWeek.ToString();

            //Create a custom brush that takes value from settings "
            BrushConverter bc = new BrushConverter();
            SolidColorBrush customColor = bc.ConvertFromString(Properties.Settings.Default.MainWindowForeground.ToString()) as SolidColorBrush;

            switch (day)
            {
                case "Sunday":
                    SundayLabel.Foreground = Brushes.Yellow;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Monday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = Brushes.Yellow;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Tuesday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = Brushes.Yellow;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Wednesday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = Brushes.Yellow; 
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Thursday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = Brushes.Yellow; 
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Friday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = Brushes.Yellow; 
                    SaturdayLabel.Foreground = customColor;
                    break;
                case "Saturday":
                    SundayLabel.Foreground = customColor;
                    MondayLabel.Foreground = customColor;
                    TuesdayLabel.Foreground = customColor;
                    WednesdayLabel.Foreground = customColor;
                    ThursdayLabel.Foreground = customColor;
                    FridayLabel.Foreground = customColor;
                    SaturdayLabel.Foreground = Brushes.Yellow; 
                    break;
            }
        }

        //Grab 1st day of the month and set first box to position on grid
        public int getDay()
        {
            //Grab current year and convert to int
            String whatYear = DateTime.Now.ToString("yyyy");
            String stryear = whatYear.Substring(0);
            int year = Int32.Parse(stryear);

            //Grab current month and convert to int
            String whatMonth = DateTime.Now.ToString("MM");
            String strmonth = whatMonth.Substring(0);
            int month = Int32.Parse(strmonth);

            //Grab days in month
            int days = DateTime.DaysInMonth(year, month);
            //Set dateValue to year, month, day1
            DateTime dateValue = new DateTime(year, month, 1);

            //Stored labels in array "Names" and "Names2"


            Control[] Names = { day1Label, day2Label, day3Label, day4Label, day5Label, day6Label, day7Label, day8Label, day9Label, day10Label, day11Label, day12Label, day13Label, day14Label, day15Label, day16Label, day17Label, day18Label, day19Label, day20Label, day21Label, day22Label, day23Label, day24Label, day25Label, day26Label, day27Label, day28Label, day29Label, day30Label, day31Label, day32Label, day33Label, day34Label, day35Label, day36Label, day37Label, day38Label, day39Label, day40Label, day41Label, day42Label, };
            Control[] Names2 = { day1Label2, day2Label2, day3Label2, day4Label2, day5Label2, day6Label2, day7Label2, day8Label2, day9Label2, day10Label2, day11Label2, day12Label2, day13Label2, day14Label2, day15Label2, day16Label2, day17Label2, day18Label2, day19Label2, day20Label2, day21Label2, day22Label2, day23Label2, day24Label2, day25Label2, day26Label2, day27Label2, day28Label2, day29Label2, day30Label2, day31Label2, day32Label2, day33Label2, day34Label2, day35Label2, day36Label2, day37Label2, day38Label2, day39Label2, day40Label2, day41Label2, day42Label2 };

            //Trying to set border background of current date to yellow.
            //for(int i = 0; i < Names2.Length; i++)
            //{
            //    if (Names2[i].ToString() == "System.Windows.Controls.Label: " + DateTime.Now.ToString(" d").Trim()){
            //        MessageBox.Show("Today's date is the: " + Names2[i].ToString());
            //        Names2[i].BorderBrush = Brushes.Yellow;
            //        Names2[i].BorderThickness = new Thickness(3);
            //    }
            //}

            //Change outline color to yellow of currentday
            //if (DateTime.Now.ToString() == )
            //for(int i = 0; i < 42; i++) {
            //    if (Names[i].ToString() == DateTime.Now.ToString())
            //    {
            //        this.Background = Brushes.Yellow;
            //    }
            //}


                //Test calendar - comment out int days ^, and comment out first day of month switch statement
                //int buttonPos = 3;
                //int days = 31;

            //Find first day of month and set to string
            if (dateValue.DayOfWeek.ToString() == "Sunday")
            {
                buttonPos = 0;
            }
            else if (dateValue.DayOfWeek.ToString() == "Monday")
            {
                buttonPos = 1;
            }
            else if (dateValue.DayOfWeek.ToString() == "Tuesday")
            {
                buttonPos = 2;
            }
            else if (dateValue.DayOfWeek.ToString() == "Wednesday")
            {
                buttonPos = 3;
            }
            else if (dateValue.DayOfWeek.ToString() == "Thursday")
            {
                buttonPos = 4;
            }
            else if (dateValue.DayOfWeek.ToString() == "Friday")
            {
                buttonPos = 5;
            }
            else if (dateValue.DayOfWeek.ToString() == "Saturday")
            {
                buttonPos = 6;
            }

            #region Position day cells based on starting day and days in month
            //buttonPos 0->6 && days == 28
            if (days == 28 && buttonPos == 0) //Sunday is first day of month
            {
                for (int i = 28; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }
                #region dayLabels
                day1Label2.Content = "1";
                day2Label2.Content = "2";
                day3Label2.Content = "3";
                day4Label2.Content = "4";
                day5Label2.Content = "5";
                day6Label2.Content = "6";
                day7Label2.Content = "7";
                day8Label2.Content = "8";
                day9Label2.Content = "9";
                day10Label2.Content = "10";
                day11Label2.Content = "11";
                day12Label2.Content = "12";
                day13Label2.Content = "13";
                day14Label2.Content = "14";
                day15Label2.Content = "15";
                day16Label2.Content = "16";
                day17Label2.Content = "17";
                day18Label2.Content = "18";
                day19Label2.Content = "19";
                day20Label2.Content = "20";
                day21Label2.Content = "21";
                day22Label2.Content = "22";
                day23Label2.Content = "23";
                day24Label2.Content = "24";
                day25Label2.Content = "25";
                day26Label2.Content = "26";
                day27Label2.Content = "27";
                day28Label2.Content = "28";
                day29Label2.Content = "29";
                day30Label2.Content = "30";
                day31Label2.Content = "31";
                day32Label2.Content = "32";
                day33Label2.Content = "33";
                day34Label2.Content = "34";
                day35Label2.Content = "35";
                day36Label2.Content = "36";
                day37Label2.Content = "37";
                day38Label2.Content = "38";
                day39Label2.Content = "39";
                day40Label2.Content = "40";
                day41Label2.Content = "41";
                day42Label2.Content = "42";
                #endregion
            }
            else if (days == 28 && buttonPos == 1)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                for (int i = 29; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content  = "";
                day2Label2.Content  = "1";
                day3Label2.Content  = "2";
                day4Label2.Content  = "3";
                day5Label2.Content  = "4";
                day6Label2.Content  = "5";
                day7Label2.Content  = "6";
                day8Label2.Content  = "7";
                day9Label2.Content  = "8";
                day10Label2.Content = "9";
                day11Label2.Content = "10";
                day12Label2.Content = "11";
                day13Label2.Content = "12";
                day14Label2.Content = "13";
                day15Label2.Content = "14";
                day16Label2.Content = "15";
                day17Label2.Content = "16";
                day18Label2.Content = "17";
                day19Label2.Content = "18";
                day20Label2.Content = "19";
                day21Label2.Content = "20";
                day22Label2.Content = "21";
                day23Label2.Content = "22";
                day24Label2.Content = "23";
                day25Label2.Content = "24";
                day26Label2.Content = "25";
                day27Label2.Content = "26";
                day28Label2.Content = "27";
                day29Label2.Content = "28";
                day30Label2.Content = "";
                day31Label2.Content = "";
                #endregion
            }
            else if (days == 28 && buttonPos == 2)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                for (int i = 30; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "1";
                day4Label2.Content = "2";
                day5Label2.Content = "3";
                day6Label2.Content = "4";
                day7Label2.Content = "5";
                day8Label2.Content = "6";
                day9Label2.Content = "7";
                day10Label2.Content = "8";
                day11Label2.Content = "9";
                day12Label2.Content = "10";
                day13Label2.Content = "11";
                day14Label2.Content = "12";
                day15Label2.Content = "13";
                day16Label2.Content = "14";
                day17Label2.Content = "15";
                day18Label2.Content = "16";
                day19Label2.Content = "17";
                day20Label2.Content = "18";
                day21Label2.Content = "19";
                day22Label2.Content = "20";
                day23Label2.Content = "21";
                day24Label2.Content = "22";
                day25Label2.Content = "23";
                day26Label2.Content = "24";
                day27Label2.Content = "25";
                day28Label2.Content = "26";
                day29Label2.Content = "27";
                day30Label2.Content = "28";
                day31Label2.Content = "";
                #endregion
            }
            else if (days == 28 && buttonPos == 3)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                for (int i = 31; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "1";
                day5Label2.Content = "2";
                day6Label2.Content = "3";
                day7Label2.Content = "4";
                day8Label2.Content = "5";
                day9Label2.Content = "6";
                day10Label2.Content = "7";
                day11Label2.Content = "8";
                day12Label2.Content = "9";
                day13Label2.Content = "10";
                day14Label2.Content = "11";
                day15Label2.Content = "12";
                day16Label2.Content = "13";
                day17Label2.Content = "14";
                day18Label2.Content = "15";
                day19Label2.Content = "16";
                day20Label2.Content = "17";
                day21Label2.Content = "18";
                day22Label2.Content = "19";
                day23Label2.Content = "20";
                day24Label2.Content = "21";
                day25Label2.Content = "22";
                day26Label2.Content = "23";
                day27Label2.Content = "24";
                day28Label2.Content = "25";
                day29Label2.Content = "26";
                day30Label2.Content = "27";
                day31Label2.Content = "28";
                #endregion
            }
            else if (days == 28 && buttonPos == 4)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                for (int i = 32; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "1";
                day6Label2.Content = "2";
                day7Label2.Content = "3";
                day8Label2.Content = "4";
                day9Label2.Content = "5";
                day10Label2.Content = "6";
                day11Label2.Content = "7";
                day12Label2.Content = "8";
                day13Label2.Content = "9";
                day14Label2.Content = "10";
                day15Label2.Content = "11";
                day16Label2.Content = "12";
                day17Label2.Content = "13";
                day18Label2.Content = "14";
                day19Label2.Content = "15";
                day20Label2.Content = "16";
                day21Label2.Content = "17";
                day22Label2.Content = "18";
                day23Label2.Content = "19";
                day24Label2.Content = "20";
                day25Label2.Content = "21";
                day26Label2.Content = "22";
                day27Label2.Content = "23";
                day28Label2.Content = "24";
                day29Label2.Content = "25";
                day30Label2.Content = "26";
                day31Label2.Content = "27";
                day32Label2.Content = "28";
                #endregion
            }
            else if (days == 28 && buttonPos == 5)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                for (int i = 33; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "1";
                day7Label2.Content = "2";
                day8Label2.Content = "3";
                day9Label2.Content = "4";
                day10Label2.Content = "5";
                day11Label2.Content = "6";
                day12Label2.Content = "7";
                day13Label2.Content = "8";
                day14Label2.Content = "9";
                day15Label2.Content = "10";
                day16Label2.Content = "11";
                day17Label2.Content = "12";
                day18Label2.Content = "13";
                day19Label2.Content = "14";
                day20Label2.Content = "15";
                day21Label2.Content = "16";
                day22Label2.Content = "17";
                day23Label2.Content = "18";
                day24Label2.Content = "19";
                day25Label2.Content = "20";
                day26Label2.Content = "21";
                day27Label2.Content = "22";
                day28Label2.Content = "23";
                day29Label2.Content = "24";
                day30Label2.Content = "25";
                day31Label2.Content = "26";
                day32Label2.Content = "27";
                day33Label2.Content = "28";
                #endregion

            }
            else if (days == 28 && buttonPos == 6)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                Names[5].Visibility = Visibility.Collapsed;
                Names2[5].Visibility = Visibility.Collapsed;

                for (int i = 34; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "";
                day7Label2.Content = "1";
                day8Label2.Content = "2";
                day9Label2.Content = "3";
                day10Label2.Content = "4";
                day11Label2.Content = "5";
                day12Label2.Content = "6";
                day13Label2.Content = "7";
                day14Label2.Content = "8";
                day15Label2.Content = "9";
                day16Label2.Content = "10";
                day17Label2.Content = "11";
                day18Label2.Content = "12";
                day19Label2.Content = "13";
                day20Label2.Content = "14";
                day21Label2.Content = "15";
                day22Label2.Content = "16";
                day23Label2.Content = "17";
                day24Label2.Content = "18";
                day25Label2.Content = "19";
                day26Label2.Content = "20";
                day27Label2.Content = "21";
                day28Label2.Content = "22";
                day29Label2.Content = "23";
                day30Label2.Content = "24";
                day31Label2.Content = "25";
                day32Label2.Content = "26";
                day33Label2.Content = "27";
                day34Label2.Content = "28";
                #endregion
            }
            //buttonPos 0->6 && days == 30
            if (days == 30 && buttonPos == 0) //Sunday is first day of month
            {
                for (int i = 30; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "1";
                day2Label2.Content = "2";
                day3Label2.Content = "3";
                day4Label2.Content = "4";
                day5Label2.Content = "5";
                day6Label2.Content = "6";
                day7Label2.Content = "7";
                day8Label2.Content = "8";
                day9Label2.Content = "9";
                day10Label2.Content = "10";
                day11Label2.Content = "11";
                day12Label2.Content = "12";
                day13Label2.Content = "13";
                day14Label2.Content = "14";
                day15Label2.Content = "15";
                day16Label2.Content = "16";
                day17Label2.Content = "17";
                day18Label2.Content = "18";
                day19Label2.Content = "19";
                day20Label2.Content = "20";
                day21Label2.Content = "21";
                day22Label2.Content = "22";
                day23Label2.Content = "23";
                day24Label2.Content = "24";
                day25Label2.Content = "25";
                day26Label2.Content = "26";
                day27Label2.Content = "27";
                day28Label2.Content = "28";
                day29Label2.Content = "29";
                day30Label2.Content = "30";
                day31Label2.Content = "";
                day32Label2.Content = "";
                day33Label2.Content = "";
                day34Label2.Content = "";
                day35Label2.Content = "";
                day36Label2.Content = "";
                day37Label2.Content = "";
                day38Label2.Content = "";
                day39Label2.Content = "";
                day40Label2.Content = "";
                day41Label2.Content = "";
                day42Label2.Content = "";
                #endregion
            }
            else if (days == 30 && buttonPos == 1) //Monday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                for (int i = 31; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "1";
                day3Label2.Content = "2";
                day4Label2.Content = "3";
                day5Label2.Content = "4";
                day6Label2.Content = "5";
                day7Label2.Content = "6";
                day8Label2.Content = "7";
                day9Label2.Content = "8";
                day10Label2.Content = "9";
                day11Label2.Content = "10";
                day12Label2.Content = "11";
                day13Label2.Content = "12";
                day14Label2.Content = "13";
                day15Label2.Content = "14";
                day16Label2.Content = "15";
                day17Label2.Content = "16";
                day18Label2.Content = "17";
                day19Label2.Content = "18";
                day20Label2.Content = "19";
                day21Label2.Content = "20";
                day22Label2.Content = "21";
                day23Label2.Content = "22";
                day24Label2.Content = "23";
                day25Label2.Content = "24";
                day26Label2.Content = "25";
                day27Label2.Content = "26";
                day28Label2.Content = "27";
                day29Label2.Content = "28";
                day30Label2.Content = "29";
                day31Label2.Content = "30";
                #endregion
            }
            else if (days == 30 && buttonPos == 2) //Tuesday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                for (int i = 32; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "1";
                day4Label2.Content = "2";
                day5Label2.Content = "3";
                day6Label2.Content = "4";
                day7Label2.Content = "5";
                day8Label2.Content = "6";
                day9Label2.Content = "7";
                day10Label2.Content = "8";
                day11Label2.Content = "9";
                day12Label2.Content = "10";
                day13Label2.Content = "11";
                day14Label2.Content = "12";
                day15Label2.Content = "13";
                day16Label2.Content = "14";
                day17Label2.Content = "15";
                day18Label2.Content = "16";
                day19Label2.Content = "17";
                day20Label2.Content = "18";
                day21Label2.Content = "19";
                day22Label2.Content = "20";
                day23Label2.Content = "21";
                day24Label2.Content = "22";
                day25Label2.Content = "23";
                day26Label2.Content = "24";
                day27Label2.Content = "25";
                day28Label2.Content = "26";
                day29Label2.Content = "27";
                day30Label2.Content = "28";
                day31Label2.Content = "29";
                day32Label2.Content = "30";
                #endregion
            }
            else if (days == 30 && buttonPos == 3) //Wednesday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                for (int i = 33; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "1";
                day5Label2.Content = "2";
                day6Label2.Content = "3";
                day7Label2.Content = "4";
                day8Label2.Content = "5";
                day9Label2.Content = "6";
                day10Label2.Content = "7";
                day11Label2.Content = "8";
                day12Label2.Content = "9";
                day13Label2.Content = "10";
                day14Label2.Content = "11";
                day15Label2.Content = "12";
                day16Label2.Content = "13";
                day17Label2.Content = "14";
                day18Label2.Content = "15";
                day19Label2.Content = "16";
                day20Label2.Content = "17";
                day21Label2.Content = "18";
                day22Label2.Content = "19";
                day23Label2.Content = "20";
                day24Label2.Content = "21";
                day25Label2.Content = "22";
                day26Label2.Content = "23";
                day27Label2.Content = "24";
                day28Label2.Content = "25";
                day29Label2.Content = "26";
                day30Label2.Content = "27";
                day31Label2.Content = "28";
                day32Label2.Content = "29";
                day33Label2.Content = "30";
                #endregion
            }
            else if (days == 30 && buttonPos == 4) //Thursday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                for (int i = 34; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "1";
                day6Label2.Content = "2";
                day7Label2.Content = "3";
                day8Label2.Content = "4";
                day9Label2.Content = "5";
                day10Label2.Content = "6";
                day11Label2.Content = "7";
                day12Label2.Content = "8";
                day13Label2.Content = "9";
                day14Label2.Content = "10";
                day15Label2.Content = "11";
                day16Label2.Content = "12";
                day17Label2.Content = "13";
                day18Label2.Content = "14";
                day19Label2.Content = "15";
                day20Label2.Content = "16";
                day21Label2.Content = "17";
                day22Label2.Content = "18";
                day23Label2.Content = "19";
                day24Label2.Content = "20";
                day25Label2.Content = "21";
                day26Label2.Content = "22";
                day27Label2.Content = "23";
                day28Label2.Content = "24";
                day29Label2.Content = "25";
                day30Label2.Content = "26";
                day31Label2.Content = "27";
                day32Label2.Content = "28";
                day33Label2.Content = "29";
                day34Label2.Content = "30";
                #endregion
            }
            else if (days == 30 && buttonPos == 5) //Friday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                for (int i = 35; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "1";
                day7Label2.Content = "2";
                day8Label2.Content = "3";
                day9Label2.Content = "4";
                day10Label2.Content = "5";
                day11Label2.Content = "6";
                day12Label2.Content = "7";
                day13Label2.Content = "8";
                day14Label2.Content = "9";
                day15Label2.Content = "10";
                day16Label2.Content = "11";
                day17Label2.Content = "12";
                day18Label2.Content = "13";
                day19Label2.Content = "14";
                day20Label2.Content = "15";
                day21Label2.Content = "16";
                day22Label2.Content = "17";
                day23Label2.Content = "18";
                day24Label2.Content = "19";
                day25Label2.Content = "20";
                day26Label2.Content = "21";
                day27Label2.Content = "22";
                day28Label2.Content = "23";
                day29Label2.Content = "24";
                day30Label2.Content = "25";
                day31Label2.Content = "26";
                day32Label2.Content = "27";
                day33Label2.Content = "28";
                day34Label2.Content = "29";
                day35Label2.Content = "30";
                #endregion
            }
            else if (days == 30 && buttonPos == 6) //Saturday is first day of month
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                Names[5].Visibility = Visibility.Collapsed;
                Names2[5].Visibility = Visibility.Collapsed;

                for (int i = 36; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "";
                day7Label2.Content = "1";
                day8Label2.Content = "2";
                day9Label2.Content = "3";
                day10Label2.Content = "4";
                day11Label2.Content = "5";
                day12Label2.Content = "6";
                day13Label2.Content = "7";
                day14Label2.Content = "8";
                day15Label2.Content = "9";
                day16Label2.Content = "10";
                day17Label2.Content = "11";
                day18Label2.Content = "12";
                day19Label2.Content = "13";
                day20Label2.Content = "14";
                day21Label2.Content = "15";
                day22Label2.Content = "16";
                day23Label2.Content = "17";
                day24Label2.Content = "18";
                day25Label2.Content = "19";
                day26Label2.Content = "20";
                day27Label2.Content = "21";
                day28Label2.Content = "22";
                day29Label2.Content = "23";
                day30Label2.Content = "24";
                day31Label2.Content = "25";
                day32Label2.Content = "26";
                day33Label2.Content = "27";
                day34Label2.Content = "28";
                day35Label2.Content = "29";
                day36Label2.Content = "30";
                #endregion
            }
            //buttonPos 0->6 && days == 31
            if (days == 31 && buttonPos == 0) //Sunday is first day of month
            {
                for (int i = 31; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "1";
                day2Label2.Content = "2";
                day3Label2.Content = "3";
                day4Label2.Content = "4";
                day5Label2.Content = "5";
                day6Label2.Content = "6";
                day7Label2.Content = "7";
                day8Label2.Content = "8";
                day9Label2.Content = "9";
                day10Label2.Content = "10";
                day11Label2.Content = "11";
                day12Label2.Content = "12";
                day13Label2.Content = "13";
                day14Label2.Content = "14";
                day15Label2.Content = "15";
                day16Label2.Content = "16";
                day17Label2.Content = "17";
                day18Label2.Content = "18";
                day19Label2.Content = "19";
                day20Label2.Content = "20";
                day21Label2.Content = "21";
                day22Label2.Content = "22";
                day23Label2.Content = "23";
                day24Label2.Content = "24";
                day25Label2.Content = "25";
                day26Label2.Content = "26";
                day27Label2.Content = "27";
                day28Label2.Content = "28";
                day29Label2.Content = "29";
                day30Label2.Content = "30";
                day31Label2.Content = "31";
                day32Label2.Content = "";
                day33Label2.Content = "";
                day34Label2.Content = "";
                day35Label2.Content = "";
                day36Label2.Content = "";
                day37Label2.Content = "";
                day38Label2.Content = "";
                day39Label2.Content = "";
                day40Label2.Content = "";
                day41Label2.Content = "";
                day42Label2.Content = "";
                #endregion
            }
            else if (days == 31 && buttonPos == 1)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                for (int i = 32; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "1";
                day3Label2.Content = "2";
                day4Label2.Content = "3";
                day5Label2.Content = "4";
                day6Label2.Content = "5";
                day7Label2.Content = "6";
                day8Label2.Content = "7";
                day9Label2.Content = "8";
                day10Label2.Content = "9";
                day11Label2.Content = "10";
                day12Label2.Content = "11";
                day13Label2.Content = "12";
                day14Label2.Content = "13";
                day15Label2.Content = "14";
                day16Label2.Content = "15";
                day17Label2.Content = "16";
                day18Label2.Content = "17";
                day19Label2.Content = "18";
                day20Label2.Content = "19";
                day21Label2.Content = "20";
                day22Label2.Content = "21";
                day23Label2.Content = "22";
                day24Label2.Content = "23";
                day25Label2.Content = "24";
                day26Label2.Content = "25";
                day27Label2.Content = "26";
                day28Label2.Content = "27";
                day29Label2.Content = "28";
                day30Label2.Content = "29";
                day31Label2.Content = "30";
                day32Label2.Content = "31";
                #endregion
            }
            else if (days == 31 && buttonPos == 2)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                for (int i = 33; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "1";
                day4Label2.Content = "2";
                day5Label2.Content = "3";
                day6Label2.Content = "4";
                day7Label2.Content = "5";
                day8Label2.Content = "6";
                day9Label2.Content = "7";
                day10Label2.Content = "8";
                day11Label2.Content = "9";
                day12Label2.Content = "10";
                day13Label2.Content = "11";
                day14Label2.Content = "12";
                day15Label2.Content = "13";
                day16Label2.Content = "14";
                day17Label2.Content = "15";
                day18Label2.Content = "16";
                day19Label2.Content = "17";
                day20Label2.Content = "18";
                day21Label2.Content = "19";
                day22Label2.Content = "20";
                day23Label2.Content = "21";
                day24Label2.Content = "22";
                day25Label2.Content = "23";
                day26Label2.Content = "24";
                day27Label2.Content = "25";
                day28Label2.Content = "26";
                day29Label2.Content = "27";
                day30Label2.Content = "28";
                day31Label2.Content = "29";
                day32Label2.Content = "30";
                day33Label2.Content = "31";
                #endregion
            }
            else if (days == 31 && buttonPos == 3)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                for (int i = 34; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "1";
                day5Label2.Content = "2";
                day6Label2.Content = "3";
                day7Label2.Content = "4";
                day8Label2.Content = "5";
                day9Label2.Content = "6";
                day10Label2.Content = "7";
                day11Label2.Content = "8";
                day12Label2.Content = "9";
                day13Label2.Content = "10";
                day14Label2.Content = "11";
                day15Label2.Content = "12";
                day16Label2.Content = "13";
                day17Label2.Content = "14";
                day18Label2.Content = "15";
                day19Label2.Content = "16";
                day20Label2.Content = "17";
                day21Label2.Content = "18";
                day22Label2.Content = "19";
                day23Label2.Content = "20";
                day24Label2.Content = "21";
                day25Label2.Content = "22";
                day26Label2.Content = "23";
                day27Label2.Content = "24";
                day28Label2.Content = "25";
                day29Label2.Content = "26";
                day30Label2.Content = "27";
                day31Label2.Content = "28";
                day32Label2.Content = "29";
                day33Label2.Content = "30";
                day34Label2.Content = "31";
                #endregion
            }
            else if (days == 31 && buttonPos == 4)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                for (int i = 35; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "1";
                day6Label2.Content = "2";
                day7Label2.Content = "3";
                day8Label2.Content = "4";
                day9Label2.Content = "5";
                day10Label2.Content = "6";
                day11Label2.Content = "7";
                day12Label2.Content = "8";
                day13Label2.Content = "9";
                day14Label2.Content = "10";
                day15Label2.Content = "11";
                day16Label2.Content = "12";
                day17Label2.Content = "13";
                day18Label2.Content = "14";
                day19Label2.Content = "15";
                day20Label2.Content = "16";
                day21Label2.Content = "17";
                day22Label2.Content = "18";
                day23Label2.Content = "19";
                day24Label2.Content = "20";
                day25Label2.Content = "21";
                day26Label2.Content = "22";
                day27Label2.Content = "23";
                day28Label2.Content = "24";
                day29Label2.Content = "25";
                day30Label2.Content = "26";
                day31Label2.Content = "27";
                day32Label2.Content = "28";
                day33Label2.Content = "29";
                day34Label2.Content = "30";
                day35Label2.Content = "31";
                #endregion
            }
            else if (days == 31 && buttonPos == 5)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                for (int i = 36; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "1";
                day7Label2.Content = "2";
                day8Label2.Content = "3";
                day9Label2.Content = "4";
                day10Label2.Content = "5";
                day11Label2.Content = "6";
                day12Label2.Content = "7";
                day13Label2.Content = "8";
                day14Label2.Content = "9";
                day15Label2.Content = "10";
                day16Label2.Content = "11";
                day17Label2.Content = "12";
                day18Label2.Content = "13";
                day19Label2.Content = "14";
                day20Label2.Content = "15";
                day21Label2.Content = "16";
                day22Label2.Content = "17";
                day23Label2.Content = "18";
                day24Label2.Content = "19";
                day25Label2.Content = "20";
                day26Label2.Content = "21";
                day27Label2.Content = "22";
                day28Label2.Content = "23";
                day29Label2.Content = "24";
                day30Label2.Content = "25";
                day31Label2.Content = "26";
                day32Label2.Content = "27";
                day33Label2.Content = "28";
                day34Label2.Content = "29";
                day35Label2.Content = "30";
                day36Label2.Content = "31";
                #endregion
            }
            else if (days == 31 && buttonPos == 6)
            {
                Names[0].Visibility = Visibility.Collapsed;
                Names2[0].Visibility = Visibility.Collapsed;
                Names[1].Visibility = Visibility.Collapsed;
                Names2[1].Visibility = Visibility.Collapsed;
                Names[2].Visibility = Visibility.Collapsed;
                Names2[2].Visibility = Visibility.Collapsed;
                Names[3].Visibility = Visibility.Collapsed;
                Names2[3].Visibility = Visibility.Collapsed;
                Names[4].Visibility = Visibility.Collapsed;
                Names2[4].Visibility = Visibility.Collapsed;
                Names[5].Visibility = Visibility.Collapsed;
                Names2[5].Visibility = Visibility.Collapsed;

                for (int i = 37; i < 42; i++)
                {
                    Names[i].Visibility = Visibility.Collapsed;
                    Names2[i].Visibility = Visibility.Collapsed;
                }

                #region dayLabels
                day1Label2.Content = "";
                day2Label2.Content = "";
                day3Label2.Content = "";
                day4Label2.Content = "";
                day5Label2.Content = "";
                day6Label2.Content = "";
                day7Label2.Content = "1";
                day8Label2.Content = "2";
                day9Label2.Content = "3";
                day10Label2.Content = "4";
                day11Label2.Content = "5";
                day12Label2.Content = "6";
                day13Label2.Content = "7";
                day14Label2.Content = "8";
                day15Label2.Content = "9";
                day16Label2.Content = "10";
                day17Label2.Content = "11";
                day18Label2.Content = "12";
                day19Label2.Content = "13";
                day20Label2.Content = "14";
                day21Label2.Content = "15";
                day22Label2.Content = "16";
                day23Label2.Content = "17";
                day24Label2.Content = "18";
                day25Label2.Content = "19";
                day26Label2.Content = "20";
                day27Label2.Content = "21";
                day28Label2.Content = "22";
                day29Label2.Content = "23";
                day30Label2.Content = "24";
                day31Label2.Content = "25";
                day32Label2.Content = "26";
                day33Label2.Content = "27";
                day34Label2.Content = "28";
                day35Label2.Content = "29";
                day36Label2.Content = "30";
                day37Label2.Content = "31";
                #endregion
            }
            else
            {
                //MessageBox.Show("Error Line 50 Calendar.xaml");
            }
            #endregion

            return buttonPos;
            }


        #region Find month of year
        //Find month of the year: Convert "MM" to Integer to String "January"
        public void monthOfYear()
        {
            String whtMonth = DateTime.Now.ToString("MM");
            
            switch (whtMonth)
            {
                case "01":
                    Month.Content = "January";
                    break;
                case "02":
                    Month.Content = "February";
                    break;
                case "03":
                    Month.Content = "March";
                    break;
                case "04":
                    Month.Content = "April";
                    break;
                case "05":
                    Month.Content = "May";
                    break;
                case "06":
                    Month.Content = "June";
                    break;
                case "07":
                    Month.Content = "July";
                    break;
                case "08":
                    Month.Content = "August";
                    break;
                case "09":
                    Month.Content = "September";
                    break;
                case "10":
                    Month.Content = "October";
                    break;
                case "11":
                    Month.Content = "November";
                    break;
                case "12":
                    Month.Content = "December";
                    break;
            }
        }
        #endregion

        #region MouseDownEvents
        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 1;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }

        private void Label_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 2;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }

        private void Label_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 3;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }

        private void Label_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 4;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 5;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 6;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown6(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 7;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown7(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 8;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown8(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 9;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown9(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 10;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown10(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 11;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown11(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 12;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown12(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 13;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown13(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 14;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown14(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 15;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown15(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 16;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown16(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 17;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown17(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 18;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown18(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 19;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown19(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 20;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown20(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 21;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown21(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 22;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown22(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 23;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown23(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 24;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown24(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 25;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown25(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 26;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown26(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 27;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown27(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 28;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown28(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 29;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown29(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 30;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown30(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 31;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown31(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 32;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown32(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 33;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown33(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 34;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown34(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 35;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown35(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 36;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown36(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 37;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown37(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 38;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown38(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 39;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown39(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 40;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown40(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 41;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        private void Label_MouseDown41(object sender, MouseButtonEventArgs e)
        {
            CalendarUtility.Properties.Settings.Default.buttonChoice = 42;
            EditDayTextWindow edit = new EditDayTextWindow();
            edit.Show();
        }
        #endregion
    }
}
