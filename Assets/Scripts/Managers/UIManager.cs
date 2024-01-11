using UnityEngine;

using FruitCollector3D.GenericClasses;
using FruitCollector3D.Components.Fruit;

namespace FruitCollector3D.Managers
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private Transform SelectionPanel;
        [SerializeField] private Transform ScorePanel;
        [SerializeField] private FruitSelectable FruitSelectablePrefab;
        [SerializeField] private int MaxFruits;
        
        protected override void Init()
        {
            for (int i = 0; i < MaxFruits; i++)
            {
                CreateFruitSelectableGameObject();
            }
        }

        public void CreateFruitSelectableGameObject()
        {
            GameObject.Instantiate<FruitSelectable>(FruitSelectablePrefab, Vector3.zero, Quaternion.identity, SelectionPanel);
        }
    }
}
