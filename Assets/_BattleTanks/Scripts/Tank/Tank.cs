using _BattleTanks.Scripts.Interfaces.Components.Input.Composite;
using _BattleTanks.Scripts.Tank.Components;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank
{
    [RequireComponent(typeof(IMovementController))]
    [RequireComponent(typeof(HealthComponent))]
    public class Tank : MonoBehaviour
    {
        private IMovementController _movementController;
        private HealthComponent _healthComponent;

        private void Start()
        {
            _movementController = GetComponent<IMovementController>();
            _healthComponent = GetComponent<HealthComponent>();

            _healthComponent.Die += OnDieHandler;
        }

        private void Update()
        {
            _movementController.Update(Time.deltaTime);
        }

        private void OnDestroy()
        {
            _healthComponent.Die -= OnDieHandler;
        }

        private void OnDieHandler()
        {
            Destroy(this);
        }
    }
}