using UnityEngine;

namespace FruitCollector3D.Interfaces
{
    public interface IFruit
    {
        public abstract void Collision(IBasket _player);
        public abstract void Collision(IPlayer _player);
    }
}
