using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Player
{
    public class PlayerService : Service
    {
        private PlayerScriptableObject playerScriptableObject;

        public PlayerService(PlayerScriptableObject _scriptableObject) {
            playerScriptableObject = _scriptableObject;
        }

        public override void Start()
        {
            throw new System.NotImplementedException();
        }
    }
}
