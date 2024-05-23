//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/input_manette.inputactions
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

public partial class @Input_manette: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_manette()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""input_manette"",
    ""maps"": [
        {
            ""name"": ""Mouvement"",
            ""id"": ""ce24cfcb-df63-48f4-8ea1-f9ef40862810"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""fc17eb1a-e0e9-4f0d-9a44-edd63e5f8975"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cbb9b0ef-3cbc-4ad5-afef-c9dfb2f1e02e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hide"",
                    ""type"": ""Button"",
                    ""id"": ""63daa904-1426-4ca0-a398-8e7989a7e8c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Phone"",
                    ""type"": ""Button"",
                    ""id"": ""689e3c98-bc1c-474f-ab0c-2d3ad7547707"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""clavier"",
                    ""id"": ""1a567468-eae7-4f59-babd-3ed24ffaffd5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb1621ea-6e7e-49ff-9831-0dfc2b1ac974"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d8460aac-f33a-4154-a0be-a4af6e03f052"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3ef60dd6-d871-4eb2-9f22-17b040f4fa1d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0843c0ac-ade8-442c-bbff-483a36d37f68"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eba31f5f-2a10-46ae-be29-b762c121bc7f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef990ce4-dd54-4094-bc8d-896ae5ed1efc"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2388b67-ba4f-440d-993f-8a50b54ca394"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4d0b2f2-faae-40d9-956b-3f60c67de950"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6403ad6-51d2-42c1-bc8e-02815e18def3"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe190214-ab2a-4eb3-b67a-d36ee572a1e8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Phone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d932f3ab-4e05-4ef4-9a21-6a5b6dcb89ae"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Phone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""27527b30-943d-4eb8-9e03-ae14375d13a2"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f10ffc5a-1c9e-42f9-bf5a-beb2aba45a21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""79280aab-bfae-41d6-b69d-53bdbc3d3661"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""936956f5-a366-46fe-9635-89daefb38fa7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouvement
        m_Mouvement = asset.FindActionMap("Mouvement", throwIfNotFound: true);
        m_Mouvement_Run = m_Mouvement.FindAction("Run", throwIfNotFound: true);
        m_Mouvement_Jump = m_Mouvement.FindAction("Jump", throwIfNotFound: true);
        m_Mouvement_Hide = m_Mouvement.FindAction("Hide", throwIfNotFound: true);
        m_Mouvement_Phone = m_Mouvement.FindAction("Phone", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Interact = m_Dialogue.FindAction("Interact", throwIfNotFound: true);
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

    // Mouvement
    private readonly InputActionMap m_Mouvement;
    private List<IMouvementActions> m_MouvementActionsCallbackInterfaces = new List<IMouvementActions>();
    private readonly InputAction m_Mouvement_Run;
    private readonly InputAction m_Mouvement_Jump;
    private readonly InputAction m_Mouvement_Hide;
    private readonly InputAction m_Mouvement_Phone;
    public struct MouvementActions
    {
        private @Input_manette m_Wrapper;
        public MouvementActions(@Input_manette wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Mouvement_Run;
        public InputAction @Jump => m_Wrapper.m_Mouvement_Jump;
        public InputAction @Hide => m_Wrapper.m_Mouvement_Hide;
        public InputAction @Phone => m_Wrapper.m_Mouvement_Phone;
        public InputActionMap Get() { return m_Wrapper.m_Mouvement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouvementActions set) { return set.Get(); }
        public void AddCallbacks(IMouvementActions instance)
        {
            if (instance == null || m_Wrapper.m_MouvementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouvementActionsCallbackInterfaces.Add(instance);
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Hide.started += instance.OnHide;
            @Hide.performed += instance.OnHide;
            @Hide.canceled += instance.OnHide;
            @Phone.started += instance.OnPhone;
            @Phone.performed += instance.OnPhone;
            @Phone.canceled += instance.OnPhone;
        }

        private void UnregisterCallbacks(IMouvementActions instance)
        {
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Hide.started -= instance.OnHide;
            @Hide.performed -= instance.OnHide;
            @Hide.canceled -= instance.OnHide;
            @Phone.started -= instance.OnPhone;
            @Phone.performed -= instance.OnPhone;
            @Phone.canceled -= instance.OnPhone;
        }

        public void RemoveCallbacks(IMouvementActions instance)
        {
            if (m_Wrapper.m_MouvementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouvementActions instance)
        {
            foreach (var item in m_Wrapper.m_MouvementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouvementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouvementActions @Mouvement => new MouvementActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private List<IDialogueActions> m_DialogueActionsCallbackInterfaces = new List<IDialogueActions>();
    private readonly InputAction m_Dialogue_Interact;
    public struct DialogueActions
    {
        private @Input_manette m_Wrapper;
        public DialogueActions(@Input_manette wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Dialogue_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void AddCallbacks(IDialogueActions instance)
        {
            if (instance == null || m_Wrapper.m_DialogueActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(IDialogueActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDialogueActions instance)
        {
            foreach (var item in m_Wrapper.m_DialogueActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DialogueActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    public interface IMouvementActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHide(InputAction.CallbackContext context);
        void OnPhone(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnInteract(InputAction.CallbackContext context);
    }
}
