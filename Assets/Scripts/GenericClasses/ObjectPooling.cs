using System;
using System.Collections.Generic;

namespace FruitCollector3D.GenericClasses
{
    public abstract class ObjectPooling<T>
    {
        private List<PoolItem<T>> pool;

        public ObjectPooling()
        {
            pool = new List<PoolItem<T>>();
        }

        public T GetItem()
        {
            PoolItem<T> poolItem = pool.Find(e => e.IsItemAvailable());
            if (poolItem == null) poolItem = createNewPoolItem();
            
            poolItem.LockItem();
            return poolItem.Item;
        }

        public void ReturnItem(T item)
        {
            PoolItem<T> poolItem = pool.Find(e => !e.IsItemAvailable() && e.Item.Equals(item));
            if(poolItem != null) poolItem.ReleaseItem();
        }

        protected abstract T CreateItem();
        private PoolItem<T> createNewPoolItem()
        {
            PoolItem<T> poolItem = new PoolItem<T>(CreateItem());
            this.pool.Add(poolItem);

            return poolItem;
        }
    }

    public class PoolItem<T> {
        public T Item { get; private set; }
        
        private bool inUse;

        public PoolItem(T item)
        {
            this.Item = item;
            inUse = false;
        }

        public bool IsItemAvailable() => !inUse;
        public void LockItem() => inUse = true;
        public void ReleaseItem() => inUse = false;

    }
}