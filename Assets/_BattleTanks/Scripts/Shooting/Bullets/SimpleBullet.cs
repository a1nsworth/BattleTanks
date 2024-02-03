using _BattleTanks.Scripts.Interfaces;
using UnityEngine;

namespace _BattleTanks.Scripts.Shooting.Bullets
{
    public class SimpleBullet : MonoBehaviour
    {
        [field: SerializeField] public int Damage { get; private set; }

        private void OnCollisionEnter2D(Collision2D other)
        {
            var damaging = other.gameObject.GetComponent<IDamaging>();
            damaging?.TakeDamage(Damage);

            Destroy(gameObject);
        }
    }
}