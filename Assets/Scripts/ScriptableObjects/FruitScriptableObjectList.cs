using FruitCollector3D.Components.Fruit;
using System.Collections.Generic;
using UnityEngine;

namespace FruitCollector3D.ScriptableObjects
{
    [CreateAssetMenu(fileName = "FruitScriptableObjectList", menuName = "ScriptableObjects/Fruit/List")]
    public class FruitScriptableObjectList : ScriptableObject
    {
        [SerializeField] private Vector3 minPosition;
        [SerializeField] private Vector3 maxPosition;

        [SerializeField] private List<FruitScriptableObject> list;

        public FruitScriptableObject GetItem(int _index)
        {
            return list[_index];
        }

        public List<FruitScriptableObject> GetItems(FruitTypes _fruitType)
        {
            return list.FindAll(e=> e.Type == _fruitType);
        }

    }
}

