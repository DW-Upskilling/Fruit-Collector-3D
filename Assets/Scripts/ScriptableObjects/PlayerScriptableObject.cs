using FruitCollector3D.Components.Player;
using UnityEngine;

namespace FruitCollector3D.ScriptableObjects
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObjects/Player/New")]
    public class PlayerScriptableObject : ScriptableObject
    {
        [SerializeField] public PlayerView Prefab;

        [SerializeField, Range(.1f,10f)] public float Speed;
    }
}
