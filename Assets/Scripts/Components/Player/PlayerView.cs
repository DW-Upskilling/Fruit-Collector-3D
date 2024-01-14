using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.Interfaces;

namespace FruitCollector3D.Components.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : View<PlayerController>, IPlayer
    {
        private float smoothRotationTime;

        public void UpdatePosition(Vector3 _offsetPosition) {
            Vector3 currPosition = this.gameObject.transform.position;

            Vector3 newPosition = currPosition + _offsetPosition * Time.deltaTime;

            this.gameObject.transform.position = newPosition;
        }

        public void Collision(IVoid _void)
        {
            this.gameObject.transform.position = Vector3.zero;
        }
    }
}
