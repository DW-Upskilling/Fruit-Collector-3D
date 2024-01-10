using UnityEngine;

namespace FruitCollector3D.GenericClasses.MVC
{
    public abstract class View : MonoBehaviour 
    {
        
    }

    public abstract class View<T> : View where T : class
    {
        public T Controller { get; private set; }

        public abstract void SetController(T _controller);
    }
}
