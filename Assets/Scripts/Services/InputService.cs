using UnityEngine;

using FruitCollector3D.GenericClasses;

namespace FruitCollector3D.Services
{
    public class InputService : Observer<InputData>
    {
        private Joystick _joystick;

        public InputService(Joystick _joystick) { 
            this._joystick = _joystick;
        }

        public void Update()
        {
            InputData inputData = new InputData();

            inputData.horizontal = _joystick.Horizontal;
            inputData.vertical = _joystick.Vertical;
            
            if (inputData.horizontal != 0 || inputData.vertical != 0)
               TriggerEvent(inputData);
            else
            {
                inputData.horizontal = Input.GetAxisRaw("Horizontal");
                inputData.vertical = Input.GetAxisRaw("Vertical");

                if (inputData.horizontal != 0 || inputData.vertical != 0)
                    TriggerEvent(inputData);
            }
        }
    }

    public struct InputData {
        public float horizontal;
        public float vertical;
    };
}
