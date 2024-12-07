using Entitas;

public class CreatePlayerHealthSystem : IInitializeSystem
{
    readonly GameContext _context;

    public CreatePlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Initialize()
    {
        var e = _context.CreateEntity();
        e.AddPlayerHealth(100f);
    }
}