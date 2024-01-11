using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitService : Service
    {
        private FruitScriptableObjectList _fruitScriptableObjectList;

        private FruitPool fruitPool;

        public FruitService(FruitScriptableObjectList _scriptableObjectList) {
            _fruitScriptableObjectList = _scriptableObjectList;

            fruitPool = new FruitPool(_fruitScriptableObjectList.GetItem(0));
        }

        public override void Start()
        {
            fruitPool.GetItem().Init(_fruitScriptableObjectList.GetItem(1));
        }
    }
}
