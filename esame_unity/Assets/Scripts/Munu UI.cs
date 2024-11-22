using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    // Script che gestisce i bottoni della UI della schermata iniziale

    // Taso Start - carica la prima scena di gioco
    public void START_button()
    {
        SceneManager.LoadScene("scena_principale");
    }

    // Tasto Quit - esce dall'applicazione
    public void QUIT_button()
    {
        Application.Quit();
    }

    // Tasto Options - aprire opzioni
    public void OPTIONS_button()
    {

    }

    // Tasto Credits - aprire crediti
    public void CREDITS_button()
    {

    }
}
