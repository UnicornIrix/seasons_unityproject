using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class Save_data : MonoBehaviour
{
    static int selected_profile_index = 0;

    static public void SetINDEX(int value)
    {
        selected_profile_index = value;
    }
}
