using _BattleTanks.Scripts.Interfaces.Components.Input.Composite;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank
{
    [RequireComponent(typeof(IMovementController))]
    public class Tank : MonoBehaviour
    {
        private IMovementController _movementController;

        private void Start()
        {
            _movementController = GetComponent<IMovementController>();
        }

        private void Update()
        {
            _movementController.Update(Time.deltaTime);
        }
    }
}