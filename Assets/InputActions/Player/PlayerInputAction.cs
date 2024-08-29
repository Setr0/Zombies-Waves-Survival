//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/Player/PlayerInputAction.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""3add66dc-6a95-4b00-aff9-5bf5eb423cdc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c04ccde3-f2ad-4e88-88c6-0ca322a194b1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""3f741cc9-d588-4488-b434-a18e6b7b4bdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""8d012897-6a21-4b5a-a4b9-b2578c69ba91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace1"",
                    ""type"": ""Button"",
                    ""id"": ""abac9768-0612-40ed-96b0-8c64c2958193"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace2"",
                    ""type"": ""Button"",
                    ""id"": ""2b7664f4-faba-4744-b70e-07bafe094108"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace3"",
                    ""type"": ""Button"",
                    ""id"": ""31e26058-00b3-4fbc-aac0-30a3eb5acd7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace4"",
                    ""type"": ""Button"",
                    ""id"": ""e6c5d3a8-6ef9-49d9-a492-e86d3a00f40f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace5"",
                    ""type"": ""Button"",
                    ""id"": ""b8dfeb4c-400a-4008-be04-577f6c01507a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace6"",
                    ""type"": ""Button"",
                    ""id"": ""2f92e738-2d52-4c7f-8a69-e2c626a05970"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace7"",
                    ""type"": ""Button"",
                    ""id"": ""c5b07aa4-3147-4520-82d3-9436760ff53d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSpace8"",
                    ""type"": ""Button"",
                    ""id"": ""34dedf09-502a-4da7-8d4b-d41cfb358f78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""db6dd71b-f35e-4b17-9840-df1fa7ca02b8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""127e951f-98ed-439b-8d6c-7e9428a06f4d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""472f6c83-53fa-4880-acb4-2a8e90e3f116"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""538f2153-d6b1-4543-b038-731f02ee2ca8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""084e0a62-aacc-4931-a657-541778a71cc0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""24f7cc1d-3b5b-46c1-b92c-6d5052d6a404"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff3af92-6aed-4c27-9c92-a367c54e0f08"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4261b9e-31fa-411e-8678-f4d6b62e6125"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63eeaae6-d2e8-4da8-a403-3a22a88446af"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a36aa74-a716-4e91-98fd-6d27b4177155"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d4ceac7-10df-4703-a081-2fadd2482730"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6a2c78c-2c84-46c3-ab18-b69b2b30dde2"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e902d5d-df1a-4683-815c-bbf52e269169"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cba21e71-923e-40fa-84e3-ee78dd5a85cf"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51e8145a-acfe-412b-aa05-aeefe2183365"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b3117ee-cc65-4d4d-a906-2b15d46ce0a3"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSpace8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        m_Player_Reload = m_Player.FindAction("Reload", throwIfNotFound: true);
        m_Player_SelectSpace1 = m_Player.FindAction("SelectSpace1", throwIfNotFound: true);
        m_Player_SelectSpace2 = m_Player.FindAction("SelectSpace2", throwIfNotFound: true);
        m_Player_SelectSpace3 = m_Player.FindAction("SelectSpace3", throwIfNotFound: true);
        m_Player_SelectSpace4 = m_Player.FindAction("SelectSpace4", throwIfNotFound: true);
        m_Player_SelectSpace5 = m_Player.FindAction("SelectSpace5", throwIfNotFound: true);
        m_Player_SelectSpace6 = m_Player.FindAction("SelectSpace6", throwIfNotFound: true);
        m_Player_SelectSpace7 = m_Player.FindAction("SelectSpace7", throwIfNotFound: true);
        m_Player_SelectSpace8 = m_Player.FindAction("SelectSpace8", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Shoot;
    private readonly InputAction m_Player_Reload;
    private readonly InputAction m_Player_SelectSpace1;
    private readonly InputAction m_Player_SelectSpace2;
    private readonly InputAction m_Player_SelectSpace3;
    private readonly InputAction m_Player_SelectSpace4;
    private readonly InputAction m_Player_SelectSpace5;
    private readonly InputAction m_Player_SelectSpace6;
    private readonly InputAction m_Player_SelectSpace7;
    private readonly InputAction m_Player_SelectSpace8;
    public struct PlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputAction @Reload => m_Wrapper.m_Player_Reload;
        public InputAction @SelectSpace1 => m_Wrapper.m_Player_SelectSpace1;
        public InputAction @SelectSpace2 => m_Wrapper.m_Player_SelectSpace2;
        public InputAction @SelectSpace3 => m_Wrapper.m_Player_SelectSpace3;
        public InputAction @SelectSpace4 => m_Wrapper.m_Player_SelectSpace4;
        public InputAction @SelectSpace5 => m_Wrapper.m_Player_SelectSpace5;
        public InputAction @SelectSpace6 => m_Wrapper.m_Player_SelectSpace6;
        public InputAction @SelectSpace7 => m_Wrapper.m_Player_SelectSpace7;
        public InputAction @SelectSpace8 => m_Wrapper.m_Player_SelectSpace8;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @SelectSpace1.started += instance.OnSelectSpace1;
            @SelectSpace1.performed += instance.OnSelectSpace1;
            @SelectSpace1.canceled += instance.OnSelectSpace1;
            @SelectSpace2.started += instance.OnSelectSpace2;
            @SelectSpace2.performed += instance.OnSelectSpace2;
            @SelectSpace2.canceled += instance.OnSelectSpace2;
            @SelectSpace3.started += instance.OnSelectSpace3;
            @SelectSpace3.performed += instance.OnSelectSpace3;
            @SelectSpace3.canceled += instance.OnSelectSpace3;
            @SelectSpace4.started += instance.OnSelectSpace4;
            @SelectSpace4.performed += instance.OnSelectSpace4;
            @SelectSpace4.canceled += instance.OnSelectSpace4;
            @SelectSpace5.started += instance.OnSelectSpace5;
            @SelectSpace5.performed += instance.OnSelectSpace5;
            @SelectSpace5.canceled += instance.OnSelectSpace5;
            @SelectSpace6.started += instance.OnSelectSpace6;
            @SelectSpace6.performed += instance.OnSelectSpace6;
            @SelectSpace6.canceled += instance.OnSelectSpace6;
            @SelectSpace7.started += instance.OnSelectSpace7;
            @SelectSpace7.performed += instance.OnSelectSpace7;
            @SelectSpace7.canceled += instance.OnSelectSpace7;
            @SelectSpace8.started += instance.OnSelectSpace8;
            @SelectSpace8.performed += instance.OnSelectSpace8;
            @SelectSpace8.canceled += instance.OnSelectSpace8;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @SelectSpace1.started -= instance.OnSelectSpace1;
            @SelectSpace1.performed -= instance.OnSelectSpace1;
            @SelectSpace1.canceled -= instance.OnSelectSpace1;
            @SelectSpace2.started -= instance.OnSelectSpace2;
            @SelectSpace2.performed -= instance.OnSelectSpace2;
            @SelectSpace2.canceled -= instance.OnSelectSpace2;
            @SelectSpace3.started -= instance.OnSelectSpace3;
            @SelectSpace3.performed -= instance.OnSelectSpace3;
            @SelectSpace3.canceled -= instance.OnSelectSpace3;
            @SelectSpace4.started -= instance.OnSelectSpace4;
            @SelectSpace4.performed -= instance.OnSelectSpace4;
            @SelectSpace4.canceled -= instance.OnSelectSpace4;
            @SelectSpace5.started -= instance.OnSelectSpace5;
            @SelectSpace5.performed -= instance.OnSelectSpace5;
            @SelectSpace5.canceled -= instance.OnSelectSpace5;
            @SelectSpace6.started -= instance.OnSelectSpace6;
            @SelectSpace6.performed -= instance.OnSelectSpace6;
            @SelectSpace6.canceled -= instance.OnSelectSpace6;
            @SelectSpace7.started -= instance.OnSelectSpace7;
            @SelectSpace7.performed -= instance.OnSelectSpace7;
            @SelectSpace7.canceled -= instance.OnSelectSpace7;
            @SelectSpace8.started -= instance.OnSelectSpace8;
            @SelectSpace8.performed -= instance.OnSelectSpace8;
            @SelectSpace8.canceled -= instance.OnSelectSpace8;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnSelectSpace1(InputAction.CallbackContext context);
        void OnSelectSpace2(InputAction.CallbackContext context);
        void OnSelectSpace3(InputAction.CallbackContext context);
        void OnSelectSpace4(InputAction.CallbackContext context);
        void OnSelectSpace5(InputAction.CallbackContext context);
        void OnSelectSpace6(InputAction.CallbackContext context);
        void OnSelectSpace7(InputAction.CallbackContext context);
        void OnSelectSpace8(InputAction.CallbackContext context);
    }
}
