using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnClickMainMenu : MonoBehaviour
{
    [SerializeField] GameManager _gm;

    public Button playButton;
    public Button settingsButton;
    public Button quitButton;
    public Button savesButton;

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
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }
    public void SettingsButton()
    {
        Debug.Log("Settings");
    }
    public void SavesButton()
    {
        SceneManager.LoadScene(4);
        Debug.Log("Saves");
    }
    public void QuitButton()
    {
        Debug.Log("Quit");
    }
    
    
}
