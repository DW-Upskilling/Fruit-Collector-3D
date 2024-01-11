using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;

namespace FruitCollector3D.Components.Player
{
    public class PlayerModel : Model<PlayerScriptableObject>
    {
        public PlayerModel(PlayerScriptableObject _scriptableObject) : base(_scriptableObject)
        {

        }
    }
}
