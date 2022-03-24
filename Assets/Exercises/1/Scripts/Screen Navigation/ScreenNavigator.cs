using UnityEngine;

namespace Exercise1.ScreenNavigation
{
    public class ScreenNavigator : MonoBehaviour
    {
        [Header("Navigation Properties")]
        [SerializeField] Screen _initialScreen;

        Screen _currentScreen;

        void OnEnable()
        {
            NavigationButton.OnNavigateToScreen += NavigateToScreen;
            ReturnButton.OnReturn += ReturnToPreviousScreen;
        }

        void Start() => NavigateToScreen(_initialScreen);

        void OnDisable()
        {
            NavigationButton.OnNavigateToScreen -= NavigateToScreen;
            ReturnButton.OnReturn -= ReturnToPreviousScreen;
        }

        public void NavigateToScreen(Screen screen)
        {
            if (screen == _currentScreen)
            {
                Debug.LogWarning("Can not navigate to screen: target screen is already active.");
                return;
            }

            if (_currentScreen) DeactivateScreen(_currentScreen);
            ActivateScreen(screen);

            Debug.Log("NAVIGATING TO SCREEN: " + screen.Name);
        }

        public void ReturnToPreviousScreen() => NavigateToScreen(_currentScreen.Activator);

        void ActivateScreen(Screen screen)
        {
            screen.gameObject.SetActive(true);
            screen.OnActive(_currentScreen);

            _currentScreen = screen;
        }

        void DeactivateScreen(Screen screen) => screen.gameObject.SetActive(false);
    }
}