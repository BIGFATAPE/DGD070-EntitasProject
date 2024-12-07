using Entitas;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    readonly GameContext _context;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        var playerEntity = _context.GetGroup(GameMatcher.PlayerHealth).GetSingleEntity();
        if (playerEntity == null) return;

        if (playerEntity.hasPlayerHealed)
        {
            playerEntity.ReplacePlayerHealth(Mathf.Min(playerEntity.playerHealth.Value + 10, 100));
            playerEntity.isPlayerHealed = false;
        }

        if (playerEntity.hasPlayerDamaged)
        {
            playerEntity.ReplacePlayerHealth(Mathf.Max(playerEntity.playerHealth.Value - 10, 0));
            playerEntity.isPlayerDamaged = false;
        }
    }
}