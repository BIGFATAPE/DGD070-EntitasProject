//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentLookupGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Components;

public static class GameComponentsLookup {

    public const int PlayerDamaged = 0;
    public const int PlayerHealed = 1;
    public const int PlayerHealth = 2;

    public const int TotalComponents = 3;

    public static readonly string[] componentNames = {
        "PlayerDamaged",
        "PlayerHealed",
        "PlayerHealth"
    };

    public static readonly System.Type[] componentTypes = {
        typeof(PlayerDamagedComponent),
        typeof(PlayerHealedComponent),
        typeof(PlayerHealthComponent)
    };
}