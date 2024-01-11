using FruitCollector3D.GenericClasses;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitPool : ObjectPooling<FruitController>
    {
        private FruitScriptableObject _fruitScriptableObject;

        public FruitPool(FruitScriptableObject _scriptableObject) : base() {
            this._fruitScriptableObject = _scriptableObject;
        }

        protected override FruitController CreateItem()
        {
            FruitController fruitController = new FruitController(_fruitScriptableObject);
            fruitController.FruitPool = this;
            return fruitController;
        }
    }
}
