using _BattleTanks.Scripts.Interfaces.Components.Movement;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank.Components.Movement
{
    public class MovementComponent : IMovableComponent
    {
        private readonly Transform _transform;

        public MovementComponent(Transform transform)
        {
            _transform = transform;
        }

        public void Move(Vector3 translation, Transform transform)
        {
            transform.Translate(translation);
        }
    }
}