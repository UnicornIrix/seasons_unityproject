using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_load : MonoBehaviour
{
    private GameObject player_gameobject;
    private Cambio_stagioni cambio_Stagioni;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Data_save.selected_profile_index);
        Data_save.LoadALL();
        player_gameobject = GameObject.FindGameObjectWithTag("Player");
        cambio_Stagioni = this.GetComponent<Cambio_stagioni>();

        //new Vector3(736, 14.98f, 398);
        

       // player_gameobject.transform.position = Data_save.player_position;
        //PlayerPrefs.GetFloat("Xpos" + Data_save.selected_profile_index);

        switch (PlayerPrefs.GetInt("Season" + PlayerPrefs.GetInt("Slot")))
        {
            case 1:
                cambio_Stagioni.TRANSITION_Primavera();
                break;
            case 3:
                cambio_Stagioni.TRANSITION_Autunno();
                break;
            case 4:
                cambio_Stagioni.TRANSITION_Inverno();
                break;
            default:
                break;
        }
    }
}
