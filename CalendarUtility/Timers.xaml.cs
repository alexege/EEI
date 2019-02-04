using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Threading;
using System.Diagnostics;
using System.Media;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for Timers.xaml
    /// </summary>
    public partial class Timers : Page
    {
        public string customTime;

        //Timer Custom
        int timeHours = 0;
        int timeMinutes = 0;
        int timeSeconds = 0;
        private DispatcherTimer Timer;

        //Stopwatch
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        //CountDown Timer

        public Timers()
        {
            InitializeComponent();

            //Stopwatch
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);

            //Timer
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
        }

        //Timer Timer_Tick()
        void Timer_Tick(Object sender, EventArgs e)
        {
            customTime = HoursTextBox.Text + MinutesTextBox.Text + SecondsTextBox.Text;
            //MessageBox.Show("Test1: " + tbTime.Text.Substring(0,2));
            //MessageBox.Show("Test 2: "+ tbTime.Text.Substring(3,2));
            //MessageBox.Show("Test 3: " + tbTime.Text.Substring(6, 2));
            //MessageBox.Show(tbTime.Text.Substring(0, 2) + "," + tbTime.Text.Substring(3, 5) + "," + tbTime.Text.Substring(6, 7));

            //HoursTextBox.Text = tbTime.Text.Substring(0, 2);
            //MinutesTextBox.Text = tbTime.Text.Substring(3, 2);
            //SecondsTextBox.Text = tbTime.Text.Substring(6, 2);

            //timeHours = Convert.ToInt32(tbTime.Text.Substring(0, 2));
            //timeMinutes = Convert.ToInt32(tbTime.Text.Substring(3, 2));
            //timeSeconds = Convert.ToInt32(tbTime.Text.Substring(6, 2));


            if(timeHours > 0 || timeMinutes > 0 || timeSeconds > 0)
            {
                updateCounter();
                if (timeHours > 0)
                {
                    if(timeMinutes == 0 && timeSeconds == 0)
                    {
                        timeMinutes = 59;
                        timeSeconds = 59;
                        timeHours--;
                    } else if(timeMinutes > 0 && timeSeconds == 0)
                    {
                        timeSeconds = 59;
                        timeMinutes--;
                    } else if(timeMinutes > 0 && timeSeconds > 0)
                    {
                        timeSeconds--;
                    } else if(timeMinutes == 0 && timeSeconds > 0)
                    {
                        timeSeconds--;
                    }
                }
                else if(timeMinutes > 0)
                {
                    if(timeSeconds == 0)
                    {
                        timeSeconds = 59;
                        timeMinutes--;
                    } else if(timeSeconds > 0)
                    {
                        timeSeconds--;
                    }
                }
                else if(timeSeconds > 0)
                {
                    timeSeconds--;
                }
                updateCounter();
            } else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show(TimerTextBox.Text + "is up!");
                Timer.Stop();
            }
        }


        #region Stopwatch

        //StopWatch
        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                clockTextBlock.Text = currentTime;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            dt.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
            }
            elapsedTimeItem.Items.Add(currentTime);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            //clockTextBlock.Text = "00:00:00";
            clockTextBlock.Text = "00:00:00";
        }

        private void Cearbtn_Click(object sender, RoutedEventArgs e)
        {
            elapsedTimeItem.Items.Clear();
        }

        #endregion

        #region CountDown Timer

        private void updateCounter()
        {
            string timeHoursString;
            string timeMinutesString;
            string timeSecondsString;

            if(timeHours < 10) {
                timeHoursString = "0" + timeHours.ToString();
            } else
            {
                timeHoursString = timeHours.ToString();
            }

            if(timeMinutes < 10)
            {
                timeMinutesString = "0" + timeMinutes.ToString();
            } else
            {
                timeMinutesString = timeMinutes.ToString();
            }

            if(timeSeconds < 10)
            {
                timeSecondsString = "0" + timeSeconds.ToString();
            } else
            {
                timeSecondsString = timeSeconds.ToString();
            }
            tbTimeTextBlock.Text = string.Format("{0}:{1}:{2}", timeHoursString, timeMinutesString, timeSecondsString);
        }

        private void TimerStartButton_Click(object sender, RoutedEventArgs e)
        {
            //tbTimeTextBlock.Text = string.Format("{0}:{1}:{2}", HoursTextBox.Text, MinutesTextBox.Text, SecondsTextBox.Text);
            //customTime = HoursTextBox.Text + MinutesTextBox.Text + SecondsTextBox.Text;
            //MessageBox.Show("Starting timer");
            Timer.Start();
        }


        private void TimerStopButton_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
        }

        private void TimerResetButton_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            HoursTextBox.Text = customTime.Substring(0, 2);
            MinutesTextBox.Text = customTime.Substring(2,2);
            SecondsTextBox.Text = customTime.Substring(4, 2);
            tbTimeTextBlock.Text = string.Format("{0}:{1}:{2}", HoursTextBox.Text, MinutesTextBox.Text, SecondsTextBox.Text);
        }

        private void TimerClearButton(object sender, RoutedEventArgs e)
        {
            Timer.Stop();

            timeHours = 0;
            timeMinutes = 0;
            timeSeconds = 0;

            HoursTextBox.Text = "00";
            MinutesTextBox.Text = "00";
            SecondsTextBox.Text = "00";
            tbTimeTextBlock.Text = string.Format("{0}:{1}:{2}", HoursTextBox.Text, MinutesTextBox.Text, SecondsTextBox.Text);
        }

        private void HoursUpButton_Click(object sender, RoutedEventArgs e)
        {
            timeHours += 1;
            if(timeHours < 10)
            {
                HoursTextBox.Text = "0" + timeHours.ToString();
                updateCounter();
            } else
            {
                HoursTextBox.Text = timeHours.ToString();
                updateCounter();
            }
        }

        private void HoursDownButton_Click(object sender, RoutedEventArgs e)
        {
            //Decrement only if timeHours is positive
            if(timeHours > 0)
            {
                //If timeHours is less than 10, add a 0 next to it.
                if (timeHours <= 10)
                {
                    timeHours -= 1;
                    HoursTextBox.Text = "0" + timeHours.ToString();
                    updateCounter();

                } else
                {
                    timeHours -= 1;
                    HoursTextBox.Text = timeHours.ToString();
                    updateCounter();
                    
                }
                
            } else
            {
                timeHours = 0;
            }
        }

        private void MinutesUpButton_Click(object sender, RoutedEventArgs e)
        {
            timeMinutes += 1;
            if(timeMinutes < 10)
            {
                MinutesTextBox.Text = "0" + timeMinutes.ToString();
                updateCounter();

            } else
            {
                MinutesTextBox.Text = timeMinutes.ToString();
                updateCounter();
            }
        }

        private void MinutesDownButton_Click(object sender, RoutedEventArgs e)
        {
            if (timeMinutes > 0)
            {
                if(timeMinutes <= 10)
                {
                    timeMinutes -= 1;
                    MinutesTextBox.Text = "0" + timeMinutes.ToString();
                    updateCounter();
                } else
                {
                    timeMinutes -= 1;
                    MinutesTextBox.Text = timeMinutes.ToString();
                    updateCounter();
                }
            }
            else
            {
                timeMinutes = 0;
            }
        }

        private void SecondsUpButton_Click(object sender, RoutedEventArgs e)
        {
            timeSeconds += 1;
            if(timeSeconds < 10)
            {
                SecondsTextBox.Text = "0" + timeSeconds.ToString();
                updateCounter();
            } else
            {
                SecondsTextBox.Text = timeSeconds.ToString();
                updateCounter();
            }
        }

        private void SecondsDownButton_Click(object sender, RoutedEventArgs e)
        {
            if (timeSeconds > 0)
            {
                if(timeSeconds <= 10)
                {
                    timeSeconds -= 1;
                    SecondsTextBox.Text = "0" + timeSeconds.ToString();
                    updateCounter();
                } else
                {
                    timeSeconds -= 1;
                    SecondsTextBox.Text = timeSeconds.ToString();
                    updateCounter();
                }
            }
            else
            {
                timeSeconds = 0;
            }
        }
        #endregion
    }
}
