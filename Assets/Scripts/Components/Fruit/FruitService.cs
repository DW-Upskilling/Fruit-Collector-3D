using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Fruit
{
    public class FruitService : Service
    {
        private FruitScriptableObjectList _fruitScriptableObjectList;

        private FruitPool fruitPool;

        public FruitService(FruitScriptableObjectList _scriptableObjectList) {
            _fruitScriptableObjectList = _scriptableObjectList;
        }

        public override void Start()
        {
            fruitPool = new FruitPool(_fruitScriptableObjectList.GetItem(0));
        }

        public void SpawnFruit(FruitTypes _fruitType)
        {
            List<FruitScriptableObject> fruitScriptableObjects = _fruitScriptableObjectList.GetItems(_fruitType);
            if (fruitScriptableObjects.Count < 1) return;

            fruitPool.GetItem().Activate(fruitScriptableObjects[Random.Range(0, fruitScriptableObjects.Count - 1)]);
        }
    }
}
