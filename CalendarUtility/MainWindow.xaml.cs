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
        Shortcuts shortcutsPage = new Shortcuts();
        Calendar calendarPage = new Calendar();
        Notes notesPage = new Notes();
        ToDoList toDoListPage = new ToDoList();
        Timers timerPage = new Timers();
        ClipBoard clipBoardPage = new ClipBoard();
        Customize customizePage = new Customize();

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
        }

        public void resetTextColor()
        {
            string currentTextcolor = ShortcutsButton.Foreground.ToString();
            ShortcutsButton.Foreground = ShortcutsButton.Foreground;
            CalendarButton.Foreground = ShortcutsButton.Foreground;
            NotesButton.Foreground = ShortcutsButton.Foreground;
            ToDoListButton.Foreground = ShortcutsButton.Foreground;
            TimersButton.Foreground = ShortcutsButton.Foreground;
        }

        #region HotkeyIntegration
        //Hotkey Integration
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private const int HOTKEY_ID = 9000;

        //Modifiers:
        private const uint MOD_NONE =   0x0000; //(none)
        private const uint MOD_ALT =    0x0001; //ALT
        private const uint MOD_CONTROL =0x0002; //CTRL
        private const uint MOD_SHIFT =  0x0004; //SHIFT
        private const uint MOD_WIN =    0x0008; //WINDOWS
        private const uint VK_CAPITAL = 0x14;   //CAPS LOCK:
        private const uint VK_Q =       0x51;   //Q Key:
        private const uint VK_C =       0x43;   //C Key:
        private const uint VK_B =       0X42;   //B Key:

        private IntPtr _windowHandle;
        private HwndSource _source;
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);

            _windowHandle = new WindowInteropHelper(this).Handle;
            _source = HwndSource.FromHwnd(_windowHandle);
            _source.AddHook(HwndHook);

            //RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_CONTROL, VK_CAPITAL); //CTRL + CAPS_LOCK
            RegisterHotKey(_windowHandle, HOTKEY_ID, MOD_CONTROL, VK_B); //CTRL + C
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
                            } else if (vkey == VK_B)
                            {

                                //MessageBox.Show("ctrl + C Pressed!");
                                string copyData = Clipboard.GetText();
                                Clipboard.SetData(DataFormats.Text, (object)copyData);

                                clipBoardPage.ClipBoardListBox.Items.Add(copyData);
                                
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
            //Main.Content = new Shortcuts();
            Main.Content = shortcutsPage;

            //Set all button Foregrounds back to default
            ShortcutsButton.Foreground = Brushes.Yellow;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void CalendarButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            //Main.Content = new Calendar();
            Main.Content = calendarPage;

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = Brushes.Yellow;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void NotesButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            //Main.Content = new Notes();
            Main.Content = notesPage;

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = Brushes.Yellow;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void ToDoListButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            //Main.Content = new ToDoList();
            Main.Content = toDoListPage;

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = Brushes.Yellow;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void TimersButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = timerPage;

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = Brushes.Yellow;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void ClipBoardButtonClick(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Save();
            Main.Content = clipBoardPage;

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = Brushes.Yellow;
            CustomizeButton.Foreground = MonthLabel.Foreground;
        }

        private void CustomizeButtonClick(object sender, RoutedEventArgs e)
        {

            Properties.Settings.Default.Save();
            Main.Content = customizePage;
            //Main.Content = new Customize();

            ShortcutsButton.Foreground = MonthLabel.Foreground;
            CalendarButton.Foreground = MonthLabel.Foreground;
            NotesButton.Foreground = MonthLabel.Foreground;
            ToDoListButton.Foreground = MonthLabel.Foreground;
            TimersButton.Foreground = MonthLabel.Foreground;
            ClipBoardButton.Foreground = MonthLabel.Foreground;
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

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
