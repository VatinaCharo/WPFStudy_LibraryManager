using System.ComponentModel;

namespace WPFStudy_LibraryManager
{
    public class LoginUIValueModel : INotifyPropertyChanged
    {
        private LoginValueModel _LoginVM;
        public LoginValueModel LoginVM
        {
            get
            {
                if (_LoginVM == null) { _LoginVM = new LoginValueModel(); }
                return _LoginVM;
            }
            set
            {
                _LoginVM = value;
                FirePropertyChangedEvent(nameof(LoginVM));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void FirePropertyChangedEvent(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public class LoginValueModel
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
