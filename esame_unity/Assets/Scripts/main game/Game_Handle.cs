using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Game_Handle : MonoBehaviour
{
    public InputAction player_controls;
    public Rigidbody rb;
    Vector3 direction_move = Vector3.zero;

    public int speed_pg = 5; // velocità del personaggio (per ora provvisoria)

    // Start is called before the first frame update
    void Start()
    {
        rb  = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        direction_move = player_controls.ReadValue<Vector3>(); 
    }

 // capire che è
    private void OnEnable() {
        player_controls.Enable(); // abilito i tasti
    }

    private void OnDisable() {
        player_controls.Disable(); // disabilito i tasti
    }

    private void FixedUpdate() {
        rb.velocity = new Vector3(direction_move.x*speed_pg, 0, direction_move.z*speed_pg);
    }
}
