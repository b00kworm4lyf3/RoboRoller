using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BotMovement : MonoBehaviour{
    PlayerInput playerInput;
    InputAction moveAction;
    Transform orientation;
    public float speed = 3.5f;

    
    // Start is called before the first frame update
    void Start(){
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update(){
        MovePlayer();
    }

    void MovePlayer(){
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * speed * Time.deltaTime;
    }
}
