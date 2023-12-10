using System.Windows;

namespace WPFStudy_LibraryManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginUIValueModel LoginUIVM;
        public MainWindow()
        {
            InitializeComponent();
            LoginUIVM = new LoginUIValueModel();
            DataContext = LoginUIVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginUIVM.LoginVM.UsrName != "wpf" || LoginUIVM.LoginVM.Password != "123456")
            {
                MessageBox.Show("用户名或密码不正确");
                LoginUIVM.LoginVM.UsrName = string.Empty;
                LoginUIVM.LoginVM.Password = string.Empty;
                LoginUIVM.LoginVM = LoginUIVM.LoginVM;
                return;
            }
            var index = new Index();
            index.Show();
            Close();
        }
    }
}
