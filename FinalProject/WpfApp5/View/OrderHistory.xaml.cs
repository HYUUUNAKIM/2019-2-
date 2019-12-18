using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    /// OrderHistory.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderHistory : Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

        public OrderHistory()
        {
            InitializeComponent();
            FillGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Order.xaml", UriKind.Relative));
        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //전역 데이터 사용
            labelid.Content = Application.Current.Properties["Id"].ToString();
        }

        public void FillGrid()
        {

            //MySqlConnection conn = new MySqlConnection(connstr);
            /*try
            {
                conn.Open();
                string sql = "select * from orderDB"
            }*/
            string MyConString =
            "SERVER=localhost;" +
            "DATABASE=cafe;" +
            "UID=root;" +
            "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";



            string sql = "select * from orderDB where id = '" + this.labelid.Content + "'";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    DataGrid.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }
        }

    }
}
