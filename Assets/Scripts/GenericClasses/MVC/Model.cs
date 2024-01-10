using UnityEngine;

namespace FruitCollector3D.GenericClasses.MVC
{
    public abstract class Model
    {

    }

    public abstract class Model<T> : Model where T: ScriptableObject
    {
        public T ScriptableObject { get; private set; }
        public Model(T _scriptableObject)
        {
            this.ScriptableObject = _scriptableObject;
        }
    }
}