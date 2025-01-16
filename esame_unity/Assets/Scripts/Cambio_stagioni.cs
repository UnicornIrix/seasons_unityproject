using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_stagioni : MonoBehaviour
{
    GameObject[] alberi;
    [SerializeField] private GameObject funghi;
    [SerializeField] private GameObject fiori;
    [SerializeField] private GameObject frutta;

    [SerializeField]
    private GameObject neve;

    private Animator animator;

    private void Start()
    {
        alberi = GameObject.FindGameObjectsWithTag("Albero");
    

    }
    public void TRANSITION_Primavera() {
        if (Data_save.current_season_index != 1) { 
            Data_save.current_season_index = 1;
            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_primavera");
            }

            neve.SetActive(false);
            funghi.SetActive(false);
            fiori.SetActive(true);
            frutta.SetActive(false);
        }
    }

    public void TRANSITION_Estate()
    {
        if (Data_save.current_season_index != 2) { 
            Data_save.current_season_index = 2;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_estate");
            }

            neve.SetActive(false);
            funghi.SetActive(false);
            fiori.SetActive(false);
            frutta.SetActive(true);

        }
    }

    public void TRANSITION_Autunno()
    {
        if (Data_save.current_season_index != 3) { 
            Data_save.current_season_index = 3;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_autunno");
            }

            neve.SetActive(false);
            funghi.SetActive(true);
            fiori.SetActive(false);
            frutta.SetActive(false);
        }
    }

    public void TRANSITION_Inverno()
    {
        if (Data_save.current_season_index != 4) { 
            Data_save.current_season_index = 4;

            foreach (GameObject go in alberi)
            {
                animator = go.GetComponent<Animator>();
                animator.SetTrigger("to_inverno");
            }

            neve.SetActive(true);
            funghi.SetActive(false);
            fiori.SetActive(false);
            frutta.SetActive(false);
        }
    }
}
