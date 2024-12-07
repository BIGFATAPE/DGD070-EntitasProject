using Systems;
using UnityEngine;

namespace Monobehavior
{
    public class PlayerHealthFeatureMono : MonoBehaviour
    {
        private PlayerHealthFeature _playerHealthFeature;

        void Start()
        {
            var contexts = Contexts.sharedInstance;
            _playerHealthFeature = new PlayerHealthFeature(contexts);
            _playerHealthFeature.Initialize();
        }

        void Update()
        {
            _playerHealthFeature.Execute();
            _playerHealthFeature.Cleanup();
        }
    }
}