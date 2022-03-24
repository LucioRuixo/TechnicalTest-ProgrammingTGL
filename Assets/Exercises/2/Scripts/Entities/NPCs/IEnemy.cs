namespace Exercise2.Entities.NPCs
{
    public interface IEnemy : INPC
    {
        #region Combat
        void Attack();
        #endregion

        #region Health
        void RegenerateLife();
        void Die();
        #endregion
    }
}