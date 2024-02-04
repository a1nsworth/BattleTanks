using UnityEngine;

namespace _BattleTanks.Scripts.Interfaces.Shooting

{
    public interface ILaunchingPrefab
    {
        public void Launch(Vector3 dir, float speed, Rigidbody2D rb);
    }
}