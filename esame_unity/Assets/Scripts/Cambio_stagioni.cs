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

    private ParticleSystem particellare;

    private void Start()
    {
        alberi = GameObject.FindGameObjectsWithTag("Albero");
    

    }
    public void TRANSITION_Primavera() {
        if (Data_save.current_season_index != 1) { 
            Data_save.current_season_index = 1;

            start_animation("to_primavera", false, alberi);

            RenderSettings.fogStartDistance = 0;
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

            start_animation("to_estate", false, alberi);

            RenderSettings.fogStartDistance = 0;
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

            start_animation("to_autunno", true, alberi);

            RenderSettings.fogStartDistance = -100;
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

            start_animation("to_inverno", false, alberi);

            RenderSettings.fogStartDistance = -250;
            neve.SetActive(true);

            funghi.SetActive(false);
            fiori.SetActive(false);
            frutta.SetActive(false);
        }
    }

    // starta sia l'animazione degli alberi che il particellare delle foglie
    public void start_animation(string animation_name, bool isAutunno, GameObject[] gameObjects) {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            particellare = go.GetComponentInChildren<ParticleSystem>();
            animator.SetTrigger(animation_name);
            particellare.enableEmission = isAutunno;
        }
    }
}
