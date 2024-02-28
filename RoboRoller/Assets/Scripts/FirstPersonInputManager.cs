using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class FirstPersonInputManager : MonoBehaviour{
    public InputMaster inputMaster;
    
    void Awake(){
        inputMaster = new InputMaster();
    }

    void OnEnable(){
        inputMaster.Enable();
    }

    void OnDisable(){
        inputMaster.Disable();
    }
}
