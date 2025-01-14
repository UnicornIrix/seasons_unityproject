using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apertura_gamemenu : MonoBehaviour
{
   [SerializeField]
    private GameObject[] elements;
    private bool visible = false;

    public bool Visible 
    {
        get { return visible; }
    }

    public void ShowGameMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(true);
            visible = true;
        }
    }

    public void HideGameMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(false);
            visible = false;
        }
    }
}
