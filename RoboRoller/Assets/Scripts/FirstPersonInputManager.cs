using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class FirstPersonInputManager : MonoBehaviour{
    public BotActions inputMaster;
    
    void Awake(){
        inputMaster = new BotActions();
    }

    void OnEnable(){
        inputMaster.Enable();
    }

    void OnDisable(){
        inputMaster.Disable();
    }
}
