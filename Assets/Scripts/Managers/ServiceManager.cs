using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Player;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;

namespace FruitCollector3D.Managers
{
    public class ServiceManager : Singleton<ServiceManager>
    {
        [SerializeField]
        private PlayerScriptableObject _playerScriptableObject;

        public InputService InputService { get; private set; }
        public PlayerService PlayerService { get; private set; }
        
        protected override void Init()
        {
            InputService = new InputService();

            PlayerService = new PlayerService(_playerScriptableObject);
        }

        private void Start()
        {
            PlayerService.Start();
        }
    }
}
