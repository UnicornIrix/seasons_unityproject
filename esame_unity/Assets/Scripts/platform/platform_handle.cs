// gestione minigame - platform

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class platform_handle : MonoBehaviour
{
    private CharacterController character_controller;
    float speed_pg = 10.0f;
    Vector2 vec_move;


    public InputAction pg_controls;

    // vettore per far spostare il pg
    
    //Vector2 vec_jump;

    // velocità del personaggio (provvisoria)
    

    // per non scrivere ogni volta "this.GetComponent<Rigidbody>()"
     Rigidbody rb;

    public float jumpForce = 10.0f;

    void Start()
    {
        //rb = this.
        character_controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        vec_move = pg_controls.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        pg_controls.Enable(); // abilito i tasti
    }

    private void OnDisable()
    {
        pg_controls.Disable(); // disabilito i tasti
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(vec_move.x * speed_pg, 0);
        rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }

}
