using _BattleTanks.Scripts.Interfaces.Shooting;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank.Components.Shooting
{
    public class LauncherBullet : ILaunchingPrefab
    {
        public void Launch(Vector3 dir, float speed, Rigidbody2D rb)
        {
            rb.velocity = dir * speed;
        }
    }
}