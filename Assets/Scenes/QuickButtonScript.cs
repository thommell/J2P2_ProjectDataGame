using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuickButtonScript : MonoBehaviour
{
    [SerializeField] Button quickButton;
    [SerializeField] Button menuButton;
    void Start()
    {
        quickButton.onClick.AddListener(QuickButtonFunc);
        menuButton.onClick.AddListener(GoBackToMenu);
    }

    // Update is called once per frame
    public void QuickButtonFunc()
    {
        SceneManager.LoadScene(2);
    }
    public void GoBackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
