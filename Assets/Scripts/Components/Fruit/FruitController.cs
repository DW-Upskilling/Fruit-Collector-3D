using FruitCollector3D.Components.Player;
using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;
using UnityEngine;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitController : Controller<FruitModel, FruitView, FruitScriptableObject>
    {
        public FruitController(FruitScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            Init(_scriptableObject);
        }

        public void Init(FruitScriptableObject _scriptableObject)
        {
            Model.Init(_scriptableObject);
            View.Init(_scriptableObject);
        }

        public override FruitModel CreateModel(FruitScriptableObject _scriptableObject) => new FruitModel(_scriptableObject);
        public override FruitView InstantiateView(FruitScriptableObject _scriptableObject) => GameObject.Instantiate<FruitView>(_scriptableObject.Prefab, Vector3.zero, Quaternion.identity);
    }
}
