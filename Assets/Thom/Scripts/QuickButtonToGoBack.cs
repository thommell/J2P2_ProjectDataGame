using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuickButtonToGoBack : MonoBehaviour
{
    [SerializeField] Button goBackButton;
    // Start is called before the first frame update
    void Start()
    {
        goBackButton.onClick.AddListener(GoBack);
    }

    public void GoBack()
    {
        SceneManager.LoadScene(1);
    }
}
