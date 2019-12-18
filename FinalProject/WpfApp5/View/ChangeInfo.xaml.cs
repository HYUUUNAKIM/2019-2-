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
using MySql.Data.MySqlClient;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// ChangeInfo.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ChangeInfo : Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

        public ChangeInfo()
        {
            InitializeComponent();
        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //전역 데이터 사용
            labelid.Content = Application.Current.Properties["Id"].ToString();
            labelpasswd.Content = Application.Current.Properties["Passwd"].ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Order.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            base.OnInitialized(e);
            //전역 데이터 사용
            labelid.Content = Application.Current.Properties["Id"].ToString();
            labelpasswd.Content = Application.Current.Properties["Passwd"].ToString();
            //textBox1.Text = labelpasswd.Content.ToString();

            if (textBox1.Text == labelpasswd.Content.ToString()) //현재 비밀번호랑 텍스트박스1 값이랑 같으면
            {
                string sql = "update buyer set password = '" + this.textBox2.Text + "' where id = '" + this.labelid.Content + "'";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("비밀번호 수정 완료.");
                
            }
            else
            {
                MessageBox.Show("현재 비밀번호가 일치하지 않습니다.");
            }
        }
    }
}
