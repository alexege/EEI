using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Notes.xaml
    /// </summary>
    public partial class Notes : Page
    {
        public Notes()
        {
            InitializeComponent();
            Properties.Settings.Default.Upgrade();

            //Create two files to store values of textboxes in txt files.
            string fileName = "TextBox1_" + TextBox1.Text + ".txt";
            string fileName2 = "TextBox2_" + TextBox2.Text + ".txt";

            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write(NotesBox1.Text);
            }

            using (StreamWriter writer = new StreamWriter(fileName2, true))
            {
                writer.Write(NotesBox3.Text);
            }
        }
    }
}
