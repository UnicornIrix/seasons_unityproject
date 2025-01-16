using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_stagioni : MonoBehaviour
{
    GameObject[] alberi;
    GameObject[] funghi;
    GameObject[] fiori;

    [SerializeField]
    private GameObject neve;

    private Animator animator;

    private void Start()
    {
        alberi = GameObject.FindGameObjectsWithTag("Albero");
        funghi = GameObject.FindGameObjectsWithTag("Fungo");
        fiori = GameObject.FindGameObjectsWithTag("Fiore");
    }

    public void TRANSITION_Primavera()
    {
        if (Data_save.current_season_index != 1)
        {
            Data_save.current_season_index = 1;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_primavera");
            }

            RenderSettings.fogStartDistance = 0;

            neve.SetActive(false);
        }
    }

    public void TRANSITION_Estate()
    {
        if (Data_save.current_season_index != 2)
        {
            Data_save.current_season_index = 2;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_estate");
            }

            RenderSettings.fogStartDistance = 0;

            neve.SetActive(false);
        }
    }

    public void TRANSITION_Autunno()
    {
        if (Data_save.current_season_index != 3)
        {
            Data_save.current_season_index = 3;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_autunno");
            }

            foreach (GameObject go in funghi)
            {
                go.SetActive(true);
            }

            RenderSettings.fogStartDistance = -100;

            neve.SetActive(false);
        }
    }

    public void TRANSITION_Inverno()
    {
        if (Data_save.current_season_index != 4)
        {
            Data_save.current_season_index = 4;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_inverno");
            }

            RenderSettings.fogStartDistance = -250;

            neve.SetActive(true);
        }
    }

    public void start_animation(string animation_name, GameObject[] gameObjects)
    {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            animator.SetTrigger(animation_name);
        }
    }
}
