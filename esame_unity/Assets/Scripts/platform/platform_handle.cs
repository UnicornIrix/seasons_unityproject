// gestione minigame - platform

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class platform_handle : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody player;
    void Start(){
        player = GetComponent<Rigidbody>();
    }
    
    public void Movement(InputAction.CallbackContext context)
    {
        Debug.Log(context.phase);
        if(context.performed){
            StartCoroutine(movementCoroutine(context));
        } else if (context.canceled){
             StopCoroutine(movementCoroutine(context));
        }
    }

    private IEnumerator movementCoroutine(InputAction.CallbackContext ctx){
        while(true){
            Vector2 inputVector = ctx.ReadValue<Vector2>();
            //player.AddForce(new Vector3(inputVector.x, 0.0f, 0.0f) * speed, ForceMode.Force);
            player.velocity = new Vector3(ctx.ReadValue<Vector2>().x*speed,player.velocity.y,0f);
            yield return new WaitForFixedUpdate();
        }
    }
    
}
