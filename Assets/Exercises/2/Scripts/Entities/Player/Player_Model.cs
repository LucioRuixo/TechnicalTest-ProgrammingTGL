using System;
using UnityEngine;

namespace Exercise2.Entities.Player
{
    public class Player_Model : MonoBehaviour
    {
        public enum MovementState
        {
            Grounded,
            InAir
        }

        float _health;
        MovementState _currentMovementState;

        public float Health { get { return _health; } }
        public MovementState CurrentMovementState { get { return _currentMovementState; } }

        public static event Action<float> OnDamageReceived;

        public void SetHealth(float health) => _health = health;

        public void ReceiveDamage(float damage)
        {
            _health -= damage;
            OnDamageReceived?.Invoke(_health);
        }
    }
}