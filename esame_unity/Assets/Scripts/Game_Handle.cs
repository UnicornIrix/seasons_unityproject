using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game_Handle : MonoBehaviour
{
    public InputAction player_controls;
    public Rigidbody rb;
    Vector2 direction_move = Vector2.zero;

    int speed_pg = 2; // velocità del personaggio (per ora provvisoria)
    // Start is called before the first frame update
    void Start()
    {
        rb  = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction_move = player_controls.ReadValue<Vector2>(); 
    }

 // capire che è
    private void OnEnable() {
        player_controls.Enable(); // abilito i tasti
    }

    private void OnDisable() {
        player_controls.Disable(); // disabilito i tasti
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(direction_move.x*speed_pg, direction_move.y*speed_pg);
    }
}
