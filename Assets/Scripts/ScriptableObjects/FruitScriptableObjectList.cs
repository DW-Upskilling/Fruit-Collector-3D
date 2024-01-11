using FruitCollector3D.Components.Fruit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FruitCollector3D.ScriptableObjects
{
    [CreateAssetMenu(fileName = "FruitScriptableObjectList", menuName = "ScriptableObjects/Fruit/List")]
    public class FruitScriptableObjectList : ScriptableObject
    {   
        [SerializeField] private List<FruitScriptableObject> list;

        public FruitScriptableObject GetItem(int index)
        {
            return list[index];
        }
    }
}

