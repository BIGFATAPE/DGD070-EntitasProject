//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Components;

public partial class GameEntity {

    static readonly PlayerDamagedComponent playerDamagedComponent = new PlayerDamagedComponent();

    public bool isPlayerDamaged {
        get { return HasComponent(GameComponentsLookup.PlayerDamaged); }
        set {
            if (value != isPlayerDamaged) {
                var index = GameComponentsLookup.PlayerDamaged;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : playerDamagedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerDamaged;

    public static Entitas.IMatcher<GameEntity> PlayerDamaged {
        get {
            if (_matcherPlayerDamaged == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerDamaged);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerDamaged = matcher;
            }

            return _matcherPlayerDamaged;
        }
    }
}