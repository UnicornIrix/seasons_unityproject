using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentativo_apertura_menu : MonoBehaviour
{
   [SerializeField]
    private GameObject[] elements;
    private bool visible;

    public bool Visible
    {
        get { return visible; }
    }

    public void Show()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(true);
        }
    }

    public void Hide()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(false);
        }
    }
}
