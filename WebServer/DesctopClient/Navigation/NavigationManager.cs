using System;
using System.Windows.Navigation;
using DesktopClient.ViewModels;
using DesctopClient.Views;


namespace DesktopClient.Navigation
{
    public class NavigationManager
    {
        private readonly NavigationService _navigationService;
        private static NavigationManager _instanse;

        private NavigationManager(NavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        public static NavigationManager Instanse
        {
            get
            {
                return _instanse;
            }
        }

        public static void CreateNavigationManager(NavigationService mainFrameService)
        {
            _instanse = new NavigationManager(mainFrameService);
        }

        /*private object GetNavigateObject(object obj)
        {
            if (obj is CardsViewModel)
            {
                return new CardsView { DataContext = obj };
            }
            
            else
            {
                throw new ArgumentException("Некорректный параметр навигации");
            }
        }

        public void Navigate(object target)
        {
            var navigatedObject = GetNavigateObject(target);

            _navigationService.Navigate(navigatedObject);
        }*/
    }
}
