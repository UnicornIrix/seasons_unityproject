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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        //gestione game menu
        if (Input.GetKeyDown(KeyCode.C)){
            if (ui_game.Visible){
                ui_game.HideGameMenu();
            } else{
                ui_game.ShowGameMenu();
                if(ui_season.Visible){
                    ui_season.HideSeasonMenu();
                }
            }
        }
        

        if (Input.GetKeyDown(KeyCode.V)){
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
}
