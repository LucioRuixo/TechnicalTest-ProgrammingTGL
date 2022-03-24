using UnityEngine;

namespace Exercise1.ScreenNavigation
{
    public class Screen : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] Transform _content;
        [SerializeField] ReturnButton _returnButton;
        [SerializeField] GameObject _navigationButtonPrefab;

        [Header("Screen Properties")]
        [SerializeField] string _screenName;
        [Space]
        [SerializeField] bool _canReturn;
        [SerializeField] Screen[] _navigableScreens;

        bool _buttonsGenerated = false;
        Screen _activator;

        public string Name { get { return _screenName; } }
        public Screen Activator { get { return _activator; } }

        void Start() => _returnButton.SetActive(_canReturn);

        public void OnActive(Screen activator)
        {
            if (!gameObject.activeSelf)
            {
                Debug.LogWarning("Can not process screen activation for " + _screenName + ": screen object is not enabled.");
                return;
            }

            _activator = activator;

            if (!_buttonsGenerated)
            {
                GenerateNavigationButtons();
                _buttonsGenerated = true;
            }
        }

        void GenerateNavigationButtons()
        {
            foreach (Screen screen in _navigableScreens)
            {
                NavigationButton button = Instantiate(_navigationButtonPrefab, _content).GetComponent<NavigationButton>();

                button.SetText(screen.Name);
                button.SetNavigation(screen);
            }
        }
    }
}