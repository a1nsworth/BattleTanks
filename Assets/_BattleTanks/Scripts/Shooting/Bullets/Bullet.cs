using System;
using _BattleTanks.Scripts.Interfaces;
using _BattleTanks.Scripts.Interfaces.Bullet;
using UnityEngine;

namespace _BattleTanks.Scripts.Shooting.Bullets
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class Bullet : MonoBehaviour, IBullet
    {
        #region UnityEditorVariables

        [field: SerializeField] public int Damage { get; protected set; }

        #endregion

        #region Components

        public Rigidbody2D Rigidbody2D { get; private set; }

        #endregion

        private void Awake()
        {
            Rigidbody2D = GetComponent<Rigidbody2D>();
        }

        protected abstract void OnTriggerEnter2D(Collider2D other);

        public virtual void Launch(Vector3 dir, float speed)
        {
            Rigidbody2D.velocity = dir * speed;
        }
    }
}