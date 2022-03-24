using UnityEngine;

namespace Exercise2.UI
{
    public abstract class Button : MonoBehaviour
    {
        protected abstract void OnClick();

        public bool IsActive { get { return gameObject.activeInHierarchy; } }
    }
}