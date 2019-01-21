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

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for Timers.xaml
    /// </summary>
    public partial class Timers : Page
    {
        //Stopwatch
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;

        //CountDown Timer
        DispatcherTimer timer;
        TimeSpan time;

        public Timers()
        {
            InitializeComponent();

            //Stopwatch
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);

            //CountDown Timer
            TimeSpan customTime = TimeSpan.Parse("00:45:00");
            time = customTime;
//            MessageBox.Show(tbTime.Text);

            //time = TimeSpan.FromSeconds(2); //TimeSpan.FromSeconds(10);
            //MessageBox.Show(time.ToString());
            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
              {
                  timer.Stop();
                  tbTime.Text = time.ToString("c");
                  if (time == TimeSpan.Zero)
                  {
                      MessageBox.Show(TimerTextBox.Text + "'s Timer is up!");
                      timer.Stop();
                  }
                  time = time.Add(TimeSpan.FromSeconds(-1));
              }, Application.Current.Dispatcher);
        }


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

        //Timer
        private void TimerStartButton_Click(object sender, RoutedEventArgs e)
        {
         //   customTime = TimeSpan.Parse(tbTime.Text);
            timer.Start();
        }

        private void TimerStopButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void TimerResetButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
