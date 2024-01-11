using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;
using UnityEngine;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitModel : Model<FruitScriptableObject>
    {
        public FruitModel(FruitScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            Init(_scriptableObject);
        }

        public void Init(FruitScriptableObject _scriptableObject)
        {
            this.ScriptableObject = _scriptableObject;
        }
    }
}
