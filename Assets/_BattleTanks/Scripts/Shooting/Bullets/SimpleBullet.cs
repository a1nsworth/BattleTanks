using _BattleTanks.Scripts.Interfaces;
using UnityEngine;

namespace _BattleTanks.Scripts.Shooting.Bullets
{
    public class SimpleBullet : Bullet
    {
        protected override void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Bullet collision");
            var damaging = other.gameObject.GetComponent<IDamagable>();
            damaging?.TakeDamage(Damage);

            Destroy(gameObject);
        }
    }
}