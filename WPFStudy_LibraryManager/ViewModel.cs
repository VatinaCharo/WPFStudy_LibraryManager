using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace WPFStudy_LibraryManager
{
    public class LoginUIViewModel : INotifyPropertyChanged
    {
        private readonly Window _OwnerWindow;
        public LoginUIViewModel(Window window)
        {
            _OwnerWindow = window;
        }
        private LoginValue _LoginV;
        public LoginValue LoginV
        {
            get
            {
                if (_LoginV == null) { _LoginV = new LoginValue(); }
                return _LoginV;
            }
            set
            {
                _LoginV = value;
                FirePropertyChangedEvent(nameof(LoginV));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void FirePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string UsrName
        {
            get { return LoginV.UsrName; }
            set { 
                LoginV.UsrName = value;
                FirePropertyChangedEvent(nameof(UsrName));
            }
        }
        public string Password
        {
            get { return LoginV.Password; }
            set
            {
                LoginV.Password = value;
                FirePropertyChangedEvent(nameof(Password));
            }
        }
        public void Login()
        {
            if(UsrName != "wpf" || Password!="123456") {
                MessageBox.Show("用户名或密码不正确");
                UsrName = string.Empty;
                Password = string.Empty;
                return; 
            }
            new Index().Show();
            _OwnerWindow.Close();
        }
        private bool CanLogin()
        {
            return true;
        }
        public ICommand LoginAction
        {
            get
            {
                return new RelayCommand(Login, CanLogin);
            }
        }
    }
    public class LoginValue
    {
        private string _UsrName;
        public string UsrName
        {
            get { return _UsrName; }
            set { _UsrName = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }


    }
}
