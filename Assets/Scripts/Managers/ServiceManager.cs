using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Player;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;
using FruitCollector3D.Components.Fruit;

namespace FruitCollector3D.Managers
{
    public class ServiceManager : Singleton<ServiceManager>
    {
        [SerializeField] private PlayerScriptableObject _playerScriptableObject;
        [SerializeField] private FruitScriptableObjectList _fruitScriptableObjectList;

        public InputService InputService { get; private set; }
        public PlayerService PlayerService { get; private set; }
        public FruitService FruitService { get; private set; }
        
        protected override void Init()
        {
            InputService = new InputService();

            PlayerService = new PlayerService(_playerScriptableObject);
            FruitService = new FruitService(_fruitScriptableObjectList);
        }

        private void Start()
        {
            PlayerService.Start();
            FruitService.Start();
        }
    }
}
