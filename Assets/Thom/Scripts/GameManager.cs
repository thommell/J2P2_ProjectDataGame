using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject instance;


    private void Awake()
    {
        instance = this.gameObject;
        DontDestroyOnLoad(instance);
    }
}
