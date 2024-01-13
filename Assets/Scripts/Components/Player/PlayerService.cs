using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Player
{
    public class PlayerService : Service
    {
        private PlayerScriptableObject _playerScriptableObject;

        private PlayerController playerController;

        public PlayerService(PlayerScriptableObject _scriptableObject) {
            _playerScriptableObject = _scriptableObject;
        }

        public override void Start()
        {
            playerController = new PlayerController(_playerScriptableObject);
        }
    }
}
