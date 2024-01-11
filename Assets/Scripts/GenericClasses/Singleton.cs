using UnityEngine;

namespace FruitCollector3D.GenericClasses
{
    public abstract class Singleton<T> : MonoBehaviour where T: Singleton<T>
    {
        private static T instance;
        public static T Instance { get { return instance; } }

        private void Awake()
        {
            if (instance == null)
            {
                instance = (T)this;
                Init();
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        protected abstract void Init();
    }
}