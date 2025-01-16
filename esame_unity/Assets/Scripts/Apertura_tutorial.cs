using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apertura_tutorial : MonoBehaviour
{
   [SerializeField]
    private GameObject[] elements;

    private FirstPersonController player;

    private bool visible = false;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
    }

    public bool Visible 
    {
        get { return visible; }
    }

    public void ShowTutorialMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(true);
            visible = true;
        }
        player.enabled = false;
    }

    public void HideTutorialMenu()
    {
        foreach (GameObject item in elements)
        {
            item.SetActive(false);
            visible = false;
        }
        player.enabled = true;
    }
}
