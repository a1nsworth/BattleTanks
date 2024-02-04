using _BattleTanks.Scripts.InputSystem;
using _BattleTanks.Scripts.Interfaces.Shooting;
using _BattleTanks.Scripts.Shooting.Bullets;
using _BattleTanks.Scripts.Tank.Components.Shooting;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _BattleTanks.Scripts.Tank.Components.Controllers
{
    public class ShootingController : MonoBehaviour
    {
        #region UnityEditorVariables

        [field: SerializeField] public float BulletSpeed { get; protected set; }
        [field: SerializeField] public float ShotDelay { get; protected set; }

        #endregion

        [SerializeField] private Bullet _bullet;

        #region Components

        private IGeneratingPrefab _generatingPrefab;
        private ILaunchingPrefab _launchingPrefab;

        #endregion


        #region LocalVariables

        private InputAction _inputActions;
        private double _timeOfNextShot;

        #endregion

        #region MonoBehaviourMethods

        private void Awake()
        {
            _inputActions = new GlobalInputActions().Tank.Shooting;
        }

        private void OnEnable()
        {
            _inputActions.performed += OnShotHandler;
            _inputActions.Enable();
        }

        private void OnDisable()
        {
            _inputActions.performed -= OnShotHandler;
            _inputActions.Disable();
        }

        private void Start()
        {
            _generatingPrefab = GetComponentInChildren<IGeneratingPrefab>();
            _launchingPrefab = new LauncherBullet();
        }

        #endregion

        private void OnShotHandler(InputAction.CallbackContext callbackContext)
        {
            if (Time.time >= _timeOfNextShot)
            {
                _timeOfNextShot = Time.time + ShotDelay;

                var instantiatedGameObject = _generatingPrefab.Create(_bullet);
                _launchingPrefab.Launch(_generatingPrefab.FirePosition.up, BulletSpeed,
                    instantiatedGameObject.Rigidbody2D);
            }
        }
    }
}