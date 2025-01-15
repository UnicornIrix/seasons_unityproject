using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gestione_rocce : MonoBehaviour
{
    public static bool collisione_rocce;

    [SerializeField]
    private GameObject press_V;

    // Start is called before the first frame update
    void Start()
    {
        collisione_rocce = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision){
        if(collision.gameObject.tag == "Player"){
            collisione_rocce = true;
            press_V.SetActive(true);
        }
    }
    void OnTriggerExit(Collider collision){
        if(collision.gameObject.tag == "Player"){
            collisione_rocce = false;
            press_V.SetActive(false);
        }
    }
}
