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

    [SerializeField]
    private Cursor_manager cursor_Manager;

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
                cursor_Manager.Hide_cursor();
            } else{
                if(ui_season.Visible){
                    ui_season.HideSeasonMenu();
                } 
                if (ui_tutorial.Visible){
                    ui_tutorial.HideTutorialMenu();
                }
                ui_game.ShowGameMenu();
                cursor_Manager.Show_cursor();
            }
    }

    // gestione season menu
    public void gestione_season(){
        if (ui_season.Visible){
                ui_season.HideSeasonMenu();
                cursor_Manager.Hide_cursor();
            } else{
                if(ui_game.Visible){
                    ui_game.HideGameMenu();
                }
                if (ui_tutorial.Visible){
                    ui_tutorial.HideTutorialMenu();
                }
                ui_season.ShowSeasonMenu();
                cursor_Manager.Show_cursor();
            }
    }
}
