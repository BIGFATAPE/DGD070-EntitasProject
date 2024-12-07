using Entitas;
using UnityEngine;

namespace Systems
{
    public class ChangePlayerHealthSystem : IExecuteSystem
    {
        readonly GameContext _context;

        public ChangePlayerHealthSystem(Contexts contexts)
        {
            _context = contexts.game;
        }

        public void Execute()
        {
            var playerEntity = _context.GetGroup(GameMatcher.PlayerHealth).GetSingleEntity();
            if (playerEntity == null) return;

            if (Input.GetKeyDown(KeyCode.D))
            {
                playerEntity.isPlayerDamaged = true;
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                playerEntity.isPlayerHealed = true;
            }
        }
    }
}