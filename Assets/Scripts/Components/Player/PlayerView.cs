using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.Interfaces;

namespace FruitCollector3D.Components.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : View<PlayerController>, IPlayer
    {

    }
}
