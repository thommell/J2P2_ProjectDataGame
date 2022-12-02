using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] ReadFromJson _rfj;
    private void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
            DestroyImmediate(this.gameObject);

        if (File.Exists(Application.dataPath + "/PlayerDataFile.json")) 
        { 
           // Link to method LoadFromJason
        }
        else
        {
            // Create JsonFile with all the data
        }
    }
}
