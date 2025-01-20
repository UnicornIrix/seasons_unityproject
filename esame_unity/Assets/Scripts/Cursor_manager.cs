using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Cursor_manager : MonoBehaviour
{
    void Start() {
        Hide_cursor();
    }
    public void Hide_cursor() {
        UnityEngine.Cursor.visible = false;
    }
    public void Show_cursor() {
        UnityEngine.Cursor.visible = true;
    }
}
