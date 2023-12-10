using System.ComponentModel;

namespace WPFStudy_LibraryManager
{
    public class LoginUIViewModel : INotifyPropertyChanged
    {
        private LoginValue _Login;
        public LoginValue Login
        {
            get
            {
                if (_Login == null) { _Login = new LoginValue(); }
                return _Login;
            }
            set
            {
                _Login = value;
                FirePropertyChangedEvent(nameof(Login));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void FirePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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
