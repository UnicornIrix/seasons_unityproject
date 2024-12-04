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
    private static int selected_profile_index = 0;

    // Indice della stagione in cui il player sta giocando / stava giocando prima di uscire
    private static int current_season_index = 0;

    // Position of the player
    private static Vector3 player_position = Vector3.zero;

    // Intero che tiene traccia della progressione del giocatore
    // 2^(0) = 1 = il player ha riempito lo slot di salvataggi per la prima volta
    // 2^(1) = 2 = 
    // 2^(2) = 4 = 
    private static int player_progression = 0;


    // I quattro tasti di Load game
    [SerializeField]
    private TMP_Text Slot1;
    [SerializeField]
    private TMP_Text Slot2;
    [SerializeField]
    private TMP_Text Slot3;
    [SerializeField]
    private TMP_Text Slot4;

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
    public static void SaveALL() {
        PlayerPrefs.SetFloat("Xpos" + selected_profile_index, player_position.x);
        PlayerPrefs.SetFloat("Ypos" + selected_profile_index, player_position.y);
        PlayerPrefs.SetFloat("Zpos" + selected_profile_index, player_position.z);

        PlayerPrefs.SetInt("Season" + selected_profile_index, current_season_index);

        PlayerPrefs.SetInt("Progression" + selected_profile_index, player_progression);
    }

    public static void LoadALL() {
        current_season_index = PlayerPrefs.GetInt("Season" + selected_profile_index);
        player_position.x = PlayerPrefs.GetInt("Xpos" + selected_profile_index);
        player_position.y = PlayerPrefs.GetInt("Ypos" + selected_profile_index);
        player_position.z = PlayerPrefs.GetInt("Zpos" + selected_profile_index);
        player_progression = PlayerPrefs.GetInt("Progression" + selected_profile_index);
    }

    public void Start()
    {
        if(PlayerPrefs.HasKey("Season1")) {
            Slot1.text = "1 - Grostnix1";
        }

        if (PlayerPrefs.HasKey("Season2")) {
            Slot2.text = "2 - Grostnix2";
        }

        if (PlayerPrefs.HasKey("Season3")) {
            Slot3.text = "3 - Grostnix3";
        }

        if (PlayerPrefs.HasKey("Season4")) {
            Slot4.text = "4 - Grostnix4";
        }
    }

    // Funzione dei tasti del menu Load game
    public void LoadBUTTON() {
        if (PlayerPrefs.GetInt("Progression" + selected_profile_index) > 0)
        {
            // Inizializza il giocatore in primavera in posizione (0,0)
            current_season_index = 1;
            player_position = Vector3.zero;
            player_progression = 1;

            SaveALL();
        }
        else
        {
            LoadALL();

            SceneManager.LoadScene(current_season_index);
        }
    }
}
