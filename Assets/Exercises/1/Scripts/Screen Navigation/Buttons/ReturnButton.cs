using System;

namespace Exercise1.ScreenNavigation
{
    public class ReturnButton : Button
    {
        public static event Action OnReturn;

        protected override void Awake()
        {
            base.Awake();

            _button.onClick.AddListener(() => OnReturn?.Invoke());
        }
    }
}