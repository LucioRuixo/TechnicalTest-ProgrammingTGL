using UnityEngine;

namespace Exercise2.Entities.Player
{
    public class Player_Controller : MonoBehaviour
    {
        Player_Model model;

        void Awake() => model = GetComponent<Player_Model>();

        public void Jump()
        {
            if (model.CurrentMovementState == Player_Model.MovementState.Grounded)
            {
                //TODO Jump
            }
        }

        public void SetHealth(float health) => model.SetHealth(health);

        public void ReceiveDamage(float damage) => model.ReceiveDamage(damage);

        public void Die()
        {
            //TODO Death
        }
    }
}