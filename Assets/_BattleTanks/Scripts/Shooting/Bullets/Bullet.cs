using _BattleTanks.Scripts.Interfaces;
using UnityEngine;

namespace _BattleTanks.Scripts.Shooting.Bullets
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Bullet : MonoBehaviour
    {
        #region UnityEditorVariables

        [field: SerializeField] public int Damage { get; protected set; }

        #endregion

        #region Components

        private Rigidbody2D _rigidbody2D;

        #endregion

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            var damaging = other.gameObject.GetComponent<IDamaging>();
            damaging?.TakeDamage(Damage);

            Destroy(gameObject);
        }

        public virtual void Launch(Vector3 dir, float speed)
        {
            _rigidbody2D.velocity = dir * speed;
        }
    }
}