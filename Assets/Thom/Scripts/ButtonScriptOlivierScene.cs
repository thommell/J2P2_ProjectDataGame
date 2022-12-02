using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScriptOlivierScene : MonoBehaviour
{
    [SerializeField] Button goToMiniGame;

    private void Start()
    {
        goToMiniGame.onClick.AddListener(MainMenu);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(3);
    }






}
