using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public FirstPersonInputManager inputManager;
    public Rigidbody rb;
    public float speed = 10;
    public float dashSpeed = 20;

    void Start(){
        inputManager.inputMaster.Movement.Dash.started += _ => Dash();
    }

    void Update(){
        float forward = inputManager.inputMaster.Movement.Forward.ReadValue<float>();
        float right = inputManager.inputMaster.Movement.Right.ReadValue<float>();
        Vector3 move = transform.right * right + transform.forward * forward;

        move *= inputManager.inputMaster.Movement.Dash.ReadValue<float>() = 0 ? speed : dashSpeed;

        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
    }

    void Dash(){
        
    }
}
