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

namespace WpfApp5
{
    /// <summary>
    /// Calculate.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Calculate : Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

        public Calculate()
        {
            InitializeComponent();
            FillGridBuyer();
            FillGridOrder();
            Drink1();
            Drink2();
            Drink3();
            Price();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Page4.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/SellerIntro.xaml", UriKind.Relative));
        }
        public void FillGridOrder()
        {
            string MyConString =
            "SERVER=localhost;" +
            "DATABASE=cafe;" +
            "UID=root;" +
            "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";



            string sql = "select * from orderDB";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    DataGrid1.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }
        }
        public void FillGridBuyer()
        {
            string MyConString =
            "SERVER=localhost;" +
            "DATABASE=cafe;" +
            "UID=root;" +
            "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";



            string sql = "select * from buyer";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    DataGrid2.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

            if (button.Content.ToString() == "Search") 
            {
                string sql = "select * from orderDB where id = '" + this.textBox1.Text + "'";
                using (MySqlConnection connection = new MySqlConnection(MyConString))
                {
                    connection.Open();
                    using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                        da.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    connection.Close();
                }
                button.Content = "ViewAll";
            }
            else if(button.Content.ToString() == "ViewAll")
            {
                string sql = "select * from orderDB";
                using (MySqlConnection connection = new MySqlConnection(MyConString))
                {
                    connection.Open();
                    using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                        da.Fill(dt);
                        DataGrid1.ItemsSource = dt.DefaultView;
                    }
                    connection.Close();
                }
                button.Content = "Search";
            }
        }

        public void Drink1()
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";


            string sql = "select count(drink) from orderDB where drink = 'Ice-1' or drink = 'Hot-1'";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    drink1.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }


        }
        public void Drink2()
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";


            string sql = "select count(drink) from orderDB where drink = 'Ice-2' or drink = 'Hot-2'";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    drink2.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }


        }
        public void Drink3()
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";


            string sql = "select count(drink) from orderDB where drink = 'Ice-3' or drink = 'Hot-3'";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    drink3.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }


        }
        public void Price()
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";


            string sql = "select sum(price) from orderDB;";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    price.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }


        }




        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
    }
}
