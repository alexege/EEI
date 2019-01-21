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

namespace CalendarUtility
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ShortcutsButton.Foreground = Brushes.Yellow;

            Main.Content = new Shortcuts();
            TimeLabel.Content = DateTime.Now.ToString();

            //DispatchTimer to keep time live/updated
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.TimeLabel.Content = DateTime.Now.ToString();
            }, this.Dispatcher);

            MonthLabel.Content = DateTime.Now.ToString("dddd - MMMM dd, yyyy");

            //Mouse Move
            //MouseDown += Window_MouseDown;

            // For this example, the data to be placed on the clipboard is a simple string.
            //string textData = "I want to put this string on the clipboard.";

            // After this call, the data (string) is placed on the clipboard and tagged with a data format of "Text".
            //Clipboard.SetData(DataFormats.Text, (Object)textData);


            //Check number of monitors attached to computer
            System.Management.ManagementObjectSearcher monitorObjectSearch = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
            int Counter = monitorObjectSearch.Get().Count;
            MessageBox.Show(Counter.ToString());
        }

        //Figure out how many screens are connected.
        public int getNumScreens()
        {
            double workSpaceLength = System.Windows.SystemParameters.VirtualScreenWidth;

            if(workSpaceLength > 1920.00)
            {
                MessageBox.Show("Multiple monitors detected!");
                return 1;
            } else if (workSpaceLength <= 1920)
            {
                MessageBox.Show("Only 1 monitor detected!");
                return 0;
            } else
            {
                return -1;
            }

        }

        public void resetTextColor()
        {
            string currentTextcolor = ShortcutsButton.Foreground.ToString();
            ShortcutsButton.Foreground = ShortcutsButton.Foreground;
            CalendarButton.Foreground = ShortcutsButton.Foreground;
            NotesButton.Foreground = ShortcutsButton.Foreground;
            ToDoListButton.Foreground = ShortcutsButton.Foreground;
            TimersButton.Foreground = ShortcutsButton.Foreground;
            EmailButton.Foreground = ShortcutsButton.Foreground;
        }

        #region HotkeyIntegration
        //Hotkey Integration
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 9000;

        //Modifiers:
        private const uint MOD_NONE = 0x0000; //(none)
        private const uint MOD_ALT = 0x0001; //ALT
        private const uint MOD_CONTROL = 0x0002; //CTRL
        private const uint MOD_SHIFT = 0x0004; //SHIFT
        private const uint MOD_WIN = 0x0008; //WINDOWS
        private const uint VK_CAPITAL = 0x14;   //CAPS LOCK:
        private const uint VK_Q = 0x51;   //Q Key:
        private const uint VK_C = 0x43;   //C Key:

        private IntPtr _windowHandle;
        private HwndSource _source;
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            _windowHandle = new WindowInteropHelper(this).Handle;
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);

            //RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_CONTROL, VK_CAPITAL); //CTRL + CAPS_LOCK
            //RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_CONTROL, VK_C); //CTRL + C
            RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_ALT, VK_Q); //CTRL + Q
        }

        bool toggle = true;
        private IntPtr HwndHook(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            const int WM_HOTKEY = 0x0312;
            switch (msg)
            {
                case WM_HOTKEY:
                    switch (wParam.ToInt32())
                    {
                        case HOTKEY_ID:
                            int vkey = (((int)lParam >> 16) & 0xFFFF);
                            //if (vkey == VK_CAPITAL)
                            if (vkey == VK_Q)
                            {
                                if (toggle == true)
                                {
                                    this.WindowState = WindowState.Minimized;
                                    toggle = false;
                                }
                                else
                                {
                                    //if(getNumScreens() == 0)
                                    //{

                                    //} else if(getNumScreens() == 1)
                                    //{

                                    //} else
                                    //{

                                    //}
                                    this.WindowState = WindowState.Normal;
                                    toggle = true;
                                }
                            }
                            //else if (vkey == VK_C) //Control + C Pressed
                            // {
                            //     MessageBox.Show("You pressed ctrl + c");
                            //string textData = "You pressed ctrl + c";
                            //Clipboard.SetData(DataFormats.Text, (Object)textData);
                            // }
                            handled = true;
                            break;
                    }
                    break;
            }
            return IntPtr.Zero;
        }

        protected override void OnClosed(EventArgs e)
        {
            _source.RemoveHook(HwndHook);
            UnregisterHotKey(_windowHandle, HOTKEY_ID);
            base.OnClosed(e);
        }
        #endregion //End Hotkey Integration

        private void ShortcutsButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Shortcuts();

            //Set all button Foregrounds back to default
            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
            //Change selected button Foreground to Yellow to show which page is selected
            ShortcutsButton.Foreground = Brushes.Yellow;
        }

        private void CalendarButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Calendar();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            CalendarButton.Foreground = Brushes.Yellow;
        }

        private void NotesButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Notes();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            NotesButton.Foreground = Brushes.Yellow;
        }

        private void ToDoListButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new ToDoList();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            ToDoListButton.Foreground = Brushes.Yellow;
        }

        //private void SoundboardButtonClick(object sender, RoutedEventArgs e)
        //{
        //    Properties.Settings.Default.Save();

        //    Main.Content = new ToDoList();
        //    //Main.Content = new Soundboard();

        //    ShortcutsButton.Foreground = MonthLabel.Foreground;
        //    CalendarButton.Foreground = MonthLabel.Foreground;
        //    NotesButton.Foreground = MonthLabel.Foreground;
        //    ToDoListButton.Foreground = MonthLabel.Foreground;
        //    TimersButton.Foreground = MonthLabel.Foreground;
        //    EmailButton.Foreground = MonthLabel.Foreground;
        //    CustomizeButton.Foreground = MonthLabel.Foreground;

        //    ToDoListButton.Foreground = Brushes.Yellow;
        //}

        private void TimersButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Timers();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            TimersButton.Foreground = Brushes.Yellow;
        }

        private void EmailButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Email();
            //Main.Content = new Tab6();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            EmailButton.Foreground = Brushes.Yellow;
        }

        private void CustomizeButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = new Customize();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            EmailButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;

            CustomizeButton.Foreground = Brushes.Yellow;
        }


        //Close all other windows on close
        private void Window_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }

        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Minimized;
            }
        }
    }
}
