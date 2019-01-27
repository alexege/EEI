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
    /// <summary>
    /// Interaction logic for Soundboard.xaml
    /// </summary>
    public partial class Soundboard : Page
    {
        public Soundboard()
        {
            InitializeComponent();

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = "45" });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = "80" });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = "0" });
            items.Add(new TodoItem() { Title = "Mow the lawn", Completion = "5" });
            items.Add(new TodoItem() { Title = "Mow the lawn", Completion = "5" });
            lbTodoList.ItemsSource = items;
        }

        private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (lbTodoList.SelectedItem != null)
                this.Title = (lbTodoList.SelectedItem as TodoItem).Title;
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.SelectedItems)
                MessageBox.Show((o as TodoItem).Title);
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {

            int nextIndex = 0;
            if ((lbTodoList.SelectedIndex >= 0) && (lbTodoList.SelectedIndex < (lbTodoList.Items.Count - 1)))
                nextIndex = lbTodoList.SelectedIndex + 1;
            lbTodoList.SelectedIndex = nextIndex;
            //MessageBox.Show("index: " + lbTodoList.SelectedIndex.ToString() + Environment.NewLine + "count: " + lbTodoList.Items.Count.ToString()
            //    + Environment.NewLine + "nextindex: " + nextIndex);
            label1.Content = lbTodoList.SelectedIndex;
            label2.Content = lbTodoList.Items.Count;
            label3.Content = nextIndex;

        }

        private void btnSelectPrev_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((lbTodoList.SelectedIndex > 0) && (lbTodoList.SelectedIndex <= (lbTodoList.Items.Count - 1)))
                if ((lbTodoList.SelectedIndex > 0) && (lbTodoList.SelectedIndex > 0))
                {
                nextIndex = lbTodoList.SelectedIndex - 1;
            }
            lbTodoList.SelectedIndex = nextIndex;

            //int prevIndex = lbTodoList.Items.Count;

            label1.Content = lbTodoList.SelectedIndex;
            label2.Content = lbTodoList.Items.Count;
            label3.Content = nextIndex;

            //if (lbTodoList.SelectedIndex > 0)
            //{
            //    prevIndex = lbTodoList.SelectedIndex - 1;
            //    //lbTodoList.SelectedIndex = prevIndex;
            //} else if (lbTodoList.SelectedIndex == 0)
            //{
            //    MessageBox.Show("is zero");
            //    prevIndex = lbTodoList.Items.Count;
            //}

            //if(prevIndex == 4)
            //{
            //    lbTodoList.SelectedIndex = lbTodoList.Items.Count;
            //}
            ////lbTodoList.SelectedIndex = prevIndex;
            //MessageBox.Show("previndex: " + prevIndex);
            //prevIndex = lbTodoList.Items.Count;
            //MessageBox.Show("lbToDoList.items.count: " + lbTodoList.Items.Count);
            //lbTodoList.SelectedIndex = prevIndex;
            //lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
        }

        private void btnSelectCSharp_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.Items)
            {
                if ((o is TodoItem) && ((o as TodoItem).Title.Contains("C#")))
                {
                    lbTodoList.SelectedItem = o;
                    break;
                }
            }
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.Items)
                lbTodoList.SelectedItems.Add(o);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            //List<TodoItem> items = new List<TodoItem>();
            //lbTodoList.Items.Add(addTextBox.Text.ToString());
            //List<TodoItem> items = new List<TodoItem>();
            lbTodoList.Items.Add("Example Text");
            //lbTodoList.ItemsSource = items;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            List<TodoItem> items = new List<TodoItem>();
            lbTodoList.ItemsSource = items;
        }
    }

    public class TodoItem
        {
            public string Title { get; set; }
            public string Completion { get; set; }
        }
}
