using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Player;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Managers
{
    public class ServiceManager : Singleton<ServiceManager>
    {
        [SerializeField]
        private PlayerScriptableObject _playerScriptableObject;

        public PlayerService PlayerService { get; private set; }
        
        protected override void Init()
        {
            PlayerService = new PlayerService(_playerScriptableObject);
        }

        private void Start()
        {
            PlayerService.Start();
        }
    }
}
