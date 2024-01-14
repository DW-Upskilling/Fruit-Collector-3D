using UnityEngine;
using Cinemachine;

using FruitCollector3D.GenericClasses.MVC;
using FruitCollector3D.ScriptableObjects;
using FruitCollector3D.Services;

namespace FruitCollector3D.Components.Player
{
    public class PlayerController : Controller<PlayerModel, PlayerView, PlayerScriptableObject>
    {
        private Camera _mainCamera;

        public PlayerController(PlayerScriptableObject _scriptableObject) : base(_scriptableObject)
        {
            View.SetController(this);
        }

        public void InputController(InputData _inputData)
        {
            Transform cameraTransform = _mainCamera.transform;

            Vector3 offset = Vector3.zero;
            if (_inputData.horizontal >= .2f || _inputData.horizontal <= -.2f)
                offset.x = _inputData.horizontal ;
            if (_inputData.vertical >= .2f || _inputData.vertical <= -.2f)
                offset.z = _inputData.vertical;

            Vector3 direction = offset.normalized;        
            if (direction.magnitude >= .1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;

                Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
                View.UpdatePosition(moveDirection.normalized * Model.ScriptableObject.Speed);
            }
        }

        public void SetFreeLookCamera(CinemachineFreeLook _cinemachineFreeLook)
        {
            _cinemachineFreeLook.Follow = View.gameObject.transform;
            _cinemachineFreeLook.LookAt = View.gameObject.transform;
        }

        public void SetMainCamera(Camera _mainCamera) => this._mainCamera = _mainCamera;

        public override PlayerModel CreateModel(PlayerScriptableObject _scriptableObject) => new PlayerModel(_scriptableObject);
        public override PlayerView InstantiateView(PlayerScriptableObject _scriptableObject) => GameObject.Instantiate<PlayerView>(_scriptableObject.Prefab, Vector3.zero, Quaternion.identity);
    }
}

