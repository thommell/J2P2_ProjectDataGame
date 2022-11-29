using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpener : MonoBehaviour
{
    public GameObject shopPanel;
    bool shopActive = false;
    void Update()
    {
        
    }

    public void EnableShop()
    {
        if(shopActive == false)
        {
            shopPanel.SetActive(true);
            shopActive = true;
        }
        else
        {
            shopPanel.SetActive(false);
            shopActive = false;
        }
       

        
    }
    public void DisableShop()
    {
        shopPanel.SetActive(false);
    }
}
