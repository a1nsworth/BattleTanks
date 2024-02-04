using System;
using _BattleTanks.Scripts.Interfaces;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank.Components
{
    public class HealthController : MonoBehaviour, IDamagable
    {
        public bool IsDie => Health == 0 && Life == 0;

        private int _baseHealth;

        #region UnityEditorVariables

        [field: SerializeField]
        [field: Min(1)]
        public int Health { get; private set; } = 100;

        [field: SerializeField]
        [field: Min(1)]
        public int Life { get; private set; } = 5;

        #endregion

        public void Start()
        {
            _baseHealth = Health;
        }

        public delegate void GettingDamageHandler(int damage, int remainingHealth);

        public delegate void LossingLifeHandler(int remainingLife);

        public event GettingDamageHandler GettingDamage;
        public event LossingLifeHandler LossingLife;
        public event Action Die;

        private void UseLife()
        {
            if (Life <= 0)
                throw new ArgumentException("Cannot use life, because life equal zero" +
                                            "Expected: Life > 0" +
                                            $"Actual: Life = {Life}");

            Health = _baseHealth;
            Life--;

            LossingLife?.Invoke(Life);
        }

        public void TakeDamage(int damage)
        {
            if (Health <= damage && Life == 0)
            {
                Health = 0;

                GettingDamage?.Invoke(damage, Health);
                Die?.Invoke();
            }
            else if (Life != 0)
            {
                Health -= damage;
                if (Health <= 0)
                {
                    UseLife();
                }

                GettingDamage?.Invoke(damage, Health);
            }
        }
    }
}