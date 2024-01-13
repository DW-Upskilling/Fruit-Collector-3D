using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Player
{
    public class PlayerController : Controller<PlayerModel, PlayerView, PlayerScriptableObject>
    {
        public PlayerController(PlayerScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            View.SetController(this);
        }

        public override PlayerModel CreateModel(PlayerScriptableObject _scriptableObject) => new PlayerModel(_scriptableObject);
        public override PlayerView InstantiateView(PlayerScriptableObject _scriptableObject) => GameObject.Instantiate<PlayerView>(_scriptableObject.Prefab, Vector3.zero, Quaternion.identity);
    }
}

