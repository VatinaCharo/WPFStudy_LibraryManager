using System.ComponentModel;
using System.Windows;

namespace WPFStudy_LibraryManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginModel loginModel;
        public MainWindow()
        {
            InitializeComponent();
            loginModel = new LoginModel();
            DataContext = loginModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (loginModel.UsrName != "wpf" || loginModel.Password != "123456")
            {
                MessageBox.Show("用户名或密码不正确");
                loginModel.UsrName = string.Empty;
                loginModel.Password = string.Empty;
                return;
            }
            var index = new Index();
            index.Show();
            Close();
        }
    }

    /// <summary>
    /// 登录功能的交互逻辑
    /// </summary>
    public class LoginModel : INotifyPropertyChanged
    {
        private string _UsrName;
        public string UsrName
        {
            get { return _UsrName; }
            set
            {
                _UsrName = value;
                FirePropertyChangedEvent("UsrName");
            }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                FirePropertyChangedEvent("Password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void FirePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
