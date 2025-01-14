using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard_handle : MonoBehaviour
{
    //tentativi
    [SerializeField]
    Apertura_gamemenu ui_game;

    [SerializeField]
    Apertura_seasonmenu ui_season;


    void Update()
    {
        // game menu
        if (Input.GetKeyDown(KeyCode.C)){
            gestione_game();
        }

        // season menu
        if (Input.GetKeyDown(KeyCode.V)){
            gestione_season();
        }
    }

    // gestione game menu
    public void gestione_game(){
        if (ui_game.Visible){
                ui_game.HideGameMenu();
            } else{
                ui_game.ShowGameMenu();
                if(ui_season.Visible){
                    ui_season.HideSeasonMenu();
                }
            }
    }

    // gestione season menu
    public void gestione_season(){
        if (ui_season.Visible){
                ui_season.HideSeasonMenu();
            } else{
                ui_season.ShowSeasonMenu();
                if(ui_game.Visible){
                    ui_game.HideGameMenu();
                }
            }
    }
}
