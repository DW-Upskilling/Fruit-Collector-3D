using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using FruitCollector3D.Managers;

namespace FruitCollector3D.Components.Fruit
{
    [RequireComponent(typeof(Button))]
    public class FruitSelectable : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private TextMeshProUGUI text;

        private UIManager uiManager;
        private FruitService fruitService;

        private Button button;
        private FruitTypes fruitType;
        
        private void Awake()
        {
            button = this.gameObject.GetComponent<Button>();

            uiManager = UIManager.Instance;
            fruitService = ServiceManager.Instance.FruitService;
        }

        private void Start()
        {
            Array values = Enum.GetValues(typeof(FruitTypes));
            System.Random random = new System.Random();
            fruitType = (FruitTypes)values.GetValue(random.Next(values.Length));

            text.text = fruitType.ToString();

            button.onClick.AddListener(TriggerSpawnEvent);
        }

        private void OnDestroy()
        {
            button.onClick.RemoveAllListeners();
        }

        private void TriggerSpawnEvent()
        {
            fruitService.SpawnFruit(fruitType);

            uiManager.CreateFruitSelectableGameObject();

            Destroy(this.gameObject);
        }
    }
}
