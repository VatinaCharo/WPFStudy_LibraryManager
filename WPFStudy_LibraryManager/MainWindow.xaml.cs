using System.Windows;

namespace WPFStudy_LibraryManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginUIViewModel LoginUIVM;
        public MainWindow()
        {
            InitializeComponent();
            LoginUIVM = new LoginUIViewModel();
            DataContext = LoginUIVM;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginUIVM.UsrName != "wpf" || LoginUIVM.Password != "123456")
            {
                MessageBox.Show("用户名或密码不正确");
                LoginUIVM.UsrName = string.Empty;
                LoginUIVM.Password = string.Empty;
                return;
            }
            var index = new Index();
            index.Show();
            Close();
        }
    }
}
