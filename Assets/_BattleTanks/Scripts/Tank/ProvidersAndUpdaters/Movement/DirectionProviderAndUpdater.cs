using _BattleTanks.Scripts.Enums.Movement;
using UnityEngine;
using UnityEngine.InputSystem;
using ComponentsInput = _BattleTanks.Scripts.Interfaces.Components.Input;

namespace _BattleTanks.Scripts.Tank.Components.ProvidersAndUpdaters.Movement
{
    public class DirectionProviderAndUpdater : ComponentsInput.Movement.IDirectionUpdaterAndProvider
    {
        public Direction Direction { get; private set; }

        private readonly InputAction _inputAction;

        public DirectionProviderAndUpdater(InputAction inputAction)
        {
            _inputAction = inputAction;
        }

        public void Update()
        {
            Direction = (Direction)_inputAction.ReadValue<Vector2>().y;
        }
    }
}