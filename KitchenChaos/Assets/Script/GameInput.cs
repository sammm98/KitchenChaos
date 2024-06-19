using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    // Start is called before the first frame update
    public event EventHandler OnInteractAction;
    public event EventHandler OnInteractAltermateAction;
    private PlayerInputAction playerInputAction;
    private void Awake()
    {
        playerInputAction = new PlayerInputAction();
        playerInputAction.Player.Enable();
        playerInputAction.Player.Interact.performed += Interact_performed;
        playerInputAction.Player.InteractAltermate.performed += InteractAltermate_performed;
        
    }

    private void InteractAltermate_performed(InputAction.CallbackContext obj)
    {
        OnInteractAltermateAction?.Invoke(this, EventArgs.Empty);
    }


    private void Interact_performed(InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke(this, EventArgs.Empty);
        
    }

    void Start()
    {
        
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();
        
        inputVector = inputVector.normalized;
        return inputVector;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
