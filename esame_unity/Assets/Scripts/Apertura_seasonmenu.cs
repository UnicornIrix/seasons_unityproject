using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apertura_seasonmenu : MonoBehaviour
{
   [SerializeField]
    private GameObject[] elements;
    private bool visible = false;

    public bool Visible
    {
        get { return visible; }
    }

    public void ShowSeasonMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(true);
            visible = true;
        }
    }

    public void HideSeasonMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(false);
            visible = false;
        }
    }
}
