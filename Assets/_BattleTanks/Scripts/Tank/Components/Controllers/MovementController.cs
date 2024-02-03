using System;
using _BattleTanks.Scripts.Enums.Movement;
using _BattleTanks.Scripts.InputSystem;
using _BattleTanks.Scripts.Interfaces.Components.Input.Composite;
using _BattleTanks.Scripts.Tank.Components.Movement;
using _BattleTanks.Scripts.Tank.Components.ProvidersAndUpdaters.Movement;
using UnityEngine;
using ComponentInput = _BattleTanks.Scripts.Interfaces.Components.Input;
using ComponentMovement = _BattleTanks.Scripts.Interfaces.Components.Movement;

namespace _BattleTanks.Scripts.Tank.Components.Controllers
{
    public class MovementController : MonoBehaviour, IMovementController
    {
        #region UnitEditorVariables

        [field: SerializeField] public float MovementSpeed { get; private set; }
        [field: SerializeField] public float RotationSpeed { get; private set; }

        #endregion

        private Transform _transform;

        #region Components

        private ComponentMovement.IMovableComponent _movableComponent;
        private ComponentMovement.IRotatableComponent _rotatableComponent;

        private ComponentInput.Movement.IDirectionUpdaterAndProvider _movementDirectionProviderAndUpdater;
        private ComponentInput.Rotation.IDirectionUpdaterAndProvider _rotationDirectionProviderAndUpdater;

        #endregion

        private GlobalInputActions _inputAction;


        #region MonoBehaviourMethods

        private void Awake()
        {
            _inputAction = new GlobalInputActions();
        }

        private void OnEnable()
        {
            _inputAction.Enable();
        }

        private void OnDisable()
        {
            _inputAction.Disable();
        }

        private void Start()
        {
            var tr = transform;
            _movableComponent = new MovementComponent(tr);
            _rotatableComponent = new RotationComponent(tr);

            _transform = GetComponent<Transform>();

            _movementDirectionProviderAndUpdater =
                new DirectionProviderAndUpdater(_inputAction.Tank.Movement);
            _rotationDirectionProviderAndUpdater =
                new ProvidersAndUpdaters.Rotation.DirectionProviderAndUpdater(_inputAction.Tank.Rotation);
        }

        #endregion
        
        public void Update(float deltaTime)
        {
            _movementDirectionProviderAndUpdater.Update();
            _rotationDirectionProviderAndUpdater.Update();
            if (_movementDirectionProviderAndUpdater.Direction != Direction.NonMoving)
                _movableComponent.Move(new Vector3(0,
                    (float)_movementDirectionProviderAndUpdater.Direction * MovementSpeed * deltaTime, 0), _transform);

            if (_rotationDirectionProviderAndUpdater.Direction != Enums.Rotation.Direction.NonRotating)
                _rotatableComponent.Rotate(new Vector3(0, 0,
                    (float)_rotationDirectionProviderAndUpdater.Direction * RotationSpeed * deltaTime), _transform);
        }
    }
}