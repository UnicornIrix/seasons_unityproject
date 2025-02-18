using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuController : MonoBehaviour
{
    private UIDocument UI_doc;
    private Button start_button;
    private VisualElement mainmenu_wrapper;
    private Button options_button;
    private Button credits_button;
    private Button quit_button;

    [SerializeField]
    private VisualTreeAsset options_template;
    private VisualElement options;

    private void Awake()
    {
        UI_doc = GetComponent<UIDocument>();

        start_button = UI_doc.rootVisualElement.Q<Button>("Start");
        mainmenu_wrapper = UI_doc.rootVisualElement.Q<VisualElement>("MainMenu");
        options_button = UI_doc.rootVisualElement.Q<Button>("Options");
        credits_button = UI_doc.rootVisualElement.Q<Button>("Credits");
        quit_button = UI_doc.rootVisualElement.Q<Button>("Quit");
        

        start_button.clicked += StartButtonOnClicked;

        options_button.clicked += OptionsButtonOnClicked;
        options = options_template.CloneTree();
        quit_button.clicked += QuitButtonOnClicked;
    }

    private void StartButtonOnClicked(){
        SceneManager.LoadScene(1);
    }
    private void OptionsButtonOnClicked(){
        mainmenu_wrapper.Clear();
    }

    private void QuitButtonOnClicked(){
        Application.Quit();
    }

}
