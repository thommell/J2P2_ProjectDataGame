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
        goToMiniGame.onClick.AddListener(GoMiniGame);
    }

    public void GoMiniGame()
    {
        SceneManager.LoadScene(3);
    }






}
