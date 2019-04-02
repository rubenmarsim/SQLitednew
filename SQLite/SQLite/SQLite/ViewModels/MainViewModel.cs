using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _textCellCommand;

        private INavigationService _navigationService;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        public ICommand TextCellCommand
        {
            get { return _textCellCommand = _textCellCommand ?? new DelegateCommand(TextCellCommandExecute); }
        }

        private void TextCellCommandExecute()
        {
            _navigationService.NavigateTo<TextCellViewModel>();
        }
    }
}
