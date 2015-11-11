using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMCommon;
using ProjectManager.GUI.Enums;

namespace ProjectManager.GUI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            _connectionState = ConnectionState.IsOnline;
        }


        private ConnectionState _connectionState;


        public ConnectionState ConnectionState
        {
            get { return _connectionState; }
            set
            {
                _connectionState = value;
                NotifyPropertyChanged("ConnectionState");
            }
        }
    }
}
