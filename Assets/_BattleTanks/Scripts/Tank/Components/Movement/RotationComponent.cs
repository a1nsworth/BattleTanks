using _BattleTanks.Scripts.Interfaces.Components.Movement;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank.Components.Movement
{
    public class RotationComponent : IRotatableComponent
    {
        private readonly Transform _transform;

        public RotationComponent(Transform transform)
        {
            _transform = transform;
        }

        public void Rotate(Vector3 euler, Transform transform)
        {
            transform.Rotate(euler);
        }
    }
}