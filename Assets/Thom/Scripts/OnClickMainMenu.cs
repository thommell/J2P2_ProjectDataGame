using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnClickMainMenu : MonoBehaviour
{
    [SerializeField] Button playButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button quitButton;
    private void Start()
    { 
        playButton.GetComponent<Button>();
        settingsButton.GetComponent<Button>();
        quitButton.GetComponent<Button>();

        playButton.onClick.AddListener(PlayButton);
        settingsButton.onClick.AddListener(SettingsButton);
        quitButton.onClick.AddListener(QuitButton);

    }
    public void PlayButton()
    {
        Debug.Log("Play");
        SceneManager.LoadScene(1);
    }
    public void QuitButton()
    {
        Debug.Log("Quit");
    }
    public void SettingsButton()
    {
        Debug.Log("Settings");
    }
}
