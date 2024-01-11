using UnityEngine;

using FruitCollector3D.Components.Fruit;

namespace FruitCollector3D.ScriptableObjects
{
    [CreateAssetMenu(fileName = "FruitScriptableObject", menuName = "ScriptableObjects/Fruit/New")]
    public class FruitScriptableObject : ScriptableObject
    {
        [SerializeField] public MeshFilter MeshFilter;

        [SerializeField] public MeshRenderer MeshRenderer;

        [SerializeField] public FruitView Prefab;

        [SerializeField] public FruitTypes Type;

        [SerializeField, Range(60f, 300f)] public float TimeToLiveSeconds;
    }
}
