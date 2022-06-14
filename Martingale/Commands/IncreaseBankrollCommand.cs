using Martingale.Models;
using Martingale.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martingale.Commands
{
    public class IncreaseBankrollCommand : CommandBase
    {

        private MainWindowViewModel _mainWindowViewModel;

        public IncreaseBankrollCommand(MainWindowViewModel MainWindowViewModel)
        {
            _mainWindowViewModel = MainWindowViewModel;
        }

        public override void Execute(object? parameter)
        {
            _mainWindowViewModel.IncreaseBank();
        }
    }
}
