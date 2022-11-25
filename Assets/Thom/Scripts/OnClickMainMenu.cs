using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnClickMainMenu : MonoBehaviour
{
    [SerializeField] TransitionElevator _ts;
    [SerializeField] GameManager _gm;

    public Button playButton;
    public Button settingsButton;
    public Button quitButton;
    public Button savesButton;

    public float time;
    private void Start()
    { 
        playButton.GetComponent<Button>();
        settingsButton.GetComponent<Button>();
        quitButton.GetComponent<Button>();
        savesButton.GetComponent<Button>();

        playButton.onClick.AddListener(PlayButton);
        settingsButton.onClick.AddListener(SettingsButton);
        quitButton.onClick.AddListener(QuitButton);
        savesButton.onClick.AddListener(SavesButton);

    }
    public void PlayButton()
    {
        time = 0.5f;
        _gm.sceneNumber = 1;
        StartCoroutine(_gm.CloseTransition(time));
        Debug.Log("Play");
    }
    public void SettingsButton()
    {

        StartCoroutine(_gm.CloseTransition(0.5f));
        Debug.Log("Settings");
    }
    public void SavesButton()
    {
        StartCoroutine(_gm.CloseTransition(0.5f));
        Debug.Log("Saves");
    }
    public void QuitButton()
    {

        StartCoroutine(_gm.CloseTransition(0.5f));
        Debug.Log("Quit");
        Application.Quit();
    }
    
    /// <summary>
    /// Coroutine to wait for <see cref="TransitionElevator.ElevatorTransition(float)"/> to finish before loading the new scene
    /// </summary>
    
}
