using System.Windows;

namespace WPFStudy_LibraryManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var usrName = usrNameTextBox.Text;
            var usrPwd = usrPasswordTextBox.Text;
            if (usrName != "wpf" || usrPwd != "123456") { MessageBox.Show("用户名或密码不正确"); return; }
            MessageBox.Show("OK");
        }
    }
}
