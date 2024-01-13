using UnityEngine;

using FruitCollector3D.Interfaces;
using FruitCollector3D.GenericClasses.MVC;

namespace FruitCollector3D.Components.Basket
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshCollider), typeof(MeshRenderer))]
    public class BasketView : View, IBasket
    {
        private void Start()
        {
            MeshCollider meshCollider = this.gameObject.GetComponent<MeshCollider>();
            meshCollider.convex = true;
            meshCollider.isTrigger = true;
        }

        private void OnTriggerEnter(Collider collision)
        {
            GameObject _gameObject = collision.gameObject;

            Debug.Log(_gameObject.name);
            IFruit ifruit = _gameObject.GetComponent<IFruit>();
            if(ifruit != null)
            {
                ifruit.Collision(this);
            }
        }
    }
}
