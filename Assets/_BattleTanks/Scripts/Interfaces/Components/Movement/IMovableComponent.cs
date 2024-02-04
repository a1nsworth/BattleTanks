using UnityEngine;

namespace _BattleTanks.Scripts.Interfaces.Components.Movement
{
    public interface IMovableComponent
    {
        public void Move(Vector3 translation, Transform transform);
    }
}