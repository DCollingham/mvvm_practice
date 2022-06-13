using Martingale.Models;

namespace Martingale.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private User user;
        private int _id;
        private string _name;
        private decimal _bankroll;

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

        public decimal Bankroll
        {
            get => user.BankRoll;
            set 
            { 
                _bankroll = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            user = new User
            {
                Id = 1,
                Name = "Dylan",
                BankRoll = 10
            };
        }
    }
}
