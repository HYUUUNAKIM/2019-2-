using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
    /// Page4.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Page4 : Page
    {
        //MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cafe;User Id = root; password ='cs1234'");
        string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";
        public Page4()
        {
            InitializeComponent();
            FillGrid();

        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //전역 데이터 사용
            labelid.Content = Application.Current.Properties["Id"].ToString();

        }
        public void UpdateWindow()
        {

            // 화면 객체의 변경사항을 즉시 업데이트한다
            System.Windows.Threading.Dispatcher.CurrentDispatcher.Invoke(
                      System.Windows.Threading.DispatcherPriority.Background,
                      new System.Threading.ThreadStart(delegate { }));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/Calculate.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/View/SellerIntro.xaml", UriKind.Relative));
        }
        public void FillGrid()
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=cafe;" + "UID=root;" + "PASSWORD=cs1234;";
            string connstr = "server = localhost; user = root; password = cs1234; database = cafe;";



            string sql = "select * from orderDB where id = '" + this.labelid.Content + "' and IsGet = 'false'";

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
            UpdateWindow();

        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UpdateWindow();

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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UpdateWindow();

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

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow();

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


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UpdateWindow();

            if (label1.Content.ToString() == Application.Current.Properties["1"].ToString())
            {
                if(label2.Content.ToString() == Application.Current.Properties["2"].ToString())
                {
                    if(label3.Content.ToString() == Application.Current.Properties["3"].ToString())
                    {
                        if (label4.Content.ToString() == Application.Current.Properties["4"].ToString())
                        {
                            if (label5.Content.ToString() == Application.Current.Properties["5"].ToString())
                            {
                                //IsGet을 true로 바꿔야함
                                MySqlConnection conn = new MySqlConnection(connstr);
                                conn.Open();
                                base.OnInitialized(e);
                                //전역 데이터 사용
                                string sql= "update orderDB set IsGet = 'true' where id = '" + this.labelid.Content + "'";
                                MySqlCommand command = new MySqlCommand(sql, conn);
                                command.ExecuteNonQuery();
                                MessageBox.Show("음료 제조 완료");
                                UpdateWindow();
                            }
                            else
                            {
                                MessageBox.Show("주문한 음료와 제조한 음료가 다릅니다.");
                            }

                        }
                        else
                        {
                            MessageBox.Show("주문한 음료와 제조한 음료가 다릅니다.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("주문한 음료와 제조한 음료가 다릅니다.");
                    }

                }
                else
                {
                    MessageBox.Show("주문한 음료와 제조한 음료가 다릅니다.");
                }

            }
            else
            {
                MessageBox.Show("주문한 음료와 제조한 음료가 다릅니다.");
            }


        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            label1.Content = "";
            label2.Content = "";
            label3.Content = "";
            label4.Content = "";
            label5.Content = "";

        }
    }
}
