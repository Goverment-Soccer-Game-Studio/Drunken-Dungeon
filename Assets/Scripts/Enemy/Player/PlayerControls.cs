//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Enemy/Player/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""7212dbe4-f7f4-43c1-8fd5-9481fb90d9db"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ee2147c6-969a-48b0-873c-74e7daf95eea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""577b96f2-549b-4d51-91fd-a3ccd8947c8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aeb6818d-37aa-4a9f-9c76-c8a54fa47d42"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6e353ec2-42d2-4dac-9f05-1500a0a40778"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7bb4b89b-0b5d-4ead-89f8-ae836f95f3c6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""02c2dd89-683a-4d0c-8bad-0a84c9ccb44e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ae240aec-4af8-4c36-9f52-9a7f7fc14b21"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4005d25d-7b14-4223-b2ad-8001ecf6ebe9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9ebd693d-775a-4594-bfe7-b0f7004066d6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""03f5caa7-5439-4d2f-b8b3-52d0097a7ee9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a90d4a49-2e51-4d61-a9b3-159565c08ef2"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff39ac3e-d496-4566-8c14-64861a3f8366"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Fight"",
            ""id"": ""6bf35a0a-30bf-462c-ad35-e0023f2f34be"",
            ""actions"": [
                {
                    ""name"": ""RightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""d2efce40-5237-460a-b067-c7f8db9f97d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftPunch"",
                    ""type"": ""Button"",
                    ""id"": ""4669571b-1c79-471f-9faf-bc16d2e1dae7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""51c587bb-59da-4192-b088-44d043775785"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b292686-66d9-425c-956c-be16df2065ae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interact"",
            ""id"": ""938ba616-edc9-442e-a743-26f19b437883"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2ef8e27e-5d6c-47b2-ba9f-c782c46162b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3110b54-7695-4fd8-8911-767c8c46da06"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Escape"",
            ""id"": ""a88c1bc6-48fa-494e-b778-6a16ace05fbc"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""216885f9-7b53-48a4-96b1-d7e4241ce10e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d7ee538d-1978-40ba-a19b-cedd219da271"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BarControls"",
            ""id"": ""ff75a412-7599-4ca4-b6f5-7ae27804147b"",
            ""actions"": [
                {
                    ""name"": ""SelectionLeft"",
                    ""type"": ""Button"",
                    ""id"": ""e7d6e76b-fb59-411a-8bf0-7ac716def1b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectionRight"",
                    ""type"": ""Button"",
                    ""id"": ""553ae9bd-089e-4603-9763-5967b0d5800a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""517e22bc-dcef-40d9-9a94-5ec01dffcee6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""10834edb-ed94-40df-bcd0-6c858bcc7194"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4309c5c-6899-4679-9d04-99eba55cd7cf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1b767989-ed21-493a-a5a4-0b089a43ffde"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60ea4c12-86c0-4803-89de-d392858e2f87"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1470de70-fbec-43e9-b68c-12822515603d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectionRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eee1ba89-9f60-402e-b21b-889491053288"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3bcdb240-ba66-408d-b62b-c65002bc0fce"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_Movement = m_GroundMovement.FindAction("Movement", throwIfNotFound: true);
        m_GroundMovement_Jump = m_GroundMovement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
        // Fight
        m_Fight = asset.FindActionMap("Fight", throwIfNotFound: true);
        m_Fight_RightPunch = m_Fight.FindAction("RightPunch", throwIfNotFound: true);
        m_Fight_LeftPunch = m_Fight.FindAction("LeftPunch", throwIfNotFound: true);
        // Interact
        m_Interact = asset.FindActionMap("Interact", throwIfNotFound: true);
        m_Interact_Interact = m_Interact.FindAction("Interact", throwIfNotFound: true);
        // Escape
        m_Escape = asset.FindActionMap("Escape", throwIfNotFound: true);
        m_Escape_Escape = m_Escape.FindAction("Escape", throwIfNotFound: true);
        // BarControls
        m_BarControls = asset.FindActionMap("BarControls", throwIfNotFound: true);
        m_BarControls_SelectionLeft = m_BarControls.FindAction("SelectionLeft", throwIfNotFound: true);
        m_BarControls_SelectionRight = m_BarControls.FindAction("SelectionRight", throwIfNotFound: true);
        m_BarControls_Confirm = m_BarControls.FindAction("Confirm", throwIfNotFound: true);
        m_BarControls_Escape = m_BarControls.FindAction("Escape", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private List<IGroundMovementActions> m_GroundMovementActionsCallbackInterfaces = new List<IGroundMovementActions>();
    private readonly InputAction m_GroundMovement_Movement;
    private readonly InputAction m_GroundMovement_Jump;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    public struct GroundMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GroundMovement_Movement;
        public InputAction @Jump => m_Wrapper.m_GroundMovement_Jump;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void AddCallbacks(IGroundMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseX.started += instance.OnMouseX;
            @MouseX.performed += instance.OnMouseX;
            @MouseX.canceled += instance.OnMouseX;
            @MouseY.started += instance.OnMouseY;
            @MouseY.performed += instance.OnMouseY;
            @MouseY.canceled += instance.OnMouseY;
        }

        private void UnregisterCallbacks(IGroundMovementActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseX.started -= instance.OnMouseX;
            @MouseX.performed -= instance.OnMouseX;
            @MouseX.canceled -= instance.OnMouseX;
            @MouseY.started -= instance.OnMouseY;
            @MouseY.performed -= instance.OnMouseY;
            @MouseY.canceled -= instance.OnMouseY;
        }

        public void RemoveCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGroundMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_GroundMovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GroundMovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // Fight
    private readonly InputActionMap m_Fight;
    private List<IFightActions> m_FightActionsCallbackInterfaces = new List<IFightActions>();
    private readonly InputAction m_Fight_RightPunch;
    private readonly InputAction m_Fight_LeftPunch;
    public struct FightActions
    {
        private @PlayerControls m_Wrapper;
        public FightActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightPunch => m_Wrapper.m_Fight_RightPunch;
        public InputAction @LeftPunch => m_Wrapper.m_Fight_LeftPunch;
        public InputActionMap Get() { return m_Wrapper.m_Fight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FightActions set) { return set.Get(); }
        public void AddCallbacks(IFightActions instance)
        {
            if (instance == null || m_Wrapper.m_FightActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FightActionsCallbackInterfaces.Add(instance);
            @RightPunch.started += instance.OnRightPunch;
            @RightPunch.performed += instance.OnRightPunch;
            @RightPunch.canceled += instance.OnRightPunch;
            @LeftPunch.started += instance.OnLeftPunch;
            @LeftPunch.performed += instance.OnLeftPunch;
            @LeftPunch.canceled += instance.OnLeftPunch;
        }

        private void UnregisterCallbacks(IFightActions instance)
        {
            @RightPunch.started -= instance.OnRightPunch;
            @RightPunch.performed -= instance.OnRightPunch;
            @RightPunch.canceled -= instance.OnRightPunch;
            @LeftPunch.started -= instance.OnLeftPunch;
            @LeftPunch.performed -= instance.OnLeftPunch;
            @LeftPunch.canceled -= instance.OnLeftPunch;
        }

        public void RemoveCallbacks(IFightActions instance)
        {
            if (m_Wrapper.m_FightActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFightActions instance)
        {
            foreach (var item in m_Wrapper.m_FightActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FightActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FightActions @Fight => new FightActions(this);

    // Interact
    private readonly InputActionMap m_Interact;
    private List<IInteractActions> m_InteractActionsCallbackInterfaces = new List<IInteractActions>();
    private readonly InputAction m_Interact_Interact;
    public struct InteractActions
    {
        private @PlayerControls m_Wrapper;
        public InteractActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interact_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Interact; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractActions set) { return set.Get(); }
        public void AddCallbacks(IInteractActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IInteractActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IInteractActions instance)
        {
            if (m_Wrapper.m_InteractActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractActions @Interact => new InteractActions(this);

    // Escape
    private readonly InputActionMap m_Escape;
    private List<IEscapeActions> m_EscapeActionsCallbackInterfaces = new List<IEscapeActions>();
    private readonly InputAction m_Escape_Escape;
    public struct EscapeActions
    {
        private @PlayerControls m_Wrapper;
        public EscapeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m_Escape_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Escape; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EscapeActions set) { return set.Get(); }
        public void AddCallbacks(IEscapeActions instance)
        {
            if (instance == null || m_Wrapper.m_EscapeActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_EscapeActionsCallbackInterfaces.Add(instance);
            @Escape.started += instance.OnEscape;
            @Escape.performed += instance.OnEscape;
            @Escape.canceled += instance.OnEscape;
        }

        private void UnregisterCallbacks(IEscapeActions instance)
        {
            @Escape.started -= instance.OnEscape;
            @Escape.performed -= instance.OnEscape;
            @Escape.canceled -= instance.OnEscape;
        }

        public void RemoveCallbacks(IEscapeActions instance)
        {
            if (m_Wrapper.m_EscapeActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IEscapeActions instance)
        {
            foreach (var item in m_Wrapper.m_EscapeActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_EscapeActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public EscapeActions @Escape => new EscapeActions(this);

    // BarControls
    private readonly InputActionMap m_BarControls;
    private List<IBarControlsActions> m_BarControlsActionsCallbackInterfaces = new List<IBarControlsActions>();
    private readonly InputAction m_BarControls_SelectionLeft;
    private readonly InputAction m_BarControls_SelectionRight;
    private readonly InputAction m_BarControls_Confirm;
    private readonly InputAction m_BarControls_Escape;
    public struct BarControlsActions
    {
        private @PlayerControls m_Wrapper;
        public BarControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectionLeft => m_Wrapper.m_BarControls_SelectionLeft;
        public InputAction @SelectionRight => m_Wrapper.m_BarControls_SelectionRight;
        public InputAction @Confirm => m_Wrapper.m_BarControls_Confirm;
        public InputAction @Escape => m_Wrapper.m_BarControls_Escape;
        public InputActionMap Get() { return m_Wrapper.m_BarControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BarControlsActions set) { return set.Get(); }
        public void AddCallbacks(IBarControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_BarControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BarControlsActionsCallbackInterfaces.Add(instance);
            @SelectionLeft.started += instance.OnSelectionLeft;
            @SelectionLeft.performed += instance.OnSelectionLeft;
            @SelectionLeft.canceled += instance.OnSelectionLeft;
            @SelectionRight.started += instance.OnSelectionRight;
            @SelectionRight.performed += instance.OnSelectionRight;
            @SelectionRight.canceled += instance.OnSelectionRight;
            @Confirm.started += instance.OnConfirm;
            @Confirm.performed += instance.OnConfirm;
            @Confirm.canceled += instance.OnConfirm;
            @Escape.started += instance.OnEscape;
            @Escape.performed += instance.OnEscape;
            @Escape.canceled += instance.OnEscape;
        }

        private void UnregisterCallbacks(IBarControlsActions instance)
        {
            @SelectionLeft.started -= instance.OnSelectionLeft;
            @SelectionLeft.performed -= instance.OnSelectionLeft;
            @SelectionLeft.canceled -= instance.OnSelectionLeft;
            @SelectionRight.started -= instance.OnSelectionRight;
            @SelectionRight.performed -= instance.OnSelectionRight;
            @SelectionRight.canceled -= instance.OnSelectionRight;
            @Confirm.started -= instance.OnConfirm;
            @Confirm.performed -= instance.OnConfirm;
            @Confirm.canceled -= instance.OnConfirm;
            @Escape.started -= instance.OnEscape;
            @Escape.performed -= instance.OnEscape;
            @Escape.canceled -= instance.OnEscape;
        }

        public void RemoveCallbacks(IBarControlsActions instance)
        {
            if (m_Wrapper.m_BarControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBarControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_BarControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BarControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BarControlsActions @BarControls => new BarControlsActions(this);
    public interface IGroundMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
    public interface IFightActions
    {
        void OnRightPunch(InputAction.CallbackContext context);
        void OnLeftPunch(InputAction.CallbackContext context);
    }
    public interface IInteractActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IEscapeActions
    {
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface IBarControlsActions
    {
        void OnSelectionLeft(InputAction.CallbackContext context);
        void OnSelectionRight(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}
