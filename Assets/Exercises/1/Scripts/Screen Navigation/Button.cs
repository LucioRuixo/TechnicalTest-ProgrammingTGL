using TMPro;
using UnityEngine;

namespace Exercise1.ScreenNavigation
{
    public class Button : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] protected TMP_Text _text;
        [SerializeField] protected UnityEngine.UI.Button _button;

        protected virtual void Awake()
        {
            _button = GetComponent<UnityEngine.UI.Button>();
        }

        public void SetActive(bool active) => gameObject.SetActive(active);

        public void SetText(string text) => _text.text = text;
    }
}