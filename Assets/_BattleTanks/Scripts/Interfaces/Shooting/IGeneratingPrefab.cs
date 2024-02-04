using UnityEngine;

namespace _BattleTanks.Scripts.Interfaces.Shooting
{
    public interface IGeneratingPrefab
    {
        public Transform FirePosition { get; }
        public T Create<T>(T o) where T : Object;
    }
}