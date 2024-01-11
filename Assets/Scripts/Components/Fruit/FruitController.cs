using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;
using UnityEngine;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitController : Controller<FruitModel, FruitView, FruitScriptableObject>
    {
        public FruitPool FruitPool { get; set; }

        public FruitController(FruitScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            View.SetController(this);

            Activate(_scriptableObject);
        }

        public void Activate(FruitScriptableObject _scriptableObject)
        {
            Model.Activate(_scriptableObject);
            View.gameObject.SetActive(true);
            View.Activate(_scriptableObject, Vector3.zero);
        }

        public void Deactivate()
        {
            View.gameObject.SetActive(false);

            FruitPool.ReturnItem(this);
        }

        public override FruitModel CreateModel(FruitScriptableObject _scriptableObject) => new FruitModel(_scriptableObject);
        public override FruitView InstantiateView(FruitScriptableObject _scriptableObject) => GameObject.Instantiate<FruitView>(_scriptableObject.Prefab, Vector3.zero, Quaternion.identity);
    }
}
