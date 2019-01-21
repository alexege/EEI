using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace EgeEfficiencyInterface
{
    public partial class Form1 : Form
    {
        int hours, minutes, seconds, glblHours, glblMinutes, glblSeconds;
/*        string pictureBox1Image, pictureBox2Image, pictureBox3Image,
               pictureBox4Image, pictureBox5Image, pictureBox6Image,
               pictureBox7Image, pictureBox8Image, pictureBox9Image,
               pictureBox10Image, pictureBox11Image, pictureBox12Image,
               pictureBox13Image, pictureBox14Image, pictureBox15Image,
               pictureBox16Image, pictureBox17Image, pictureBox18Image, 
               pictureBox19Image, pictureBox20Image, pictureBox21Image,
               pictureBox22Image, pictureBox23Image, pictureBox24Image,
               pictureBox25Image, pictureBox26Image, pictureBox27Image,
               pictureBox28Image, pictureBox29Image, pictureBox30Image;
*/
        public Form1()
        {
            InitializeComponent();

            //Make form background transparent
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.Gray;

            //Display Current time on form load
            TimeLabel.Text = DateTime.Now.ToString();

        }

private void Form1_Load(object sender, EventArgs e) //When form loads
        {
            /*         
                      //FontColor
                      DateLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      TimeLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      notepadTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      SundayTextbox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      MondayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      TuesdayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      WednesdayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      ThursdayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      FridayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      SaturdayTextBox.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      GoogleLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      groupBox1.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      groupBox2.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label1.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label11.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label3.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label4.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label5.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label6.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label7.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label9.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label10.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label14.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label15.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label16.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      label17.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      HoursLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      MinutesLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      SecondsLabel.ForeColor = System.Drawing.Color.FromName(Properties.Settings.Default.FontColor);
                      //BackgroundColor
                      notepadTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      DateLabel.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      TimeLabel.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      tabPage1.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      tabPage2.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      Calendar.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      panel2.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      panel34.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      SundayTextbox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      MondayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      TuesdayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      WednesdayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      ThursdayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      FridayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);
                      SaturdayTextBox.BackColor = System.Drawing.Color.FromName(Properties.Settings.Default.BackgroundColor);

          */


            var img1 = File.ReadLines(Application.StartupPath + "\\image1.txt").ElementAt(0);
            pictureBox1.Image = Image.FromFile(img1);


            //Previous Attempt
            /*            pictureBox1.Image = Image.FromFile(Properties.Settings.Default.box1Image);
                        pictureBox2.Image = Image.FromFile(Properties.Settings.Default.box2Image);
                        pictureBox3.Image = Image.FromFile(Properties.Settings.Default.box3Image);
                        pictureBox4.Image = Image.FromFile(Properties.Settings.Default.box4Image);
                        pictureBox5.Image = Image.FromFile(Properties.Settings.Default.box5Image);
                        pictureBox6.Image = Image.FromFile(Properties.Settings.Default.box6Image);
                        pictureBox7.Image = Image.FromFile(Properties.Settings.Default.box7Image);
                        pictureBox8.Image = Image.FromFile(Properties.Settings.Default.box8Image);
                        pictureBox9.Image = Image.FromFile(Properties.Settings.Default.box9Image);
                        pictureBox10.Image = Image.FromFile(Properties.Settings.Default.box10Image);
                        pictureBox11.Image = Image.FromFile(Properties.Settings.Default.box11Image);
                        pictureBox12.Image = Image.FromFile(Properties.Settings.Default.box12Image);
                        pictureBox13.Image = Image.FromFile(Properties.Settings.Default.box13Image);
                        pictureBox14.Image = Image.FromFile(Properties.Settings.Default.box14Image);
                        pictureBox15.Image = Image.FromFile(Properties.Settings.Default.box15Image);
                        pictureBox16.Image = Image.FromFile(Properties.Settings.Default.box16Image);
                        pictureBox17.Image = Image.FromFile(Properties.Settings.Default.box17Image);
                        pictureBox18.Image = Image.FromFile(Properties.Settings.Default.box18Image);
                        pictureBox19.Image = Image.FromFile(Properties.Settings.Default.box19Image);
                        pictureBox20.Image = Image.FromFile(Properties.Settings.Default.box20Image);
                        pictureBox21.Image = Image.FromFile(Properties.Settings.Default.box21Image);
                        pictureBox22.Image = Image.FromFile(Properties.Settings.Default.box22Image);
                        pictureBox23.Image = Image.FromFile(Properties.Settings.Default.box23Image);
                        pictureBox24.Image = Image.FromFile(Properties.Settings.Default.box24Image);
                        pictureBox25.Image = Image.FromFile(Properties.Settings.Default.box25Image);
                        pictureBox26.Image = Image.FromFile(Properties.Settings.Default.box26Image);
                        pictureBox27.Image = Image.FromFile(Properties.Settings.Default.box27Image);
                        pictureBox28.Image = Image.FromFile(Properties.Settings.Default.box28Image);
                        pictureBox29.Image = Image.FromFile(Properties.Settings.Default.box29Image);
                        pictureBox30.Image = Image.FromFile(Properties.Settings.Default.box30Image);    
            */

            /*      //Grab filename's from directory for image icons
                  string path = (@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\ShortcutPictures\Websites\");
                  string[] filePaths = Directory.GetFiles(path, "*.png");
                  foreach (string file in filePaths)
                  {
                      comboBox2.Items.Add(Path.GetFileName(file));
                      comboBox3.Items.Add(Path.GetFileName(file));
                  }

                  string path2 = (@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\ShortcutPictures\Programs\");
                  string[] filePaths2 = Directory.GetFiles(path2, "*.png");
                  foreach (string file in filePaths2)
                  {
                      comboBox2.Items.Add(Path.GetFileName(file));
                      comboBox3.Items.Add(Path.GetFileName(file));
                  }

                  string path3 = (@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\ShortcutPictures\Shortcuts\");
                  string[] filePaths3 = Directory.GetFiles(path3, "*.png");
                  foreach (string file in filePaths3)
                  {
                      comboBox2.Items.Add(Path.GetFileName(file));
                      comboBox3.Items.Add(Path.GetFileName(file));
                  }
      */
            // string[] fileArray = Directory.GetFiles(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\ShortcutPictures\Websites\");
            // comboBox2.Items.AddRange(fileArray);
            //            string[] filePaths = Directory.GetFiles(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\ShortcutPictures\Websites\", "*.png",SearchOption.TopDirectoryOnly);
            //           comboBox2.Items.Add(filePaths);

            LoadRichTextBoxes();

            //Timer 1 - Current Time
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();

            //Timer 2 -  Stopwatch Timer
            timer2.Interval = 100;

            //Timer 3 - Countdown Timer
            timer3.Interval = 1000;

            //HotKey Registration - Source: https://www.youtube.com/watch?v=FL_y8GT1L7E and https://www.fluxbytes.com/csharp/how-to-register-a-global-hotkey-for-your-application-in-c/
            IntPtr thisWindow = FindWindow(null, "Form1");
            hotkey = new Hotkey(thisWindow);
            hotkey.RegisterHotKeys();
        }

        //Clock Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            string CurrentDay = String.Format("{0:dddd}", DateTime.Now);
            string CurrentDay2 = String.Format("{0:dd}", DateTime.Now);
            string CurrentMonth = String.Format("{0:MMMM}", DateTime.Now);
            string CurrentYear = String.Format("{0:yyyy}", DateTime.Now);
            string myTime = (CurrentDay + ", " + CurrentMonth + " " + CurrentDay2 + ", " + CurrentYear + " " + DateTime.Now);

            this.DateLabel.Text = myTime.ToString();
            this.TimeLabel.Text = DateTime.Now.ToString();

            //Read time
            DateTime time = DateTime.Now;

            //Get current ms offset from prefered readout position
            int diffms = time.Millisecond - 100;

            //Set a new timer interval with half the error applied
            timer1.Interval = 1000 - diffms / 2;
        }

        private void SaveRichTextBoxes()
        {
            notepadTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Notepad.txt", RichTextBoxStreamType.PlainText);
            SundayTextbox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Sunday.txt", RichTextBoxStreamType.PlainText);
            MondayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Monday.txt", RichTextBoxStreamType.PlainText);
            TuesdayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Tuesday.txt", RichTextBoxStreamType.PlainText);
            WednesdayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Wednesday.txt", RichTextBoxStreamType.PlainText);
            ThursdayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Thursday.txt", RichTextBoxStreamType.PlainText);
            FridayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Friday.txt", RichTextBoxStreamType.PlainText);
            SaturdayTextBox.SaveFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Saturday.txt", RichTextBoxStreamType.PlainText);
        }

        private void LoadRichTextBoxes()
        {
            notepadTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Notepad.txt", RichTextBoxStreamType.PlainText);
            SundayTextbox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Sunday.txt", RichTextBoxStreamType.PlainText);
            MondayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Monday.txt", RichTextBoxStreamType.PlainText);
            TuesdayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Tuesday.txt", RichTextBoxStreamType.PlainText);
            WednesdayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Wednesday.txt", RichTextBoxStreamType.PlainText);
            ThursdayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Thursday.txt", RichTextBoxStreamType.PlainText);
            FridayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Friday.txt", RichTextBoxStreamType.PlainText);
            SaturdayTextBox.LoadFile(@"D:\Documents\Visual Studio 2015\Projects\EgeEfficiencyInterface\TextBoxes\Saturday.txt", RichTextBoxStreamType.PlainText);
        }

        //Which monitor to open form on (based on cursor position)
        private void openOnMonitor(int openOnMonitor)
        {
            Screen[] screen;
            screen = Screen.AllScreens;
            if(openOnMonitor >= screen.Length)
            {
                openOnMonitor = 0;
            }

            this.StartPosition = FormStartPosition.Manual;  //Need to set start position to manual
            this.Location = new Point(screen[openOnMonitor].Bounds.Left, screen[openOnMonitor].Bounds.Top);
            this.WindowState = FormWindowState.Normal;  //Opens form to regular state (not maximized/minimized)

        }

        #region Shortcut Buttons region

        //Notes Button
        private void NotesButton_Click(object sender, EventArgs e)
        {
            notepadTextBox.Visible = !notepadTextBox.Visible;
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            Calendar.Visible = !Calendar.Visible;
        }

        private void TimersButton_Click(object sender, EventArgs e)
        {
            TimerControl.Visible = !TimerControl.Visible;
            button94.Visible = !button94.Visible;
        }

        private void Countdown_Start_Click(object sender, EventArgs e)
        {
            if (HoursTextbox.Text == "")
            {
                HoursTextbox.Text = "0";
            }
            if (MinutesTextbox.Text == "")
            {
                MinutesTextbox.Text = "0";
            }
            if (SecondsTextbox.Text == "")
            {
                SecondsTextbox.Text = "0";
            }
            hours = Convert.ToInt32(HoursTextbox.Text);
            minutes = Convert.ToInt32(MinutesTextbox.Text);
            seconds = Convert.ToInt32(SecondsTextbox.Text);
            timer3.Enabled = true;

            glblHours = hours;
            glblMinutes = minutes;
            glblSeconds = seconds;
        }

        private void Countdown_Stop_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void Countdown_Reset_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;

            string hh = Convert.ToString(glblHours);
            string mm = Convert.ToString(glblMinutes);
            string ss = Convert.ToString(glblSeconds);

            HoursLabel.Text = hh;
            MinutesLabel.Text = mm;
            SecondsLabel.Text = ss;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ms = ms + 1;
            if (ms == 10)
            {
                ms = 0;
                s = s + 1;
                label3.Text = s.ToString("D2");
                if (s == 59)
                {
                    s = 0;
                    m = m + 1;
                    label4.Text = m.ToString("D2");
                    if (m == 59)
                    {
                        m = 0;
                        h = h + 1;
                        label5.Text = h.ToString("D2");
                    }
                }
            }

            label2.Text = ms.ToString("D2");
        }

        int h, m, s, ms = 0;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRichTextBoxes();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            seconds = seconds - 1;
            if (seconds == -1)
            {
                minutes = minutes - 1;
                seconds = 59;
            }
            if (minutes == -1)
            {
                hours = hours - 1;
                minutes = 59;
            }

            if (hours == 0 && minutes == 0 && seconds == 0) // && ms == 0)
            {
                timer3.Enabled = false;
                MessageBox.Show(string.Format("{0} Timer is up!", TimerName.Text), "Timer");
            }

            string hh = Convert.ToString(hours);
            string mm = Convert.ToString(minutes);
            string ss = Convert.ToString(seconds);

            HoursLabel.Text = hh;
            MinutesLabel.Text = mm;
            SecondsLabel.Text = ss;
        }

        private void SearchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void SearchBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void GoogleSearchButton_Click(object sender, EventArgs e)
        {
            GoogleSearch(SearchBar.Text.ToString());
        }

        private void SearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoogleSearch(SearchBar.Text);
                SearchBar.Text = "";
            }
        }

        public static void GoogleSearch(string search)
        {
            Process.Start("http://google.com/search?q=" + search);
        }

        private void Stopwatch_Start_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void Options_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        #region Shortcut Box Actions

        //Box 1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(File.ReadAllLines(Application.StartupPath + "\\Action.txt").ElementAt(0));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var img1 = File.ReadLines(Application.StartupPath + "\\image2.txt").ElementAt(0);
            pictureBox1.Image = Image.FromFile(img1);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            var img1 = File.ReadLines(Application.StartupPath + "\\image1.txt").ElementAt(0);
            pictureBox1.Image = Image.FromFile(img1);
        }
/*        //Box2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box2Action);
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Image.FromFile(Properties.Settings.Default.box2Image2);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(Properties.Settings.Default.box2Image);
        }
        //Box3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box3Action);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Image.FromFile(Properties.Settings.Default.box3Image2);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(Properties.Settings.Default.box3Image);
        }
        //Box4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box4Action);
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Image.FromFile(Properties.Settings.Default.box4Image2);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(Properties.Settings.Default.box4Image);
        }
        //Box5
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box5Action);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile(Properties.Settings.Default.box5Image2);
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(Properties.Settings.Default.box5Image);
        }
        //Box6
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box6Action);
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Image.FromFile(Properties.Settings.Default.box6Image2);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(Properties.Settings.Default.box6Image);
        }
        //Box7
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box7Action);
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Image.FromFile(Properties.Settings.Default.box7Image2);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(Properties.Settings.Default.box7Image);
        }
        //Box8
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box8Action);
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Image = Image.FromFile(Properties.Settings.Default.box8Image2);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(Properties.Settings.Default.box8Image);
        }
        //Box9
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box9Action);
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox9.Image = Image.FromFile(Properties.Settings.Default.box9Image2);
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(Properties.Settings.Default.box9Image);
        }
        //Box10
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box10Action);
        }

        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.Image = Image.FromFile(Properties.Settings.Default.box10Image2);
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.Image = Image.FromFile(Properties.Settings.Default.box10Image);
        }
        //Box11
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box11Action);
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Image = Image.FromFile(Properties.Settings.Default.box11Image2);
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.Image = Image.FromFile(Properties.Settings.Default.box11Image);
        }
        //Box12
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box12Action);
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Image = Image.FromFile(Properties.Settings.Default.box12Image2);
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            pictureBox12.Image = Image.FromFile(Properties.Settings.Default.box12Image);
        }
        //Box13
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box13Action);
        }

        private void pictureBox13_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox13.Image = Image.FromFile(Properties.Settings.Default.box13Image2);
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            pictureBox13.Image = Image.FromFile(Properties.Settings.Default.box13Image);
        }
        //Box14
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box14Action);
        }

        private void pictureBox14_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox14.Image = Image.FromFile(Properties.Settings.Default.box14Image2);
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox14.Image = Image.FromFile(Properties.Settings.Default.box14Image);
        }
        //Box15
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box15Action);
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Image = Image.FromFile(Properties.Settings.Default.box15Image2);
        }

        private void pictureBox15_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Image = Image.FromFile(Properties.Settings.Default.box15Image);
        }
        //Box16
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box16Action);
        }

        private void pictureBox16_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox16.Image = Image.FromFile(Properties.Settings.Default.box16Image2);
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox16.Image = Image.FromFile(Properties.Settings.Default.box16Image);
        }
        //Box17
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box17Action);
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Image = Image.FromFile(Properties.Settings.Default.box17Image2);
        }

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Image = Image.FromFile(Properties.Settings.Default.box17Image);
        }
        //Box18
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box18Action);
        }

        private void pictureBox18_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox18.Image = Image.FromFile(Properties.Settings.Default.box18Image2);
        }

        private void pictureBox18_MouseLeave(object sender, EventArgs e)
        {
            pictureBox18.Image = Image.FromFile(Properties.Settings.Default.box18Image);
        }
        //Box19
        private void pictureBox19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box19Action);
        }

        private void pictureBox19_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox19.Image = Image.FromFile(Properties.Settings.Default.box19Image2);
        }

        private void pictureBox19_MouseLeave(object sender, EventArgs e)
        {
            pictureBox19.Image = Image.FromFile(Properties.Settings.Default.box19Image);
        }
        //Box20
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box20Action);
        }

        private void pictureBox20_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox20.Image = Image.FromFile(Properties.Settings.Default.box20Image2);
        }

        private void pictureBox20_MouseLeave(object sender, EventArgs e)
        {
            pictureBox20.Image = Image.FromFile(Properties.Settings.Default.box20Image);
        }
        //Box21
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box21Action);
        }

        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.Image = Image.FromFile(Properties.Settings.Default.box21Image2);
        }

        private void pictureBox21_MouseLeave(object sender, EventArgs e)
        {
            pictureBox21.Image = Image.FromFile(Properties.Settings.Default.box21Image);
        }
        //Box22
        private void pictureBox22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box22Action);
        }

        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Image = Image.FromFile(Properties.Settings.Default.box22Image2);
        }

        private void pictureBox22_MouseLeave(object sender, EventArgs e)
        {
            pictureBox22.Image = Image.FromFile(Properties.Settings.Default.box22Image);
        }
        //Box23
        private void pictureBox23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box23Action);
        }

        private void pictureBox23_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox23.Image = Image.FromFile(Properties.Settings.Default.box23Image2);
        }

        private void pictureBox23_MouseLeave(object sender, EventArgs e)
        {
            pictureBox23.Image = Image.FromFile(Properties.Settings.Default.box23Image);
        }
        //Box24
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box24Action);
        }

        private void pictureBox24_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox24.Image = Image.FromFile(Properties.Settings.Default.box24Image2);
        }

        private void pictureBox24_MouseLeave(object sender, EventArgs e)
        {
            pictureBox24.Image = Image.FromFile(Properties.Settings.Default.box24Image);
        }
        //Box25
        private void pictureBox25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box25Action);
        }

        private void pictureBox25_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox25.Image = Image.FromFile(Properties.Settings.Default.box25Image2);
        }

        private void pictureBox25_MouseLeave(object sender, EventArgs e)
        {
            pictureBox25.Image = Image.FromFile(Properties.Settings.Default.box25Image);
        }
        //Box26
        private void pictureBox26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box26Action);
        }

        private void pictureBox26_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox26.Image = Image.FromFile(Properties.Settings.Default.box26Image2);
        }

        private void pictureBox26_MouseLeave(object sender, EventArgs e)
        {
            pictureBox26.Image = Image.FromFile(Properties.Settings.Default.box26Image);
        }
        //Box27
        private void pictureBox27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box27Action);
        }

        private void pictureBox27_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox27.Image = Image.FromFile(Properties.Settings.Default.box27Image2);
        }

        private void pictureBox27_MouseLeave(object sender, EventArgs e)
        {
            pictureBox27.Image = Image.FromFile(Properties.Settings.Default.box27Image);
        }
        //Box28
        private void pictureBox28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box28Action);
        }

        private void pictureBox28_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox28.Image = Image.FromFile(Properties.Settings.Default.box28Image2);
        }

        private void pictureBox28_MouseLeave(object sender, EventArgs e)
        {
            pictureBox28.Image = Image.FromFile(Properties.Settings.Default.box28Image);
        }
        //Box29
        private void pictureBox29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box29Action);
        }

        private void pictureBox29_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox29.Image = Image.FromFile(Properties.Settings.Default.box29Image2);
        }

        private void pictureBox29_MouseLeave(object sender, EventArgs e)
        {
            pictureBox29.Image = Image.FromFile(Properties.Settings.Default.box29Image);
        }
        //Box30
        private void pictureBox30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.box30Action);
        }

        private void pictureBox30_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox30.Image = Image.FromFile(Properties.Settings.Default.box30Image2);
        }

        private void pictureBox30_MouseLeave(object sender, EventArgs e)
        {
            pictureBox30.Image = Image.FromFile(Properties.Settings.Default.box30Image);
        }
*/
        #endregion

        #region Edit Shortcut Boxes

        OpenFileDialog ofd = new OpenFileDialog();
        //1
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Might want to add filter to only find .exe files
                    string action = ofd.FileName;
                    var lines = File.ReadAllLines(Application.StartupPath + "\\Action.txt");
                    lines[0] = action;
                    File.WriteAllLines(Application.StartupPath + "\\Action.txt", lines);
                }
            }
            else
            {
                string action = comboBox1.Text;
                var lines = File.ReadAllLines(Application.StartupPath + "\\Action.txt");
                lines[0] = action;
                File.WriteAllLines(Application.StartupPath + "\\Action.txt", lines);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                string loc = ofd.FileName;
                var lines = File.ReadAllLines(Application.StartupPath + "\\image1.txt");
                lines[0] = loc;
                File.WriteAllLines(Application.StartupPath + "\\image1.txt", lines);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                string loc = ofd.FileName;
                var lines = File.ReadAllLines(Application.StartupPath + "\\image2.txt");
                lines[0] = loc;
                File.WriteAllLines(Application.StartupPath + "\\image2.txt", lines);
            }
        }
        //2
        private void button4_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box2Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box2Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box2Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box2Action = comboBox2.Text;
                Properties.Settings.Default.Save();
            }
        }

        //3
        private void button7_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box3Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box3Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box3Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box3Action = comboBox3.Text;
                Properties.Settings.Default.Save();
            }
        }
        //4
        private void button10_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box4Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box4Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox4.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box4Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box4Action = comboBox4.Text;
                Properties.Settings.Default.Save();
            }
        }
        //5
        private void button13_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box5Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box5Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox5.Text))
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box5Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box5Action = comboBox5.Text;
                Properties.Settings.Default.Save();
            }
        }
        //6
        private void button16_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box6Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box6Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox6.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box6Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box6Action = comboBox6.Text;
                Properties.Settings.Default.Save();
            }
        }
        //7
        private void button19_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box7Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box7Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox7.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box7Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box7Action = comboBox7.Text;
                Properties.Settings.Default.Save();
            }
        }
        //8
        private void button22_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box8Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box8Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox8.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box8Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box8Action = comboBox8.Text;
                Properties.Settings.Default.Save();
            }
        }
        //9
        private void button25_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box9Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box9Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox9.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box9Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box9Action = comboBox9.Text;
                Properties.Settings.Default.Save();
            }
        }
        //10
        private void button28_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box10Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box10Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox10.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box10Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box10Action = comboBox10.Text;
                Properties.Settings.Default.Save();
            }
        }
        //11
        private void button31_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box11Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box11Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox11.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box11Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box11Action = comboBox11.Text;
                Properties.Settings.Default.Save();
            }
        }
        //12
        private void button34_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box12Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box12Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox12.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box12Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box12Action = comboBox12.Text;
                Properties.Settings.Default.Save();
            }
        }
        //13
        private void button37_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box13Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box13Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox13.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box13Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box13Action = comboBox13.Text;
                Properties.Settings.Default.Save();
            }
        }
        //14
        private void button40_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box14Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box14Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox14.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box14Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box14Action = comboBox14.Text;
                Properties.Settings.Default.Save();
            }
        }
        //15
        private void button43_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box15Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box15Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox15.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box15Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box15Action = comboBox15.Text;
                Properties.Settings.Default.Save();
            }
        }
        //16
        private void button46_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box16Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box16Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox16.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box16Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box16Action = comboBox16.Text;
                Properties.Settings.Default.Save();
            }
        }
        //17
        private void button49_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box17Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box17Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox17.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box17Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box17Action = comboBox17.Text;
                Properties.Settings.Default.Save();
            }
        }
        //18
        private void button52_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box18Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box18Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox18.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box18Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box18Action = comboBox18.Text;
                Properties.Settings.Default.Save();
            }
        }
        //19
        private void button55_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box19Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box19Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox19.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box19Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box19Action = comboBox19.Text;
                Properties.Settings.Default.Save();
            }
        }
        //20
        private void button58_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box20Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box20Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox20.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box20Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box20Action = comboBox20.Text;
                Properties.Settings.Default.Save();
            }
        }
        //21
        private void button61_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box21Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box21Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox21.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box21Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box21Action = comboBox21.Text;
                Properties.Settings.Default.Save();
            }
        }
        //22
        private void button64_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box22Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box22Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox22.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box22Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box22Action = comboBox22.Text;
                Properties.Settings.Default.Save();
            }
        }
        //23
        private void button67_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box23Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box23Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox23.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box23Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box23Action = comboBox23.Text;
                Properties.Settings.Default.Save();
            }
        }
        //24
        private void button73_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box24Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box24Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox24.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box24Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box24Action = comboBox24.Text;
                Properties.Settings.Default.Save();
            }
        }
        //25
        private void button76_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box25Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box25Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox25.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box25Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box25Action = comboBox25.Text;
                Properties.Settings.Default.Save();
            }
        }
        //26
        private void button79_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box26Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box26Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox26.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box26Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box26Action = comboBox26.Text;
                Properties.Settings.Default.Save();
            }
        }
        //27
        private void button82_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box27Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box27Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox27.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box27Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box27Action = comboBox27.Text;
                Properties.Settings.Default.Save();
            }
        }
        //28
        private void button85_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box28Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box28Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox28.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box28Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box28Action = comboBox28.Text;
                Properties.Settings.Default.Save();
            }
        }
        //29
        private void button88_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box29Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box29Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox29.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box29Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box29Action = comboBox29.Text;
                Properties.Settings.Default.Save();
            }
        }
        //30
        private void button91_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box30Image2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.box30Image = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox30.Text))
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.box30Action = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Properties.Settings.Default.box30Action = comboBox30.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            panel34.Visible = !panel34.Visible;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if(comboBox31.Text == "Blue")
            {
                DateLabel.ForeColor = Color.Blue; 
                TimeLabel.ForeColor = Color.Blue;
                notepadTextBox.ForeColor = Color.Blue;
                SundayTextbox.ForeColor = Color.Blue;
                MondayTextBox.ForeColor = Color.Blue;
                TuesdayTextBox.ForeColor = Color.Blue;
                WednesdayTextBox.ForeColor = Color.Blue;
                ThursdayTextBox.ForeColor = Color.Blue;
                FridayTextBox.ForeColor = Color.Blue;
                SaturdayTextBox.ForeColor = Color.Blue;
                GoogleLabel.ForeColor = Color.Blue;
                groupBox1.ForeColor = Color.Blue;
                groupBox2.ForeColor = Color.Blue;
                label1.ForeColor = Color.Blue;
                label11.ForeColor = Color.Blue;
                label3.ForeColor = Color.Blue;
                label4.ForeColor = Color.Blue;
                label5.ForeColor = Color.Blue;
                label6.ForeColor = Color.Blue;
                label7.ForeColor = Color.Blue;
                label9.ForeColor = Color.Blue;
                label10.ForeColor = Color.Blue;
                label14.ForeColor = Color.Blue;
                label15.ForeColor = Color.Blue;
                label16.ForeColor = Color.Blue;
                label17.ForeColor = Color.Blue;
                HoursLabel.ForeColor = Color.Blue;
                MinutesLabel.ForeColor = Color.Blue;
                SecondsLabel.ForeColor = Color.Blue;
            }else if (comboBox31.Text == "Black")
            {
                DateLabel.ForeColor = Color.Black;
                TimeLabel.ForeColor = Color.Black;
                notepadTextBox.ForeColor = Color.Black;
                SundayTextbox.ForeColor = Color.Black;
                MondayTextBox.ForeColor = Color.Black;
                TuesdayTextBox.ForeColor = Color.Black;
                WednesdayTextBox.ForeColor = Color.Black;
                ThursdayTextBox.ForeColor = Color.Black;
                FridayTextBox.ForeColor = Color.Black;
                SaturdayTextBox.ForeColor = Color.Black;
                GoogleLabel.ForeColor = Color.Black;
                groupBox1.ForeColor = Color.Black;
                groupBox2.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;
                label11.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label7.ForeColor = Color.Black;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label14.ForeColor = Color.Black;
                label15.ForeColor = Color.Black;
                label16.ForeColor = Color.Black;
                label17.ForeColor = Color.Black;
                HoursLabel.ForeColor = Color.Black;
                MinutesLabel.ForeColor = Color.Black;
                SecondsLabel.ForeColor = Color.Black;
            }
            else if (comboBox31.Text == "Green")
            {
                DateLabel.ForeColor = Color.Green;
                TimeLabel.ForeColor = Color.Green;
                notepadTextBox.ForeColor = Color.Green;
                SundayTextbox.ForeColor = Color.Green;
                MondayTextBox.ForeColor = Color.Green;
                TuesdayTextBox.ForeColor = Color.Green;
                WednesdayTextBox.ForeColor = Color.Green;
                ThursdayTextBox.ForeColor = Color.Green;
                FridayTextBox.ForeColor = Color.Green;
                SaturdayTextBox.ForeColor = Color.Green;
                GoogleLabel.ForeColor = Color.Green;
                groupBox1.ForeColor = Color.Green;
                groupBox2.ForeColor = Color.Green;
                label1.ForeColor = Color.Green;
                label11.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Green;
                label5.ForeColor = Color.Green;
                label6.ForeColor = Color.Green;
                label7.ForeColor = Color.Green;
                label9.ForeColor = Color.Green;
                label10.ForeColor = Color.Green;
                label14.ForeColor = Color.Green;
                label15.ForeColor = Color.Green;
                label16.ForeColor = Color.Green;
                label17.ForeColor = Color.Green;
                HoursLabel.ForeColor = Color.Green;
                MinutesLabel.ForeColor = Color.Green;
                SecondsLabel.ForeColor = Color.Green;
            }
            else if (comboBox31.Text == "Red")
            {
                DateLabel.ForeColor = Color.Red;
                TimeLabel.ForeColor = Color.Red;
                notepadTextBox.ForeColor = Color.Red;
                SundayTextbox.ForeColor = Color.Red;
                MondayTextBox.ForeColor = Color.Red;
                TuesdayTextBox.ForeColor = Color.Red;
                WednesdayTextBox.ForeColor = Color.Red;
                ThursdayTextBox.ForeColor = Color.Red;
                FridayTextBox.ForeColor = Color.Red;
                SaturdayTextBox.ForeColor = Color.Red;
                GoogleLabel.ForeColor = Color.Red;
                groupBox1.ForeColor = Color.Red;
                groupBox2.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label11.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
                label6.ForeColor = Color.Red;
                label7.ForeColor = Color.Red;
                label9.ForeColor = Color.Red;
                label10.ForeColor = Color.Red;
                label14.ForeColor = Color.Red;
                label15.ForeColor = Color.Red;
                label16.ForeColor = Color.Red;
                label17.ForeColor = Color.Red;
                HoursLabel.ForeColor = Color.Red;
                MinutesLabel.ForeColor = Color.Red;
                SecondsLabel.ForeColor = Color.Red;
            }
            else if (comboBox31.Text == "Orange")
            {
                DateLabel.ForeColor = Color.Orange;
                TimeLabel.ForeColor = Color.Orange;
                notepadTextBox.ForeColor = Color.Orange;
                SundayTextbox.ForeColor = Color.Orange;
                MondayTextBox.ForeColor = Color.Orange;
                TuesdayTextBox.ForeColor = Color.Orange;
                WednesdayTextBox.ForeColor = Color.Orange;
                ThursdayTextBox.ForeColor = Color.Orange;
                FridayTextBox.ForeColor = Color.Orange;
                SaturdayTextBox.ForeColor = Color.Orange;
                GoogleLabel.ForeColor = Color.Orange;
                groupBox1.ForeColor = Color.Orange;
                groupBox2.ForeColor = Color.Orange;
                label1.ForeColor = Color.Orange;
                label11.ForeColor = Color.Orange;
                label3.ForeColor = Color.Orange;
                label4.ForeColor = Color.Orange;
                label5.ForeColor = Color.Orange;
                label6.ForeColor = Color.Orange;
                label7.ForeColor = Color.Orange;
                label9.ForeColor = Color.Orange;
                label10.ForeColor = Color.Orange;
                label14.ForeColor = Color.Orange;
                label15.ForeColor = Color.Orange;
                label16.ForeColor = Color.Orange;
                label17.ForeColor = Color.Orange;
                HoursLabel.ForeColor = Color.Orange;
                MinutesLabel.ForeColor = Color.Orange;
                SecondsLabel.ForeColor = Color.Orange;
            }
            else if (comboBox31.Text == "Yellow")
            {
                DateLabel.ForeColor = Color.Yellow;
                TimeLabel.ForeColor = Color.Yellow;
                notepadTextBox.ForeColor = Color.Yellow;
                SundayTextbox.ForeColor = Color.Yellow;
                MondayTextBox.ForeColor = Color.Yellow;
                TuesdayTextBox.ForeColor = Color.Yellow;
                WednesdayTextBox.ForeColor = Color.Yellow;
                ThursdayTextBox.ForeColor = Color.Yellow;
                FridayTextBox.ForeColor = Color.Yellow;
                SaturdayTextBox.ForeColor = Color.Yellow;
                GoogleLabel.ForeColor = Color.Yellow;
                groupBox1.ForeColor = Color.Yellow;
                groupBox2.ForeColor = Color.Yellow;
                label1.ForeColor = Color.Yellow;
                label11.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;
                label5.ForeColor = Color.Yellow;
                label6.ForeColor = Color.Yellow;
                label7.ForeColor = Color.Yellow;
                label9.ForeColor = Color.Yellow;
                label10.ForeColor = Color.Yellow;
                label14.ForeColor = Color.Yellow;
                label15.ForeColor = Color.Yellow;
                label16.ForeColor = Color.Yellow;
                label17.ForeColor = Color.Yellow;
                HoursLabel.ForeColor = Color.Yellow;
                MinutesLabel.ForeColor = Color.Yellow;
                SecondsLabel.ForeColor = Color.Yellow;
            }
            else if (comboBox31.Text == "White")
            {
                DateLabel.ForeColor = Color.White;
                TimeLabel.ForeColor = Color.White;
                notepadTextBox.ForeColor = Color.White;
                SundayTextbox.ForeColor = Color.White;
                MondayTextBox.ForeColor = Color.White;
                TuesdayTextBox.ForeColor = Color.White;
                WednesdayTextBox.ForeColor = Color.White;
                ThursdayTextBox.ForeColor = Color.White;
                FridayTextBox.ForeColor = Color.White;
                SaturdayTextBox.ForeColor = Color.White;
                GoogleLabel.ForeColor = Color.White;
                groupBox1.ForeColor = Color.White;
                groupBox2.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label11.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label7.ForeColor = Color.White;
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label14.ForeColor = Color.White;
                label15.ForeColor = Color.White;
                label16.ForeColor = Color.White;
                label17.ForeColor = Color.White;
                HoursLabel.ForeColor = Color.White;
                MinutesLabel.ForeColor = Color.White;
                SecondsLabel.ForeColor = Color.White;
            }

            if(comboBox32.Text == "Blue")
            {
                notepadTextBox.BackColor = Color.Blue;
                DateLabel.BackColor = Color.Blue;
                TimeLabel.BackColor = Color.Blue;
                tabPage1.BackColor = Color.Blue;
                tabPage2.BackColor = Color.Blue;
                Calendar.BackColor = Color.Blue;
                panel2.BackColor = Color.Blue;
                panel34.BackColor = Color.Blue;
                SundayTextbox.BackColor = Color.Blue;
                MondayTextBox.BackColor = Color.Blue;
                TuesdayTextBox.BackColor = Color.Blue;
                WednesdayTextBox.BackColor = Color.Blue;
                ThursdayTextBox.BackColor = Color.Blue;
                FridayTextBox.BackColor = Color.Blue;
                SaturdayTextBox.BackColor = Color.Blue;

            } else if (comboBox32.Text == "Black")
            {
                notepadTextBox.BackColor = Color.Black;
                DateLabel.BackColor = Color.Black;
                TimeLabel.BackColor = Color.Black;
                tabPage1.BackColor = Color.Black;
                tabPage2.BackColor = Color.Black;
                Calendar.BackColor = Color.Black;
                panel2.BackColor = Color.Black;
                panel34.BackColor = Color.Black;
                SundayTextbox.BackColor = Color.Black;
                MondayTextBox.BackColor = Color.Black;
                TuesdayTextBox.BackColor = Color.Black;
                WednesdayTextBox.BackColor = Color.Black;
                ThursdayTextBox.BackColor = Color.Black;
                FridayTextBox.BackColor = Color.Black;
                SaturdayTextBox.BackColor = Color.Black;
            }
            else if (comboBox32.Text == "Green")
            {
                notepadTextBox.BackColor = Color.Green;
                DateLabel.BackColor = Color.Green;
                TimeLabel.BackColor = Color.Green;
                tabPage1.BackColor = Color.Green;
                tabPage2.BackColor = Color.Green;
                Calendar.BackColor = Color.Green;
                panel2.BackColor = Color.Green;
                panel34.BackColor = Color.Green;
                SundayTextbox.BackColor = Color.Green;
                MondayTextBox.BackColor = Color.Green;
                TuesdayTextBox.BackColor = Color.Green;
                WednesdayTextBox.BackColor = Color.Green;
                ThursdayTextBox.BackColor = Color.Green;
                FridayTextBox.BackColor = Color.Green;
                SaturdayTextBox.BackColor = Color.Green;
            }
            else if (comboBox32.Text == "Red")
            {
                notepadTextBox.BackColor = Color.Red;
                DateLabel.BackColor = Color.Red;
                TimeLabel.BackColor = Color.Red;
                tabPage1.BackColor = Color.Red;
                tabPage2.BackColor = Color.Red;
                Calendar.BackColor = Color.Red;
                panel2.BackColor = Color.Red;
                panel34.BackColor = Color.Red;
                SundayTextbox.BackColor = Color.Red;
                MondayTextBox.BackColor = Color.Red;
                TuesdayTextBox.BackColor = Color.Red;
                WednesdayTextBox.BackColor = Color.Red;
                ThursdayTextBox.BackColor = Color.Red;
                FridayTextBox.BackColor = Color.Red;
                SaturdayTextBox.BackColor = Color.Red;
            }
            else if (comboBox32.Text == "Orange")
            {
                notepadTextBox.BackColor = Color.Orange;
                DateLabel.BackColor = Color.Orange;
                TimeLabel.BackColor = Color.Orange;
                tabPage1.BackColor = Color.Orange;
                tabPage2.BackColor = Color.Orange;
                Calendar.BackColor = Color.Orange;
                panel2.BackColor = Color.Orange;
                panel34.BackColor = Color.Orange;
                SundayTextbox.BackColor = Color.Orange;
                MondayTextBox.BackColor = Color.Orange;
                TuesdayTextBox.BackColor = Color.Orange;
                WednesdayTextBox.BackColor = Color.Orange;
                ThursdayTextBox.BackColor = Color.Orange;
                FridayTextBox.BackColor = Color.Orange;
                SaturdayTextBox.BackColor = Color.Orange;
            }
            else if (comboBox32.Text == "Yellow")
            {
                notepadTextBox.BackColor = Color.Yellow;
                DateLabel.BackColor = Color.Yellow;
                TimeLabel.BackColor = Color.Yellow;
                tabPage1.BackColor = Color.Yellow;
                tabPage2.BackColor = Color.Yellow;
                Calendar.BackColor = Color.Yellow;
                panel2.BackColor = Color.Yellow;
                panel34.BackColor = Color.Yellow;
                SundayTextbox.BackColor = Color.Yellow;
                MondayTextBox.BackColor = Color.Yellow;
                TuesdayTextBox.BackColor = Color.Yellow;
                WednesdayTextBox.BackColor = Color.Yellow;
                ThursdayTextBox.BackColor = Color.Yellow;
                FridayTextBox.BackColor = Color.Yellow;
                SaturdayTextBox.BackColor = Color.Yellow;
            }
            else if (comboBox32.Text == "White")
            {
                notepadTextBox.BackColor = Color.White;
                DateLabel.BackColor = Color.White;
                TimeLabel.BackColor = Color.White;
                tabPage1.BackColor = Color.White;
                tabPage2.BackColor = Color.White;
                Calendar.BackColor = Color.White;
                panel2.BackColor = Color.White;
                panel34.BackColor = Color.White;
                SundayTextbox.BackColor = Color.White;
                MondayTextBox.BackColor = Color.White;
                TuesdayTextBox.BackColor = Color.White;
                WednesdayTextBox.BackColor = Color.White;
                ThursdayTextBox.BackColor = Color.White;
                FridayTextBox.BackColor = Color.White;
                SaturdayTextBox.BackColor = Color.White;
            }
            Properties.Settings.Default.FontColor = comboBox31.Text;
            Properties.Settings.Default.BackgroundColor = comboBox32.Text;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Stopwatch

        private void Stopwatch_Stop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void Stopwatch_Reset_Click(object sender, EventArgs e)
        {
            ms = 0;
            h = 0;
            s = 0;
            m = 0;
            timer2.Enabled = false;
            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            label5.Text = "00";
        }

        #endregion

        #endregion

        #region Hotkey Implementation

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        private Hotkey hotkey;

        int toggle = 1;
        //Hotkey Integration
        protected override void WndProc(ref Message keyPressed)
        {
            if (keyPressed.Msg == 0x0312 && (int)keyPressed.WParam == 1) //hotkey 1 pressed
            {
                if (toggle == 1)
                {
                    SaveRichTextBoxes();    //Save information into RichTextBoxes
                    this.Hide();
                    //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    toggle = 0;
                }
                else
                {
                    //Using mouse positon to figure out if mouse is on monitor 1(left) or 2(right)
                    if (Cursor.Position.X < 0)
                    {
                        openOnMonitor(0);   //Open form on monitor 1
                    }
                    else
                    {
                        openOnMonitor(1);   //Open form on monitor 2
                    }
                    this.Show();
                    //this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                    SearchBar.Focus();   //Bring focus to google searchbar
                    LoadRichTextBoxes();    //Load information into RichTextBoxes
                    toggle = 1;
                }
            }
            base.WndProc(ref keyPressed);
        }
        #endregion
    }
}
