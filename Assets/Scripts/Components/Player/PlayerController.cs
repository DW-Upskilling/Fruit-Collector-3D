using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Player
{
    public class PlayerController : Controller<PlayerModel, PlayerView, PlayerScriptableObject>
    {
        public PlayerController(PlayerScriptableObject _scriptableObject) : base(_scriptableObject)
        {

        }

        public override PlayerModel CreateModel(PlayerScriptableObject _scriptableObject)
        {
            throw new System.NotImplementedException();
        }

        public override PlayerView InstantiateView(PlayerScriptableObject _scriptableObject)
        {
            throw new System.NotImplementedException();
        }
    }
}

