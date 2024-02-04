using System;
using System.Collections.Generic;
using _BattleTanks.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace _BattleTanks.Scripts.FragileWall
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class FragileWall : MonoBehaviour, IDamagable
    {
        [SerializeField] private List<Sprite> _spritesWallDestruction;

        private SpriteRenderer _spriteRenderer;
        private IEnumerator<Sprite> _enumerator;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _enumerator = _spritesWallDestruction.GetEnumerator();
        }

        public void TakeDamage(int damage)
        {
            if (_enumerator.MoveNext())
            {
                _spriteRenderer.sprite = _enumerator.Current;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}