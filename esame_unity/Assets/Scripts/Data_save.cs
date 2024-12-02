using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

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
    }
}
