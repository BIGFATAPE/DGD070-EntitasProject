namespace Systems
{
    public class PlayerHealthFeature : Feature
    {
        public PlayerHealthFeature(Contexts contexts) : base("Player Health")
        {
            Add(new CreatePlayerHealthSystem(contexts));
            Add(new CheckPlayerHealthSystem(contexts));
            Add(new ChangePlayerHealthSystem(contexts));
        }
    }
}