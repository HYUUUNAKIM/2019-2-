using MySql.Data.MySqlClient;
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

namespace WpfApp5
{
    /// <summary>
    /// Order.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Order : Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";

        public Order()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Page1.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/ChangeInfo.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/OrderHistory.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Hot - 음료 2";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Hot - 음료 2";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Hot - 음료 2";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Hot - 음료 2";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Hot - 음료 2";
                }
            }
            else if (radioButton2.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Ice - 음료 2";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Ice - 음료 2";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Ice - 음료 2";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Ice - 음료 2";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Ice - 음료 2";
                }
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Hot - 음료 1";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Hot - 음료 1";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Hot - 음료 1";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Hot - 음료 1";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Hot - 음료 1";
                }
            }
            else if (radioButton2.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Ice - 음료 1";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Ice - 음료 1";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Ice - 음료 1";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Ice - 음료 1";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Ice - 음료 1";
                }
            }

        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //전역 데이터 사용
            label13.Content = Application.Current.Properties["Id"].ToString();
        }


        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            base.OnInitialized(e);
            //전역 데이터 사용
            label13.Content = Application.Current.Properties["Id"].ToString();

            if (label1.Content == "Hot - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Hot - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Hot - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Hot - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Hot - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }

            if (label1.Content == "Ice - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Ice - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Ice - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Ice - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Ice - 음료 1")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-1',now(),'false',1000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            //-----------------------------------------------------------------------------
            if (label1.Content == "Hot - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Hot - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Hot - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Hot - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Hot - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }

            if (label1.Content == "Ice - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Ice - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Ice - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Ice - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Ice - 음료 2")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-2',now(),'false',2000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            //-----------------------------------------------------------------------------
            if (label1.Content == "Hot - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Hot - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Hot - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Hot - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Hot - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Hot-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }

            if (label1.Content == "Ice - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label2.Content == "Ice - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label3.Content == "Ice - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label4.Content == "Ice - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }
            if (label5.Content == "Ice - 음료 3")
            {
                string sql = "insert into orderDB values('" + this.label13.Content + "','Ice-3',now(),'false',3000)";
                MySqlCommand command = new MySqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("주문 완료");
            }

            if (label1.Content == "" && label2.Content == "" && label3.Content == "" && label4.Content == "" && label5.Content == "")
            {
                MessageBox.Show("주문 가능한 음료가 없습니다");
            }

            Application.Current.Properties["1"] = label1.Content;
            Application.Current.Properties["2"] = label2.Content;
            Application.Current.Properties["3"] = label3.Content;
            Application.Current.Properties["4"] = label4.Content;
            Application.Current.Properties["5"] = label5.Content;
        }



        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Hot - 음료 3";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Hot - 음료 3";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Hot - 음료 3";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Hot - 음료 3";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Hot - 음료 3";
                }
            }
            else if (radioButton2.IsChecked.Value)
            {
                if (label1.Content == "")
                {
                    label1.Content = "Ice - 음료 3";
                }
                else if (label2.Content == "")
                {
                    label2.Content = "Ice - 음료 3";
                }
                else if (label3.Content == "")
                {
                    label3.Content = "Ice - 음료 3";
                }
                else if (label4.Content == "")
                {
                    label4.Content = "Ice - 음료 3";
                }
                else if (label5.Content == "")
                {
                    label5.Content = "Ice - 음료 3";
                }
            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
            label2.Content = "";
            label3.Content = "";
            label4.Content = "";
            label5.Content = "";

        }
    }
}
