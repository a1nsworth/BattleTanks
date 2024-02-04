using _BattleTanks.Scripts.Interfaces.Shooting;
using UnityEngine;
using UnityEngine.Serialization;

namespace _BattleTanks.Scripts.Tank.Components.Shooting
{
    public class GeneratorBullet : MonoBehaviour, IGeneratingPrefab
    {
        public Transform FirePosition => transform;

        public T Create<T>(T o) where T : Object
        {
            return Instantiate(o, FirePosition.position, FirePosition.rotation);
        }
    }
}