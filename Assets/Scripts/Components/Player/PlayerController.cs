using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;

namespace FruitCollector3D.Components.Player
{
    public class PlayerController : Controller<PlayerModel, PlayerView, PlayerScriptableObject>
    {
        public PlayerController(PlayerScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            View.SetController(this);
        }

        public void InputController(InputData _inputData)
        {
            Vector3 position = Vector3.zero;
            if(_inputData.horizontal >= .2f || _inputData.horizontal <= -.2f) 
                position.x = _inputData.horizontal * Model.ScriptableObject.Speed;
            if (_inputData.vertical >= .2f || _inputData.vertical <= -.2f) 
                position.z = _inputData.vertical * Model.ScriptableObject.Speed;

            View.UpdatePosition(position);
        }

        public override PlayerModel CreateModel(PlayerScriptableObject _scriptableObject) => new PlayerModel(_scriptableObject);
        public override PlayerView InstantiateView(PlayerScriptableObject _scriptableObject) => GameObject.Instantiate<PlayerView>(_scriptableObject.Prefab, Vector3.zero, Quaternion.identity);
    }
}

