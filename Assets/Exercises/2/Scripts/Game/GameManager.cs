using Exercise2.Entities.Player;
using UnityEngine;

namespace Exercise2.Game
{
    public class GameManager : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] Player_Controller player;

        [Header("Player")]
        [SerializeField] float _initialPlayerHealth;

        bool _isOnPause;

        public bool IsOnPause { get { return _isOnPause; } }

        void OnEnable() => Player_Model.OnDamageReceived += ProcessPlayerDamage;

        void Start() => player.SetHealth(_initialPlayerHealth);

        void OnDisable() => Player_Model.OnDamageReceived -= ProcessPlayerDamage;

        public void SetPause(bool isOnPause) => _isOnPause = isOnPause;

        void ProcessPlayerDamage(float health)
        {
            if (health <= 0)
            {
                player.Die();
                Debug.Log("The player is Death");
            }
        }
    }
}