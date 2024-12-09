using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_load : MonoBehaviour
{
    public GameObject player_gameobject;

    // Start is called before the first frame update
    void Start()
    {
        Data_save.LoadALL();

        player_gameobject.transform.position = Data_save.player_position;
    }
}
