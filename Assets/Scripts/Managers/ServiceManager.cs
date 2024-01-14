using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Player;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;
using FruitCollector3D.Components.Fruit;
using FruitCollector3D.Components.Basket;


namespace FruitCollector3D.Managers
{
    public class ServiceManager : Singleton<ServiceManager>
    {
        [SerializeField] private PlayerScriptableObject _playerScriptableObject;
        [SerializeField] private FruitScriptableObjectList _fruitScriptableObjectList;

        [SerializeField] private Joystick _joystick;
        [SerializeField] private List<BasketView> _basketList;

        [SerializeField] private TextMeshProUGUI _scoreUI;
        [SerializeField] private Camera _mainCamera;
        [SerializeField] private CinemachineFreeLook _cinemachineFreeLook;

        public InputService InputService { get; private set; }
        public ScoreService ScoreService { get; private set; }
        public PlayerService PlayerService { get; private set; }
        public FruitService FruitService { get; private set; }
        public BasketService BasketService { get; private set; }

        protected override void Init()
        {
            InputService = new InputService(_joystick);
            ScoreService = new ScoreService(_scoreUI);

            PlayerService = new PlayerService(_playerScriptableObject);
            FruitService = new FruitService(_fruitScriptableObjectList);
            BasketService = new BasketService(_basketList);
        }

        private void Start()
        {
            PlayerService.Start();
            FruitService.Start();
            BasketService.Start();

            PlayerService.SetFreeLookCamera(_cinemachineFreeLook);
            PlayerService.SetMainCamera(_mainCamera);

            StartCoroutine(BasketService.SwitchBaskets());
        }

        private void Update()
        {
            InputService.Update();
        }

        private void OnDestroy()
        {
            StopAllCoroutines();
        }
    }
}
