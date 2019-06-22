using codefirstForWpf.DAL;
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

namespace codefirstForWpf
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var user = unitOfWork.SysUserRepository.Get();
        }
        AccountContext db = new AccountContext();
        UnitOfWork unitOfWork = new UnitOfWork();

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)      //登录按钮
        {
            var users = unitOfWork.SysUserRepository.Get();
            var user = users.Where(s => s.UserName == this.cbxUserName.Text && s.Password == this.tbxPassword.Password).FirstOrDefault();       //检测账号密码
            if (user == null)
            {
                MessageBox.Show("账号或密码错误！");                //显示登录失败
            }
            else
            {
                LoginFrame.Visibility = Visibility.Collapsed;       //折叠登录界面
                DialogFrame.Visibility = Visibility.Visible;        //显示聊天界面
                MessageBox.Show("登录成功，进入聊天！");                      //显示登录成功
            }

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Erweima_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)       //关闭按钮
        {
            LoginFrame.Visibility = Visibility.Visible;                     //显示登陆界面
            DialogFrame.Visibility = Visibility.Collapsed;                  //折叠对话界面
        }

        private void Sending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Spread_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
