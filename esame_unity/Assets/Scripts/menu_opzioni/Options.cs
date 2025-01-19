using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;


public class Options : MonoBehaviour
{
    //
    // Functions of the buttons in the options menu
    //

    public AudioMixer audioMixer;

    public Slider volume;
    //public Dropdown quality;
    public Toggle fullscreen;

    

    private void Start()
    {
        float prova;
        audioMixer.GetFloat("MasterVolume", out prova);
        volume.value = prova;
        //quality.value = QualitySettings.GetQualityLevel();
        fullscreen.isOn = Screen.fullScreen;
    }

    // Slider Volume - regola il master volume
    public void SetVOLUME(float volume) {
        audioMixer.SetFloat("MasterVolume", volume);
    }
    
    // Dropdown Quality - regola la qualit� video tra high medium low
    public void SetQUALITY(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // Dropdown Quality - regola la qualit� video tra high medium low
    public void SetFULLSCREEN(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
