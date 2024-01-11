using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.Interfaces;
using FruitCollector3D.ScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitView : View<FruitController>, IFruit
    {
        MeshCollider meshCollider;
        MeshFilter meshFilter;
        MeshRenderer meshRenderer;

        private void Awake()
        {
            meshCollider = this.gameObject.GetComponent<MeshCollider>();
            meshFilter = this.gameObject.GetComponent<MeshFilter>();
            meshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        }

        public void Init(FruitScriptableObject _scriptableObject)
        {
            meshCollider.sharedMesh = _scriptableObject.MeshFilter.sharedMesh;
            meshFilter.sharedMesh = _scriptableObject.MeshFilter.sharedMesh;
            meshRenderer.sharedMaterials = _scriptableObject.MeshRenderer.sharedMaterials;
        }
    }
}
