using System;

namespace FruitCollector3D.GenericClasses
{
    public abstract class Observer
    {
        private event Action observerQueue;

        public void AddListener(Action listener)
        {
            observerQueue += listener;
        }

        public void RemoveListener(Action listener)
        {
            observerQueue -= listener;
        }

        protected void TriggerEvent()
        {
            observerQueue?.Invoke();
        }
    }

    public abstract class Observer<T>
    {
        private event Action<T> observerQueue;

        public void AddListener(Action<T> listener)
        {
            observerQueue += listener;
        }

        public void RemoveListener(Action<T> listener)
        {
            observerQueue -= listener;
        }

        protected void TriggerEvent(T data)
        {
            observerQueue?.Invoke(data);
        }
    }
}