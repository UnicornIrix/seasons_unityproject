using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_load : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = Data_save.player_position;
    }
}
