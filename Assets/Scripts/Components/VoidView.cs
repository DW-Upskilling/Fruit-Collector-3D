using FruitCollector3D.Interfaces;
using FruitCollector3D.GenericClasses.MVC;
using UnityEngine;

namespace FruitCollector3D.Components
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshCollider), typeof(MeshRenderer))]
    public class VoidView : View, IVoid
    {
        private void Start()
        {
            MeshCollider meshCollider = this.gameObject.GetComponent<MeshCollider>();
            meshCollider.convex = true;
            meshCollider.isTrigger = false;
        }

        private void OnCollisionEnter(Collision collider)
        {
            GameObject _gameObject = collider.gameObject;

            IFruit ifruit = _gameObject.GetComponent<IFruit>();
            if (ifruit != null)
            {
                ifruit.Collision(this);
                return;
            }

            IPlayer iplayer = _gameObject.GetComponent<IPlayer>();
            if (iplayer != null)
            {
                iplayer.Collision(this);
            }
        }
    }
}
