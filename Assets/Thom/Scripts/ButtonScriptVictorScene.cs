using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScriptVictorScene : MonoBehaviour
{
    [SerializeField] Button goBackButton;

    private void Start()
    {
        goBackButton.onClick.AddListener(MainMenu);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }






}
