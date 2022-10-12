//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/CarControls.inputactions
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

public partial class @CarControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControls"",
    ""maps"": [
        {
            ""name"": ""Drive"",
            ""id"": ""2938ca8e-0848-47c5-854e-67570c924e20"",
            ""actions"": [
                {
                    ""name"": ""SteerRight"",
                    ""type"": ""Button"",
                    ""id"": ""60990ccc-9b0f-4c03-b950-0feb82be9fef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SteerLeft"",
                    ""type"": ""Button"",
                    ""id"": ""34a28e0e-1300-4579-a323-46b5d595520b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""Button"",
                    ""id"": ""24e9ca3f-94cc-4190-9692-937231652de3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Backward"",
                    ""type"": ""Button"",
                    ""id"": ""a471f52d-0060-4994-8ef5-32b247ae79d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""20b38bbe-6896-4d98-9c43-b03e9643df4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e92b772b-529a-4087-bae6-5c5abcecb255"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b579baa-6d43-44c2-a074-b3e17b8afab4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7f0a9331-8fcb-4a8b-903f-b621034a5ee4"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b47c4c6-9a3c-4561-b2db-6a5e47c43da2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SteerLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""251993fc-36ad-493f-a31b-fae576c64a86"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cde660f-bb65-4798-bd48-e334b71f8c6b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7f58cd6-c876-4d47-a1b8-6fe15da8cf09"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f12e4e7-cc7b-4502-bf8e-946d6367b9f4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9d6dd9d-18cf-4237-9ec0-f51fde23c901"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b00f923-02ad-4787-8e0e-439ce516560d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Drive
        m_Drive = asset.FindActionMap("Drive", throwIfNotFound: true);
        m_Drive_SteerRight = m_Drive.FindAction("SteerRight", throwIfNotFound: true);
        m_Drive_SteerLeft = m_Drive.FindAction("SteerLeft", throwIfNotFound: true);
        m_Drive_Forward = m_Drive.FindAction("Forward", throwIfNotFound: true);
        m_Drive_Backward = m_Drive.FindAction("Backward", throwIfNotFound: true);
        m_Drive_Handbrake = m_Drive.FindAction("Handbrake", throwIfNotFound: true);
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

    // Drive
    private readonly InputActionMap m_Drive;
    private IDriveActions m_DriveActionsCallbackInterface;
    private readonly InputAction m_Drive_SteerRight;
    private readonly InputAction m_Drive_SteerLeft;
    private readonly InputAction m_Drive_Forward;
    private readonly InputAction m_Drive_Backward;
    private readonly InputAction m_Drive_Handbrake;
    public struct DriveActions
    {
        private @CarControls m_Wrapper;
        public DriveActions(@CarControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SteerRight => m_Wrapper.m_Drive_SteerRight;
        public InputAction @SteerLeft => m_Wrapper.m_Drive_SteerLeft;
        public InputAction @Forward => m_Wrapper.m_Drive_Forward;
        public InputAction @Backward => m_Wrapper.m_Drive_Backward;
        public InputAction @Handbrake => m_Wrapper.m_Drive_Handbrake;
        public InputActionMap Get() { return m_Wrapper.m_Drive; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DriveActions set) { return set.Get(); }
        public void SetCallbacks(IDriveActions instance)
        {
            if (m_Wrapper.m_DriveActionsCallbackInterface != null)
            {
                @SteerRight.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerRight;
                @SteerRight.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerRight;
                @SteerRight.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerRight;
                @SteerLeft.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerLeft;
                @SteerLeft.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnSteerLeft;
                @Forward.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnForward;
                @Backward.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnBackward;
                @Backward.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnBackward;
                @Backward.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnBackward;
                @Handbrake.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnHandbrake;
            }
            m_Wrapper.m_DriveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SteerRight.started += instance.OnSteerRight;
                @SteerRight.performed += instance.OnSteerRight;
                @SteerRight.canceled += instance.OnSteerRight;
                @SteerLeft.started += instance.OnSteerLeft;
                @SteerLeft.performed += instance.OnSteerLeft;
                @SteerLeft.canceled += instance.OnSteerLeft;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Backward.started += instance.OnBackward;
                @Backward.performed += instance.OnBackward;
                @Backward.canceled += instance.OnBackward;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
            }
        }
    }
    public DriveActions @Drive => new DriveActions(this);
    public interface IDriveActions
    {
        void OnSteerRight(InputAction.CallbackContext context);
        void OnSteerLeft(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
    }
}
