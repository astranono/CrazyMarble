using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;
public class MarbleRotationController : MonoBehaviour
{

    [field: SerializeField]
    public Vector3 RotationVector { get; private set; }

    private Marblecontrols _marbleControls;
    void Awake()
    {
        Debug.Log("I'm awake!");
        _marbleControls = new Marblecontrols();
        _marbleControls.RotationControls.Enable();
        _marbleControls.RotationControls.Rotate.performed += HandleRotateControl;
        _marbleControls.RotationControls.Rotate.canceled += HandleRotateStop;
    }
    void FixedUpdate()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        body.AddTorque(RotationVector, ForceMode.VelocityChange);
    }

    private void HandleRotateControl(CallbackContext context)
    {
        Vector2 rawInput = context.ReadValue<Vector2>();
        RotationVector = new Vector3(-rawInput.y, 0, rawInput.x);
    }

    private void HandleRotateStop(CallbackContext context)
    {
        RotationVector = Vector3.zero;
    }
}
