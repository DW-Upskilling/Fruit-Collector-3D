using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitModel : Model<FruitScriptableObject>
    {
        public FruitModel(FruitScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            Activate(_scriptableObject);
        }

        public void Activate(FruitScriptableObject _scriptableObject)
        {
            this.ScriptableObject = _scriptableObject;
        }
    }
}
