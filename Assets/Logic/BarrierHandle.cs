using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BarrierHandle : MonoBehaviour
{
    private PlayerInputs _playerInput;
    public GameObject _Barrier;

    private void Awake()
    {
        _playerInput = new PlayerInputs();
    }

    void Start()
    {
        _playerInput.Enable();

        _playerInput.PlayerMouse.LeftClick.performed += leftClickMouseDown;
        _playerInput.PlayerMouse.LeftClick.canceled += leftClickMouseUp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void leftClickMouseDown(InputAction.CallbackContext ctx)
    {
        _Barrier.gameObject.SetActive(false);

    }

    void leftClickMouseUp(InputAction.CallbackContext ctx)
    {
        _Barrier.gameObject.SetActive(true);
    }
}
