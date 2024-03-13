//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Logic/Inputs/PlayerInputs.inputactions
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

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerMouse"",
            ""id"": ""e5ade5e4-0da4-4dd4-9433-0288cc58df12"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""009be71f-ea6d-4c89-b409-a6bcbd52566d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0b90d4da-ae5c-4a1e-98e0-b0c1ea8a4dbc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMouse
        m_PlayerMouse = asset.FindActionMap("PlayerMouse", throwIfNotFound: true);
        m_PlayerMouse_LeftClick = m_PlayerMouse.FindAction("LeftClick", throwIfNotFound: true);
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

    // PlayerMouse
    private readonly InputActionMap m_PlayerMouse;
    private IPlayerMouseActions m_PlayerMouseActionsCallbackInterface;
    private readonly InputAction m_PlayerMouse_LeftClick;
    public struct PlayerMouseActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerMouseActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_PlayerMouse_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMouseActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMouseActions instance)
        {
            if (m_Wrapper.m_PlayerMouseActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_PlayerMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerMouseActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerMouseActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_PlayerMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public PlayerMouseActions @PlayerMouse => new PlayerMouseActions(this);
    public interface IPlayerMouseActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
