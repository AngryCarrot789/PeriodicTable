using PeriodicTable.ElementFinder;
using PeriodicTable.Elements;
using System.Windows.Input;

namespace PeriodicTable.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public double RadioactiveIconOpacity { get => 0.1; }
        public ICommand UpdateElementCommand { get; set; }
        private ElementPresenter _presenter = new ElementPresenter();
        public CommandsViewModel Commands { get; set; } = new CommandsViewModel();
        public MainViewModel()
        {
            UpdateElementCommand = new Command(Update);
        }

        private void Update(object elementSymbol)
        {
            Element newContext = ElementNameMatcher.FindElementFromString(elementSymbol.ToString());
            if (!_presenter.IsActive && newContext != null)
                _presenter.Show();

            if (newContext != null)
                _presenter.DataContext = newContext;
        }
    }
}
