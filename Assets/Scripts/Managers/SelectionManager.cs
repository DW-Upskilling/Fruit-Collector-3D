using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Player;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;

namespace FruitCollector3D.Managers
{
    public class SelectionManager : Singleton<SelectionManager>
    {
        [SerializeField]
        private VerticalLayoutGroup SelectionPanel;
        
        protected override void Init()
        {
            
        }

        private void Start()
        {
            
        }
    }
}
