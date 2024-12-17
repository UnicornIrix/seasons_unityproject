using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_handle : MonoBehaviour
{
    private Rigidbody cubotto;
    public float speed_cubotto = 6f;

    void Update()
    {
         this.transform.GetComponent<Rigidbody>().velocity  = new Vector3(speed_cubotto, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pavimento")
        {
            speed_cubotto *= -1;
        }
    }
}

