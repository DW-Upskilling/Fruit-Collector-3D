using UnityEngine;

namespace FruitCollector3D.GenericClasses.MVC
{
    public abstract class Controller
    {

    }

    public abstract class Controller<M, V> : Controller where M : Model where V : View
    {
        public M Model { get; private set; }
        public V View { get; private set; }

        public Controller()
        {
            this.Model = CreateModel();
            this.View = InstantiateView();
        }

        public abstract M CreateModel();
        public abstract V InstantiateView();
    }

    public abstract class Controller<M, V, S> : Controller where M: Model where V: View where S: ScriptableObject
    {
        public M Model { get; private set; }
        public V View { get; private set; }

        public Controller(S _scriptableObject)
        {
            this.Model = CreateModel(_scriptableObject);
            this.View = InstantiateView(_scriptableObject);
        }

        public abstract M CreateModel(S _scriptableObject);
        public abstract V InstantiateView(S _scriptableObject);
    }
    
}