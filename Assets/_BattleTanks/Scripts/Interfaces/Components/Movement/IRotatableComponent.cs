using UnityEngine;

namespace _BattleTanks.Scripts.Interfaces.Components.Movement
{
    public interface IRotatableComponent
    {
        public void Rotate(Vector3 euler, Transform transform);
    }
}