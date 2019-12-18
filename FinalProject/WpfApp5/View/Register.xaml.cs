using System;
using System.Collections.Generic;
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
using WpfApp5.ViewModel;
using System.Data;
using System.Collections;
using MySql.Data.MySqlClient;

namespace WpfApp5
{
    /// <summary>
    /// Register.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Register : Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

        int i;

        public Register()
        {
                InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("아이디를 입력하세요");
                return;
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("비밀번호를 입력하세요");
                return;
            }

            conn.Open();
            string sql = "insert into buyer values('" + this.textBox1.Text + "','" + this.textBox2.Text + "')";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show("회원가입이 완료되었습니다.");
            NavigationService.Navigate(new Uri("/View/Page1.xaml", UriKind.Relative));


        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Page1.xaml", UriKind.Relative));

        }
    

    }
}
