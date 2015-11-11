using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMCommon;
using ProjectManager.Entity;

namespace ProjectManager.GUI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel()
        {
            Issues = new ObservableCollection<Issue>
            {
                new Issue() {Name = "Create DB connection"},
                new Issue() {Name = "Add NInject"},
                new Issue() {Name = "Remove trash"},
                new Issue() {Name = "Add migrations"},
                new Issue() {Name = "Some issue"},
                new Issue() {Name = "Give dragon ass"},
            };
            Comments = new ObservableCollection<Comment>
            {
                new Comment() { Text = "Some text for comment"},
                new Comment() { Text = "Some text for comment"},
                new Comment() { Text = "Some text for comment"},
                new Comment() { Text = "Some text for comment"},
                new Comment() { Text = "Some text for comment"},
            };
        }


        private ObservableCollection<Issue> _issues;
        private ObservableCollection<Comment> _comments;


        public ObservableCollection<Issue> Issues
        {
            get { return _issues;}
            set
            {
                _issues = value;
                NotifyPropertyChanged("Issues");
            }
        }
        public ObservableCollection<Comment> Comments
        {
            get { return _comments; }
            set
            {
                _comments = value;
                NotifyPropertyChanged("Comments");
            }
        } 
    }
}
