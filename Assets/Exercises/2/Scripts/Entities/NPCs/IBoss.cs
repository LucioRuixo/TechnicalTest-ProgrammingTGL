namespace Exercise2.Entities.NPCs
{
    public interface IBoss : IEnemy
    {
        #region Combat
        void ActivateNextPhase();
        #endregion
    }
}