using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopOpener : MonoBehaviour
{

    [SerializeField] Button minigameButton;
    [SerializeField] Button mainmenuButton;
    public GameObject shopPanel;
    bool shopActive = false;
    private void Start()
    {
    }

    public void EnableShop()
    {
        if (shopActive == false)
        {
            shopPanel.SetActive(true);
            shopActive = true;
            minigameButton.gameObject.SetActive(false);
            mainmenuButton.gameObject.SetActive(false);
        }
        else
        {
            shopPanel.SetActive(false);
            shopActive = false;
            minigameButton.gameObject.SetActive(true);
            mainmenuButton.gameObject.SetActive(true);

        }
    }
    
    public void DisableShop()
    {
        shopPanel.SetActive(false);
    }
}