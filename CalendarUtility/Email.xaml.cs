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
using MySql.Data.MySqlClient;
using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CalendarUtility
{
    /// <summary>
    /// Interaction logic for Email.xaml
    /// </summary>
    public partial class Email : Page
    {
        public Email()
        {
            InitializeComponent();

            List<String> colors = new List<string>();

            colors.Add("Black");
            colors.Add("Blue");
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Yellow");
            colors.Add("Brown");
            colors.Add("Navy");
            colors.Add("Olive");
            colors.Add("Pink");
            colors.Add("Salmon");
            colors.Add("Violet");

            DataContext = colors;

        }

    }
}
