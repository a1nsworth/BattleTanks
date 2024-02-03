using _BattleTanks.Scripts.Interfaces;
using UnityEngine;

namespace _BattleTanks.Scripts.Tank.Components
{
    public sealed class HealthComponent : MonoBehaviour, IDamaging
    {
        #region UnityEditorVariables

        [field: SerializeField] public int Health { get; private set; } = 100;
        [field: SerializeField] public int Life { get; private set; } = 5;

        #endregion

        public void TakeDamage(int damage)
        {
            throw new System.NotImplementedException();
        }
    }
}