using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OnClickMainMenu : MonoBehaviour
{
    [SerializeField] TransitionElevator _ts;

    [SerializeField] Button playButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button quitButton;

    private int sceneNumber;

    private bool coroutineCheck = false;
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
        float time = 0.5f;
        sceneNumber = 1;
        StartCoroutine(CloseTransition(time));
        Debug.Log("Play");
    }
    public void QuitButton()
    {

        StartCoroutine(CloseTransition(0.5f));
        Debug.Log("Quit");
    }
    public void SettingsButton()
    {

        StartCoroutine(CloseTransition(0.5f));
        Debug.Log("Settings");
    }
    /// <summary>
    /// Coroutine to wait for <see cref="TransitionElevator.Move(float)"/> to finish before loading the new scene
    /// </summary>
    IEnumerator CloseTransition(float timeWait)
    {
        yield return StartCoroutine(_ts.Move(timeWait * Time.deltaTime));
        if (coroutineCheck)
            yield break;
        coroutineCheck = true;

        //yield return new WaitForSeconds(timeWait);

        switch (sceneNumber)
        {
            case 1:
                SceneManager.LoadScene(1);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
            default:
                break;
        }

        coroutineCheck = false;
    }

    IEnumerator OpenTransition(float timeWait)
    {
        yield break;
    }
}
