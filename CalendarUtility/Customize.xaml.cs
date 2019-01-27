using System;
using System.Collections.Generic;
using System.Drawing;
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
using FontFamily = System.Windows.Media.FontFamily;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for Customize.xaml
    /// </summary>
    public partial class Customize : Page
    {
        public Customize()
        {
            InitializeComponent();
            
            OpacityValue.Content = Properties.Settings.Default.OpacityValueSetting;

            //Set combobox text to selected color string
            BackgroundColorCB.Text = Properties.Settings.Default.MainWindowBackground;
            ForegroundColorCB.Text = Properties.Settings.Default.MainWindowForeground;
            BorderColorCB.Text = Properties.Settings.Default.MainWindowBorder;
            ButtonBackgroundCB.Text = Properties.Settings.Default.ButtonBackground;
            ButtonHighlightColorCB.Text = Properties.Settings.Default.ButtonHighlightColor;
            CalendarContentCB.Text = Properties.Settings.Default.CalendarContentColor;

            //Create list of possible colors
            List<string> colorList = new List<string>();
            String[] colors = Enum.GetNames(typeof(KnownColor));

            //Add Custom colors to the list
            colorList.Add("#FF00A2FF");
            colorList.Add("Black");
            colorList.Add("Blue");
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Brown");
            colorList.Add("Navy");
            colorList.Add("Olive");
            colorList.Add("Violet");
            
            //Add most colors from "KnownColor"
            for (int i = 27; i < colors.Length - 7; i++)
            {
                colorList.Add(colors[i]);
            }
            DataContext = colorList;
        }
                     
        public void FillFontComboBox(ComboBox comboBoxFonts)
        {
            // Enumerate the current set of system fonts,
            // and fill the combo box with the names of the fonts.
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                //FontFamily.Source contains the font family name.
                comboBoxFonts.Items.Add(fontFamily.Source);
            }
            comboBoxFonts.SelectedIndex = 0;
        }

        //Save color selection
        private void BackgroundColorCB_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainWindowBackground = BackgroundColorCB.Text;
        }

        private void ForegroundColorCB_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainWindowForeground = ForegroundColorCB.Text;
        }

        private void BorderColorCB_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainWindowBorder = BorderColorCB.Text;
        }

        private void ButtonCB_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.ButtonBackground = ButtonBackgroundCB.Text;
        }

        private void CalendarContentColor_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.CalendarContentColor = CalendarContentCB.Text;
        }

        private void ButtonHihglightColorCB_DropDownClosed(object sender, EventArgs e)
        {
            Properties.Settings.Default.ButtonHighlightColor = ButtonHighlightColorCB.Text;
        }

        private void OpacitySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            OpacityValue.Content = OpacitySlider.Value * 100;
            
        }
    }
}
