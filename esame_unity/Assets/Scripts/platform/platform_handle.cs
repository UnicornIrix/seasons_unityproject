// gestione minigame - platform

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))] // forza il programma a richiedere il character controller, se non esiste non funge nulla

public class platform_handle : MonoBehaviour
{

    // variabili movimento
    private CharacterController character_controller;
    private float speed_pg = 10.0f;
    private Vector2 vec_move;

    // variabili salto
    private Vector3 vec_jump;
    private bool isGrounded; // per vedere se il pg è in aria o sul terreno
    private bool jumpPressed = false;
    [SerializeField] private float jumpForce = 10.0f; // quanto può andare in alto il pg

    void Start()
    {
        character_controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //vec_move = pg_controls.ReadValue<Vector2>();
        Vector3 movement = new Vector3(vec_move.x, 0.0f, 0.0f); // ora mi serve muovermi solo su x
        character_controller.SimpleMove(movement * speed_pg);
    }

    // funzioni che fanno parte dell'input system, mandano "messaggi" al gameobject
    void OnMove(InputValue iv){

        vec_move = iv.Get<Vector2>();
    }

    void OnJump(){

    }
}
