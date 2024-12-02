using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_buttons : MonoBehaviour
{
    //
    // Script che gestisce i bottoni della UI dei menu
    //

    public GameObject Game_menu;

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

    // Tasto Open menu - apre il menu di gioco
    // Attiva la ui  e stoppa il tempo
    public void OPENGM_button()
    {
        // SceneManager.LoadScene("Game_menu");
        Time.timeScale = 0f;
        Game_menu.SetActive(true);
    }

    // Tasto Continue - ritorna alla main scene
    // Disattiva la ui e fa ripartire il tempo
    public void CONTINUE_button()
    {
        // SceneManager.LoadScene("Main");
        Time.timeScale = 1f;
        Game_menu.SetActive(false);
    }

    // Tasto Back to menu - ritorna al menu iniziale
    // Resetta la velocit� del tempo (per uscire dal game menu)
    public void BACKSM_button()
    {
        SceneManager.LoadScene("Start_menu");
        Time.timeScale = 1f;
    }
}
