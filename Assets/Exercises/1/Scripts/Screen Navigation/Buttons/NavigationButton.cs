using System;

namespace Exercise1.ScreenNavigation
{
    public class NavigationButton : Button
    {
        public static event Action<Screen> OnNavigateToScreen;

        public void SetNavigation(Screen targetScreen)
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(() => OnNavigateToScreen?.Invoke(targetScreen));
        }
    }
}