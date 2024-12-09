using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Data_save : MonoBehaviour
{
    //
    // Classe che si occupa del salvataggio di dati
    //


    // Indice del profilo selezionato nella schermata "Load game"
    public static int selected_profile_index = 0;

    // Indice della stagione in cui il player sta giocando / stava giocando prima di uscire
    public static int current_season_index = 0;

    // Position of the player
    public static Vector3 player_position = Vector3.zero;

    // Intero che tiene traccia della progressione del giocatore
    // 2^(0) = 1 = il player ha riempito lo slot di salvataggi per la prima volta
    // 2^(1) = 2 = 
    // 2^(2) = 4 = 
    private static int player_progression = 0;

    // Per aggiornare i dati del giocatore
    [SerializeField]
    private GameObject player_gameobject;


    // I txt dei 4 tasti di Load game
    [SerializeField]
    private TMP_Text Slot1;
    [SerializeField]
    private TMP_Text Slot2;
    [SerializeField]
    private TMP_Text Slot3;
    [SerializeField]
    private TMP_Text Slot4;

    // I 4 tasti per cancellare i salvataggi del profilo
    [SerializeField]
    private GameObject Clear_button1;
    [SerializeField]
    private GameObject Clear_button2;
    [SerializeField]
    private GameObject Clear_button3;
    [SerializeField]
    private GameObject Clear_button4;


    // Get e set
    public static void SetPROFILE(int value) {
        selected_profile_index = value;
    }
    public static int GetPROFILE() {
        return selected_profile_index;
    }

    public static void SetSEASON(int value) {
        current_season_index = value;
    }
    public static int GetSEASON() {
        return current_season_index;
    }


    // Salva tutto
    // Carica i valori delle variabili statiche nei prefs
    public static void SaveALL() {
        PlayerPrefs.SetFloat("Xpos" + selected_profile_index, player_position.x);
        PlayerPrefs.SetFloat("Ypos" + selected_profile_index, player_position.y);
        PlayerPrefs.SetFloat("Zpos" + selected_profile_index, player_position.z);

        PlayerPrefs.SetInt("Season" + selected_profile_index, current_season_index);

        PlayerPrefs.SetInt("Progression" + selected_profile_index, player_progression);


        Debug.Log("selected_profile_index = " + selected_profile_index);
        Debug.Log("current_season_index = " + current_season_index);
        Debug.Log("player_position.x = " + player_position.x);
        Debug.Log("player_position.y = " + player_position.y);
        Debug.Log("player_position.z = " + player_position.z);
        Debug.Log("player_progression = " + player_progression);

        Debug.Log("PlayerPrefs.GetInt(\"Season\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Season" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Xpos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Xpos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Ypos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Ypos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Zpos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Zpos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Progression\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Progression" + selected_profile_index));
    }

    // Carica tutto
    // Carica i valori dei prefs nelle variabili statiche
    public static void LoadALL() {
        current_season_index = PlayerPrefs.GetInt("Season" + selected_profile_index);
        player_position.x = PlayerPrefs.GetInt("Xpos" + selected_profile_index);
        player_position.y = PlayerPrefs.GetInt("Ypos" + selected_profile_index);
        player_position.z = PlayerPrefs.GetInt("Zpos" + selected_profile_index);
        player_progression = PlayerPrefs.GetInt("Progression" + selected_profile_index);


        Debug.Log("selected_profile_index = " + selected_profile_index);
        Debug.Log("current_season_index = " + current_season_index);
        Debug.Log("player_position.x = " + player_position.x);
        Debug.Log("player_position.y = " + player_position.y);
        Debug.Log("player_position.z = " + player_position.z);
        Debug.Log("player_progression = " + player_progression);

        Debug.Log("PlayerPrefs.GetInt(\"Season\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Season" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Xpos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Xpos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Ypos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Ypos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Zpos\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Zpos" + selected_profile_index));
        Debug.Log("PlayerPrefs.GetInt(\"Progression\"" + selected_profile_index + " = " + PlayerPrefs.GetInt("Progression" + selected_profile_index));
    }

    // Funzione che aggiorna le variabili statiche
    public void UpdateALL() {
        player_position =  player_gameobject.transform.position;
    }

    // Bottone che cancella i salvataggi di uno slot
    public static void ClearALL() {
        PlayerPrefs.DeleteKey("Season" + selected_profile_index);
        PlayerPrefs.DeleteKey("Xpos" + selected_profile_index);
        PlayerPrefs.DeleteKey("Ypos" + selected_profile_index);
        PlayerPrefs.DeleteKey("Zpos" + selected_profile_index);
        PlayerPrefs.DeleteKey("Progression" + selected_profile_index);
    }


    // Funzione dei tasti del menu Load game
    // Crea un nuovo salvataggio o aggiorna i dati se già pieno
    public void LoadBUTTON() {
        if (PlayerPrefs.HasKey("Progression" + selected_profile_index))
        {
            LoadALL();

            SceneManager.LoadScene(current_season_index);
        }
        else
        {
            // Inizializza il giocatore in primavera in posizione (0,0)
            current_season_index = 1;
            player_position = Vector3.zero;
            player_progression = 1;

            SaveALL();

            SceneManager.LoadScene(current_season_index);
        }
    }
    

    // Funzioni dei 4 bottoni per cancellare i salvataggi
    public void ClearBUTTON1() {
        Slot1.text = "1 - NEW GAME";
        Clear_button1.SetActive(false);
        ClearALL();
    }
    public void ClearBUTTON2()
    {
        Slot2.text = "2 - NEW GAME";
        Clear_button2.SetActive(false);
        ClearALL();
    }
    public void ClearBUTTON3()
    {
        Slot3.text = "3 - NEW GAME";
        Clear_button3.SetActive(false);
        ClearALL();
    }
    public void ClearBUTTON4()
    {
        Slot4.text = "4 - NEW GAME";
        Clear_button4.SetActive(false);
        ClearALL();
    }


    // In update il controllo se gli slot di salvataggio sono vuoti o pieni
    // Se pieni il testo viene cambiato
    public void Start()
    {
        if(PlayerPrefs.HasKey("Season1")) {
            Slot1.text = "1 - Grostnix 1";
            Clear_button1.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Season2")) {
            Slot2.text = "2 - Grostnix 2";
            Clear_button2.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Season3")) {
            Slot3.text = "3 - Grostnix 3";
            Clear_button3.SetActive(true);
        }

        if (PlayerPrefs.HasKey("Season4")) {
            Slot4.text = "4 - Grostnix 4";
            Clear_button4.SetActive(true);
        }
    }
}
