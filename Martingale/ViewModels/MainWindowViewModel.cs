using Martingale.Commands;
using Martingale.Models;
using System.Diagnostics;
using System.Windows.Input;

namespace Martingale.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private User user;
        private int _id;
        private string _name;
        private decimal bank;


        public User User
        {
            get { return user; }
            set 
            { 
                user = value;
                OnPropertyChanged();
            }
        }


        public int Id
        {
            get => user.Id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => user.Name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public decimal Bank
        {
            get => user.Bank;
            set 
            {
                user.Bank = value;
                OnPropertyChanged();
            }
        }

        public ICommand IncreaseCommand { get; }

        public MainWindowViewModel()
        {
            user = new User
            {
                Id = 1,
                Name = "Dylan",
                Bank = 10
            };
            IncreaseCommand = new IncreaseBankrollCommand(this);
        }

        public void IncreaseBank()
        {
            Bank += 50;
        }
    }
}
