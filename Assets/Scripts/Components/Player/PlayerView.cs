using UnityEngine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.Interfaces;

namespace FruitCollector3D.Components.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerView : View<PlayerController>, IPlayer
    {
        private float smoothRotationTime;

        private void OnCollisionEnter(Collision collider)
        {
            GameObject _gameObject = collider.gameObject;

            IFruit ifruit = _gameObject.GetComponent<IFruit>();
            if (ifruit != null)
            {
                ifruit.Collision(this);
                return;
            }
        }

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
