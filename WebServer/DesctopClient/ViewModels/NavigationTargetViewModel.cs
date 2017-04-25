using System.Collections.Generic;
using DesktopClient.Navigation;

namespace DesktopClient.ViewModels
{
    public class NavigationTargetViewModel : BaseViewModel
    {
        public NavigationTargetViewModel()
        {
            InitializeNavigationCommands();
        }

        private void InitializeNavigationCommands()
        {
            /*NavigationCommands = new List<object>
            {
                new NavigationStateViewModel(OnNavigateCards, this is CardsViewModel, "Карты"),
                new NavigationStateViewModel(OnNavigatePassports, this is PassportsViewModel, "Паспорта"),
                new NavigationStateViewModel(OnNavigateProfile, this is ProfileViewModel, "Профиль"),
                new NavigationStateViewModel(OnNavigateVisit, this is VisitViewModel, "Визит")
            };*/           
        }

        public List<object> NavigationCommands { get; set; }
    }
}
