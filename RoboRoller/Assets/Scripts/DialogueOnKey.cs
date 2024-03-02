using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueOnKey : MonoBehaviour{
    [SerializeField] TextMeshProUGUI interactMessage;
    [SerializeField] string message;
    private Collider player = null;

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.E) && player){
            interactMessage.text = message + '\n' + "press E to continue...";
        }         
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Player"))
        {
            player = other;
            interactMessage.text = "Press E to chat!";
        }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Player"){
            interactMessage.text = "";
            player = null;
        }
    }
}
