using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ToDoList.xaml
    /// </summary>
    public partial class ToDoList : Page
    {
        public ToDoList()
        {
            InitializeComponent();
            fill_listBox();
            List<TodoItem> items = new List<TodoItem>();
        }

        //Populate Listbox
        void fill_listBox()
        {
            string connectionString = "user id=root;password=root;server=Localhost;database=tododatabase";
            MySqlConnection myConn = new MySqlConnection(connectionString);
            try
            {
                myConn.Open();
                MySqlCommand cmd = new MySqlCommand(" select * from list", myConn);
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM list", myConn);
                DataTable namesTable = new DataTable();
                adapter.Fill(namesTable);
                myConn.Close();

                //idListBox.ItemsSource = namesTable.AsDataView();
                //idListBox.DisplayMemberPath = "idlist";
                //idListBox.SelectedValuePath = "idlist";

                lbTodoList.ItemsSource = namesTable.AsDataView();
                lbTodoListDate.ItemsSource = namesTable.AsDataView();
                //lbTodoList.DisplayMemberPath = "name";
                lbTodoList.SelectedValuePath = "name";
                lbTodoListDate.SelectedValue = "date";
                //lbTodoList.SelectedValue = "Study for test";
                //lbTodoList.SelectedItem = "Study for test";

                //MessageBox.Show(lbTodoList.SelectedValue != null ? lbTodoList.SelectedValue.ToString() : "I have 0 selected item!");

                //dateListBox.ItemsSource = namesTable.AsDataView();
                //dateListBox.DisplayMemberPath = "date";
                //dateListBox.SelectedValuePath = "date";

                //If lblTodoList contains items, select first element.
                lbTodoList.SelectedIndex = 0;

                if(this.lbTodoList.Items.Count > 0)
                {
                    this.lbTodoList.SelectedIndex = 0;
                }

                lbTodoListDate.SelectedIndex = 0;
                if(this.lbTodoListDate.Items.Count > 0)
                {
                    this.lbTodoListDate.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string id_val = idTextBox.Text;
                string name_val = nameTextBox.Text;
                string date_val = dateTextBox.Text;

                string connectionString = "user id=root;password=root;server=localhost;database=tododatabase";
                string addQuery = "INSERT INTO tododatabase.list(idlist, name, date) VALUES('" + id_val + "', '" + name_val + "', '" + date_val + "')";

                MySqlConnection myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                MySqlCommand myCommand = new MySqlCommand(addQuery, myConnection);
                MySqlDataReader myReader = myCommand.ExecuteReader();

                //if (myCommand.ExecuteNonQuery() == 1)
                //{
                //    MessageBox.Show("User Added!");
                //}
                //else
                //{
                //    MessageBox.Show("Error adding user!");
                //}

                myConnection.Close();
                idTextBox.Text = "";
                nameTextBox.Text = "";
                dateTextBox.Text = "";

                fill_listBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnShowSelectedItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lbTodoList.SelectedValue.ToString());
        }

        private void btnSelectNext_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            if ((lbTodoList.SelectedIndex >= 0) && (lbTodoList.SelectedIndex < (lbTodoList.Items.Count - 1)))
                nextIndex = lbTodoList.SelectedIndex + 1;
            lbTodoList.SelectedIndex = nextIndex;
        }

        private void btnSelectPrev_Click(object sender, RoutedEventArgs e)
        {
            int nextIndex = 0;
            //If greater than 0, and index <= number of items in list, nextIndex is selected index -1
            if ((lbTodoList.SelectedIndex > 0) && (lbTodoList.SelectedIndex <= (lbTodoList.Items.Count - 1)))
                nextIndex = lbTodoList.SelectedIndex - 1;
            lbTodoList.SelectedIndex = nextIndex;
        }

        private void btnSelectLast_Click(object sender, RoutedEventArgs e)
        {
            lbTodoList.SelectedIndex = lbTodoList.Items.Count - 1;
        }

        private void btnSelectAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (object o in lbTodoList.Items)
                lbTodoList.SelectedItems.Add(o);
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            List<TodoItem> items = new List<TodoItem>();
            lbTodoList.ItemsSource = items;
            fill_listBox();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            string value = lbTodoList.SelectedValue.ToString();
            MySqlConnection connection = new MySqlConnection("user id=root;password=root;server=Localhost;database=tododatabase");
            string name = lbTodoList.SelectedValue.ToString();
            string deleteQuery = "DELETE FROM tododatabase.list WHERE name = '" + name + "'";
            connection.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, connection);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show("Deleted Successfully");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            ((DataRowView)(lbTodoList.SelectedItem)).Row.Delete();
        }

        private void lbTodoList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbTodoListDate.SelectedIndex = lbTodoList.SelectedIndex;
        }

        public class TodoItem
        {
            public string Title { get; set; }
            public string Completion { get; set; }
        }
    }
}
