using UnityEngine;

namespace _BattleTanks.Scripts.Shooting
{
    public class ShotManager : MonoBehaviour
    {
        #region UnityEditorVariables

        [field: SerializeField] public float BulletSpeed { get; protected set; } = 1;

        #endregion

        private GameObject _firePoint;
        private Bullets.Bullet _bullet;

        public void Fire()
        {
            _bullet?.Launch(_firePoint.transform.right, BulletSpeed);
        }
    }
}