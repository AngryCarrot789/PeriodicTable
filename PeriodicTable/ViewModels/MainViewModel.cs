using PeriodicTable.ElementFinder;
using PeriodicTable.Elements;
using PeriodicTable.Views;
using System.Windows.Input;

namespace PeriodicTable.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public double RadioactiveIconOpacity { get => 0.1; }

        public ICommand UpdateElementCommand { get; set; }
        public ICommand ShowElementGroupInfoCommand { get; set; }

        private ElementPresenter ElementPresenter = new ElementPresenter();
        private ElementGroupPresenter GroupPresenter = new ElementGroupPresenter();
        public CommandsViewModel Commands { get; set; } = new CommandsViewModel();
        public MainViewModel()
        {
            UpdateElementCommand        = new Command(UpdateElementPresenter);
            ShowElementGroupInfoCommand = new Command(ShowElementGroups);
        }

        private void UpdateElementPresenter(object elementSymbol)
        {
            Element newContext = ElementNameMatcher.FindElementFromString(elementSymbol.ToString());
            if (!ElementPresenter.IsActive && newContext != null)
                ElementPresenter.Show();

            if (newContext != null)
                ElementPresenter.DataContext = newContext;
        }

        private void ShowElementGroups(object groupName)
        {
            ElementGroup newContext = ElementGroupNameMatcher.FindElementGroupFromString(groupName.ToString());
            if (!GroupPresenter.IsActive && newContext != null)
                GroupPresenter.Show();

            if (newContext != null)
                GroupPresenter.DataContext = newContext;
        }
    }
}
