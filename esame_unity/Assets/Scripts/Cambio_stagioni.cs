using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_stagioni : MonoBehaviour
{
    GameObject[] gameObjects;

    private Animator animator;

    private void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Albero");
    }
    public void TRANSITION_Primavera() {
        if (Data_save.current_season_index != 1) {
            Data_save.current_season_index = 1;
            foreach (GameObject go in gameObjects)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_primavera");
            }
        }
    }

    public void TRANSITION_Estate()
    {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            animator.SetTrigger("to_estate");
        }
    }

    public void TRANSITION_Autunno()
    {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            animator.SetTrigger("to_autunno");
        }
    }

    public void TRANSITION_Inverno()
    {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            animator.SetTrigger("to_inverno");
        }
    }
}
