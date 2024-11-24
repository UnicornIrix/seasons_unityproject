// gestione minigame - platform

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class platform_handle : MonoBehaviour
{
    // 
    public InputAction pg_controls;

    // vettore per far spostare il pg
    Vector2 vec_move = Vector2.zero;

    // velocità del personaggio (provvisoria)
    int speed_pg = 10;

    // per non scrivere ogni volta "this.GetComponent<Rigidbody>()"
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
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
    }
}
