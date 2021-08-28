// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""13bab67c-007f-46d2-a9ce-5d929bddc82d"",
            ""actions"": [
                {
                    ""name"": ""direction1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7b61163c-65bc-4304-9396-b14938ac78e0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""direction2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""630f59d8-c8b7-4b9f-a3d8-695ee4b74977"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""act"",
                    ""type"": ""Button"",
                    ""id"": ""777b165f-ab79-4b0c-9910-85dbabecce21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c2f4a742-f42c-4487-9aa8-96a443ee5034"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4b24c0d2-7824-4a04-a17e-ef0eda4aecff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""178ee510-5314-4f21-9fcf-a01bd6d4142e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""770e44fd-e0ea-4d8c-9684-732fc14b6906"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0a71879e-6397-4c33-8797-a72841b7b628"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b47db941-990b-4078-ba03-ce7af858fcfa"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6bd98c51-3f18-4fab-b045-2f55d7c9e0e3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e49f10c4-6893-4269-a8c7-d91a6c7f39dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""direction2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f8513e55-7f8c-45db-ad82-321119dd2087"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""91b01b21-58ad-4408-8a59-71420e68eb60"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""81d7227d-c4ed-498b-9a41-45ddfdb9a165"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b770f82e-e85a-4829-80ae-c8f64b810a61"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""direction2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f810cc8d-30bd-447e-9862-ca4500bda39b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""direction2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4ad6cab4-80f3-4603-9e9a-d6213506f573"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff1264e1-06b9-4a62-b16c-0296bed64694"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92b2e48e-ea99-45a7-9502-f9bc368ccc8a"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf3474d9-e683-4c73-9d77-f83b234c5d39"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fa3ccf0-8f9d-4553-97a9-7b591e27c502"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c9a9f8e-d824-4aa6-a98e-55ac30f9570a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb96be78-aead-48fb-968a-5c158643be1c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49b32fd3-3336-41aa-9b03-e171b1f8349c"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9302ecb0-aacd-4cea-bc3b-a1d59d3731bf"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae1c73ef-4230-4e2e-941c-7e24210eebf0"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""controller"",
                    ""action"": ""act"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""New action map1"",
            ""id"": ""c44db801-8bb5-4291-8ba5-8c8eef279443"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""782c7316-33c9-4744-86d3-2fe32254db9e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""005d7e6e-62dd-4a33-928a-a055556d0f50"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Kebord"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Kebord"",
            ""bindingGroup"": ""Kebord"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""mouse"",
            ""bindingGroup"": ""mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""controller"",
            ""bindingGroup"": ""controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_direction1 = m_Newactionmap.FindAction("direction1", throwIfNotFound: true);
        m_Newactionmap_direction2 = m_Newactionmap.FindAction("direction2", throwIfNotFound: true);
        m_Newactionmap_act = m_Newactionmap.FindAction("act", throwIfNotFound: true);
        // New action map1
        m_Newactionmap1 = asset.FindActionMap("New action map1", throwIfNotFound: true);
        m_Newactionmap1_Newaction = m_Newactionmap1.FindAction("New action", throwIfNotFound: true);
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_direction1;
    private readonly InputAction m_Newactionmap_direction2;
    private readonly InputAction m_Newactionmap_act;
    public struct NewactionmapActions
    {
        private @PlayerInput m_Wrapper;
        public NewactionmapActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @direction1 => m_Wrapper.m_Newactionmap_direction1;
        public InputAction @direction2 => m_Wrapper.m_Newactionmap_direction2;
        public InputAction @act => m_Wrapper.m_Newactionmap_act;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @direction1.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection1;
                @direction1.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection1;
                @direction1.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection1;
                @direction2.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection2;
                @direction2.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection2;
                @direction2.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnDirection2;
                @act.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnAct;
                @act.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnAct;
                @act.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnAct;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @direction1.started += instance.OnDirection1;
                @direction1.performed += instance.OnDirection1;
                @direction1.canceled += instance.OnDirection1;
                @direction2.started += instance.OnDirection2;
                @direction2.performed += instance.OnDirection2;
                @direction2.canceled += instance.OnDirection2;
                @act.started += instance.OnAct;
                @act.performed += instance.OnAct;
                @act.canceled += instance.OnAct;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);

    // New action map1
    private readonly InputActionMap m_Newactionmap1;
    private INewactionmap1Actions m_Newactionmap1ActionsCallbackInterface;
    private readonly InputAction m_Newactionmap1_Newaction;
    public struct Newactionmap1Actions
    {
        private @PlayerInput m_Wrapper;
        public Newactionmap1Actions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Newactionmap1_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Newactionmap1Actions set) { return set.Get(); }
        public void SetCallbacks(INewactionmap1Actions instance)
        {
            if (m_Wrapper.m_Newactionmap1ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_Newactionmap1ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_Newactionmap1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public Newactionmap1Actions @Newactionmap1 => new Newactionmap1Actions(this);
    private int m_KebordSchemeIndex = -1;
    public InputControlScheme KebordScheme
    {
        get
        {
            if (m_KebordSchemeIndex == -1) m_KebordSchemeIndex = asset.FindControlSchemeIndex("Kebord");
            return asset.controlSchemes[m_KebordSchemeIndex];
        }
    }
    private int m_mouseSchemeIndex = -1;
    public InputControlScheme mouseScheme
    {
        get
        {
            if (m_mouseSchemeIndex == -1) m_mouseSchemeIndex = asset.FindControlSchemeIndex("mouse");
            return asset.controlSchemes[m_mouseSchemeIndex];
        }
    }
    private int m_controllerSchemeIndex = -1;
    public InputControlScheme controllerScheme
    {
        get
        {
            if (m_controllerSchemeIndex == -1) m_controllerSchemeIndex = asset.FindControlSchemeIndex("controller");
            return asset.controlSchemes[m_controllerSchemeIndex];
        }
    }
    public interface INewactionmapActions
    {
        void OnDirection1(InputAction.CallbackContext context);
        void OnDirection2(InputAction.CallbackContext context);
        void OnAct(InputAction.CallbackContext context);
    }
    public interface INewactionmap1Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
