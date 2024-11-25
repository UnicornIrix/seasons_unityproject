using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    // Script che gestisce i bottoni della UI della schermata iniziale

    public GameObject Game_menu;
    public AudioMixer audioMixer;

    // Taso Start - carica la prima scena di gioco
    public void START_button()
    {
        SceneManager.LoadScene("Main");
    }

    // Tasto Quit - esce dall'applicazione
    public void QUIT_button()
    {
        Application.Quit();
    }

    // Tasto Options - apre opzioni
    public void OPTIOINS_button()
    {
        SceneManager.LoadScene("Options");
    }

    // Tasto Credits - apre crediti
    public void CREDITS_button()
    {
        SceneManager.LoadScene("Credits");
    }

    // Tasto Open menu - apre il menu di gioco
    // Attiva la ui 
    public void OPENGM_button()
    {
        // SceneManager.LoadScene("Game_menu");

        Game_menu.SetActive(true);
    }

    // Tasto Continue - ritorna alla main scene
    // Disattiva la ui 
    public void CONTINUE_button()
    {
        // SceneManager.LoadScene("Main");

        Game_menu.SetActive(false);
    }

    // Tasto Back to menu - ritorna al menu iniziale
    public void BACKSM_button()
    {
        SceneManager.LoadScene("Start_menu");
    }

    // Slider Volume - regola il master volume
    public void SetVolume(float volume) {
        audioMixer.SetFloat("MasterVolume", volume);
    }

    // Dropdown Quality - regola la qualità video tra high medium low
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
