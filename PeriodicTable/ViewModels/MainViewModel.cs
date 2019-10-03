using PeriodicTable.ElementFinder;
using PeriodicTable.Elements;
using System.Windows;
using System.Windows.Input;

namespace PeriodicTable.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand UpdateElementCommand { get; set; }
        private ElementPresenter _presenter = new ElementPresenter();
        public CommandsViewModel Commands { get; set; } = new CommandsViewModel();
        public MainViewModel()
        {
            UpdateElementCommand = new Command(Update);
        }

        private void Update(object elementName)
        {
            if (!_presenter.IsActive)
                _presenter.Show();
            IElement newContext = ElementNameMatcher.FindElementFromString(elementName.ToString());
            if(newContext != null) _presenter.DataContext = newContext;
        }
    }
}
