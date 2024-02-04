using _BattleTanks.Scripts.Interfaces.Components.Input.Composite;
using _BattleTanks.Scripts.Tank.Components;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank
{
    [RequireComponent(typeof(IMovementController))]
    [RequireComponent(typeof(HealthController))]
    public class Tank : MonoBehaviour
    {
        private IMovementController _movementController;
        private HealthController _healthController;

        private void Start()
        {
            _movementController = GetComponent<IMovementController>();
            _healthController = GetComponent<HealthController>();

            _healthController.Die += OnDieHandler;
        }

        private void Update()
        {
            _movementController.Update(Time.deltaTime);
        }

        private void OnDestroy()
        {
            _healthController.Die -= OnDieHandler;
        }

        private void OnDieHandler()
        {
            Destroy(gameObject);
        }
    }
}