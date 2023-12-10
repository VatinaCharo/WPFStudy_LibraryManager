using System.ComponentModel;
using System.Windows;

namespace WPFStudy_LibraryManager
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (UsrName != "wpf" || Password != "123456")
            {
                MessageBox.Show("用户名或密码不正确");
                UsrName = string.Empty;
                Password = string.Empty;
                return;
            }
            var index = new Index();
            index.Show();
            Close();
        }
    }
}
