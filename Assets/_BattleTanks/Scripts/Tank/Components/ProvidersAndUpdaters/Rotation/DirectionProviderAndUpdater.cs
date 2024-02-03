using _BattleTanks.Scripts.Enums.Rotation;
using UnityEngine;
using UnityEngine.InputSystem;
using ComponentsInput = _BattleTanks.Scripts.Interfaces.Components.Input;

namespace _BattleTanks.Scripts.Tank.Components.ProvidersAndUpdaters.Rotation
{
    public class DirectionProviderAndUpdater : ComponentsInput.Rotation.IDirectionUpdaterAndProvider
    {
        public Direction Direction { get; private set; }

        private readonly InputAction _inputAction;

        public DirectionProviderAndUpdater(InputAction inputAction)
        {
            _inputAction = inputAction;
        }

        public void Update()
        {
            Direction = (Direction)_inputAction.ReadValue<float>();
        }
    }
}