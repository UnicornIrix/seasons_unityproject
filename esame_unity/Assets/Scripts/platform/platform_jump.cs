// gestione minigame - platform

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))] // forza il programma a richiedere il character controller, se non esiste non funge nulla

public class platform_jump : MonoBehaviour
{    
private CharacterController character_controller;
/*
    // variabili movimento

    private float speed_pg = 10.0f;
    private Vector2 vec_move;
*/
    // variabili salto
    private Vector3 vec_jump;
    private bool groundedPlayer; // per controllare se il pg è in aria o sul terreno
    private bool jumpPressed = false; // per controllare se è già stato premuto il tasto (spazio in questo caso)
    [SerializeField] private float jumpForce = 10.0f; // quanto può andare in alto il pg
    private float gravityValue = -9.8f;

    void Start()
    {
        character_controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //movementMove();
        movementJump();
    }
    /*
    void movementMove(){
        Vector3 movement = new Vector3(vec_move.x, 0.0f, 0.0f); // ora mi serve muovermi solo su x
        character_controller.SimpleMove(movement * speed_pg);
    }*/

    void movementJump(){
        groundedPlayer = character_controller.isGrounded;
        if (groundedPlayer){
            vec_jump.y = 0.0f;
            Debug.Log("player grounded");
        }

        if(jumpPressed && groundedPlayer){
            vec_jump.y += Mathf.Sqrt(jumpForce * gravityValue * -1.0f);
            jumpPressed = false;
            Debug.Log("player grounded and jump pressed");
            
        }

        vec_jump.y += gravityValue * Time.deltaTime;
        Debug.Log("abracadabra");
        character_controller.Move(vec_jump * Time.deltaTime);
    }

    // funzioni che fanno parte dell'input system, mandano "messaggi" al gameobject
    /*
    void OnMove(InputValue iv) {

        vec_move = iv.Get<Vector2>();
    }*/

    void OnJump() {
        // controlli
        if (character_controller.velocity.y == 0) {
            // può saltare (non è in aria)
            jumpPressed = true;
            Debug.Log("Can jump");
        } else {
            // non può saltare (è in aria)
            Debug.Log("Can't jump");
        }
    }
}
