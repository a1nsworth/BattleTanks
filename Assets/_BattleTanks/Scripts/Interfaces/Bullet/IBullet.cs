using UnityEngine;

namespace _BattleTanks.Scripts.Interfaces.Bullet
{
    public interface IBullet
    {
        public void Launch(Vector3 dir, float speed);
    }
}