//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_BattleTanks/Scripts/InputSystem/GlobalInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace _BattleTanks.Scripts.InputSystem
{
    public partial class @GlobalInputActions: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GlobalInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GlobalInputActions"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""4c665d91-5e50-414a-b716-283992c75dd3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3122cd82-69de-4a9c-9029-d0238b2fc49b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""0bdd0c2f-d581-4986-9988-42e53d6c0e66"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""cbcd7bf3-1fa3-4048-91a2-8f6c3c5b8e85"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de6403b3-d09c-46a5-86fe-6bc9bf9e7473"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5cc6119e-2346-4c7a-b847-94e647f35ae2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""584f3acb-ebec-4870-a4c2-d2e332e40e6e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2d45b22a-38dd-4e99-8872-58566b37a9db"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""78018e6e-f5ad-401c-b2d0-f79ec45c800e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e44817ec-ae23-477f-a337-f77226d05723"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dc5aed6b-032d-4c9c-a268-8adf679c3054"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Tank
            m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
            m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
            m_Tank_Rotation = m_Tank.FindAction("Rotation", throwIfNotFound: true);
            m_Tank_Shooting = m_Tank.FindAction("Shooting", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }

        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Tank
        private readonly InputActionMap m_Tank;
        private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
        private readonly InputAction m_Tank_Movement;
        private readonly InputAction m_Tank_Rotation;
        private readonly InputAction m_Tank_Shooting;
        public struct TankActions
        {
            private @GlobalInputActions m_Wrapper;
            public TankActions(@GlobalInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Tank_Movement;
            public InputAction @Rotation => m_Wrapper.m_Tank_Rotation;
            public InputAction @Shooting => m_Wrapper.m_Tank_Shooting;
            public InputActionMap Get() { return m_Wrapper.m_Tank; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
            public void AddCallbacks(ITankActions instance)
            {
                if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
            }

            private void UnregisterCallbacks(ITankActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Rotation.started -= instance.OnRotation;
                @Rotation.performed -= instance.OnRotation;
                @Rotation.canceled -= instance.OnRotation;
                @Shooting.started -= instance.OnShooting;
                @Shooting.performed -= instance.OnShooting;
                @Shooting.canceled -= instance.OnShooting;
            }

            public void RemoveCallbacks(ITankActions instance)
            {
                if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITankActions instance)
            {
                foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TankActions @Tank => new TankActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
            }
        }
        public interface ITankActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnRotation(InputAction.CallbackContext context);
            void OnShooting(InputAction.CallbackContext context);
        }
    }
}
