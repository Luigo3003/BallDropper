using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallContainer : MonoBehaviour
{
    private PlayerInputs _PlayerInputs;
    public GameObject _BlockPart;

    private void Awake()
    {
        _PlayerInputs = new PlayerInputs();
    }

    void Start()
    {
        _PlayerInputs.Enable();

        _PlayerInputs.PlayerMouse.LeftClick.performed += leftClickMouseDown;
        _PlayerInputs.PlayerMouse.LeftClick.canceled += leftClickMouseUp;
    }



    public void leftClickMouseDown(InputAction.CallbackContext callbackContext)
    {
        _BlockPart.SetActive(false);
    }

    public void leftClickMouseUp(InputAction.CallbackContext callbackContext)
    {
        _BlockPart.SetActive(true);
    }
}
