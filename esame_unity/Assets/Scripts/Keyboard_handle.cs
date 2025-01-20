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

    [SerializeField]
    Apertura_tutorial ui_tutorial;


    void Update()
    {
        // game menu
        if (Input.GetKeyDown(KeyCode.Escape)){
            gestione_game();
        }

        // season menu
        if (Input.GetKeyDown(KeyCode.V)){
            if(gestione_rocce.collisione_rocce){
                gestione_season();
            }
        }
    }

    // gestione game menu
    public void gestione_game(){
        if (ui_game.Visible){
                ui_game.HideGameMenu();
            } else{
                if(ui_season.Visible){
                    ui_season.HideSeasonMenu();
                } 
                if (ui_tutorial.Visible){
                    ui_tutorial.HideTutorialMenu();
                }
                ui_game.ShowGameMenu();
            }
    }

    // gestione season menu
    public void gestione_season(){
        if (ui_season.Visible){
                ui_season.HideSeasonMenu();
            } else{
                if(ui_game.Visible){
                    ui_game.HideGameMenu();
                }
                if (ui_tutorial.Visible){
                    ui_tutorial.HideTutorialMenu();
                }
                ui_season.ShowSeasonMenu();
            }
    }
}
