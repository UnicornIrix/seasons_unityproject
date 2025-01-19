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
    private ParticleSystem PS_neve;

    private Animator animator;

    private ParticleSystem PS_foglie;

    [SerializeField]
    private Material blue_sky;

    [SerializeField]
    private Material grey_sky;

    private void Start()
    {
        alberi = GameObject.FindGameObjectsWithTag("Albero");
    }


    public void TRANSITION_Primavera() {
        if (Data_save.current_season_index != 1) { 
            Data_save.current_season_index = 1;

            start_animation("to_primavera", false, alberi);

            RenderSettings.fogStartDistance = 0;
            PS_neve.enableEmission = false;

            funghi.SetActive(false);
            fiori.SetActive(true);
            frutta.SetActive(false);

            RenderSettings.skybox = blue_sky;

        }
    }

    public void TRANSITION_Estate()
    {
        if (Data_save.current_season_index != 2) { 
            Data_save.current_season_index = 2;

            start_animation("to_estate", false, alberi);

            RenderSettings.fogStartDistance = 0;
            PS_neve.enableEmission = false;

            funghi.SetActive(false);
            fiori.SetActive(false);
            frutta.SetActive(true);
            RenderSettings.skybox = blue_sky;

        }
    }

    public void TRANSITION_Autunno()
    {
        if (Data_save.current_season_index != 3) { 
            Data_save.current_season_index = 3;

            start_animation("to_autunno", true, alberi);

            RenderSettings.fogStartDistance = -50;
            PS_neve.enableEmission = false;

            funghi.SetActive(true);
            fiori.SetActive(false);
            frutta.SetActive(false);
            RenderSettings.skybox = grey_sky;
        }
    }

    public void TRANSITION_Inverno()
    {
        if (Data_save.current_season_index != 4) { 
            Data_save.current_season_index = 4;

            start_animation("to_inverno", false, alberi);

            RenderSettings.fogStartDistance = -100;
            PS_neve.enableEmission = true;

            funghi.SetActive(false);
            fiori.SetActive(false);
            frutta.SetActive(false);

            RenderSettings.skybox = grey_sky;
        }
    }

    // starta sia l'animazione degli alberi che il particellare delle foglie
    public void start_animation(string animation_name, bool isAutunno, GameObject[] gameObjects) {
        foreach (GameObject go in gameObjects)
        {
            animator = go.GetComponent<Animator>();
            PS_foglie = go.GetComponentInChildren<ParticleSystem>();
            animator.SetTrigger(animation_name);
            PS_foglie.enableEmission = isAutunno;
        }
    }
}
