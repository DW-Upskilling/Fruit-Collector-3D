using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.Interfaces;
using FruitCollector3D.ScriptableObjects;
using UnityEngine;

namespace FruitCollector3D.Components.Fruit
{
    [RequireComponent(typeof(Rigidbody)), RequireComponent(typeof(MeshFilter), typeof(MeshCollider), typeof(MeshRenderer))]
    public class FruitView : View<FruitController>, IFruit
    {
        private MeshCollider meshCollider;
        private MeshFilter meshFilter;
        private MeshRenderer meshRenderer;

        private float timeLeft;
        private bool isReady;

        private void Awake()
        {
            meshCollider = this.gameObject.GetComponent<MeshCollider>();
            meshFilter = this.gameObject.GetComponent<MeshFilter>();
            meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        }

        public void Activate(FruitScriptableObject _scriptableObject, Vector3 _position)
        {
            meshCollider.sharedMesh = _scriptableObject.MeshFilter.sharedMesh;
            meshFilter.sharedMesh = _scriptableObject.MeshFilter.sharedMesh;
            meshRenderer.sharedMaterials = _scriptableObject.MeshRenderer.sharedMaterials;

            this.gameObject.transform.position = _position;

            timeLeft = _scriptableObject.TimeToLiveSeconds;
            isReady = false;
        }

        public void Collision(IBasket _basket)
        {
            // if(isReady)
                Controller.Deactivate();
        }

        public void Collision(IPlayer _player)
        {
            isReady = true;
        }

        private void Update()
        {
            timeLeft -= Time.deltaTime;
            if(timeLeft <= 0) {
                Controller.Deactivate();
            }
        }
    }
}
