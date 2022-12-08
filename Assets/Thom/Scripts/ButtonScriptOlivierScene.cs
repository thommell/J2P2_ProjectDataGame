using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScriptOlivierScene : MonoBehaviour
{
    [SerializeField] Button goToMiniGame;
    [SerializeField] Button mainmenuButton;

    private void Start()
    {
        goToMiniGame.onClick.AddListener(GoMiniGame); 
        mainmenuButton.onClick.AddListener(GoToLobby);
    }
    public void GoToLobby()
    {
        Debug.Log("test");
        SceneManager.LoadScene(0);
    }
public void GoMiniGame()
    {
        SceneManager.LoadScene(2);
    }






}
