// gestione minigame - platform

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class platform_jump : MonoBehaviour
{ 
    private Rigidbody player;

    void Start(){
        player = GetComponent<Rigidbody>();
    }
    public void Jump(InputAction.CallbackContext context){
        Debug.Log("JUMP!" + context.phase);
        if(context.performed && player.velocity.y == 0){
            //isGrounded= false;
            player.AddForce(Vector3.up * 5.0f, ForceMode.Impulse);
            Debug.Log("isgrounded false");
        }
    }
}
