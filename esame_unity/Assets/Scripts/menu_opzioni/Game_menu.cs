using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_menu : MonoBehaviour
{
    private GameObject GOGame_menu;

    private void Start()
    {
        GOGame_menu = GameObject.FindGameObjectWithTag("Game menu");
    }

    void Update()
    {
        if (Input.GetAxis("Seasons") == 1)
        {
            if (!GOGame_menu.activeSelf)
            {
                GOGame_menu.SetActive(true);
            }
            else
            {
                GOGame_menu.SetActive(false);
            }
        }
    }
}
