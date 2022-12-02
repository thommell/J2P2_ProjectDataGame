using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadFromJson : MonoBehaviour
{
    
    public void SaveFromJson()
    {
        JsonData playerData = new();




        string json = JsonUtility.ToJson(playerData, true);
        File.WriteAllText(Application.dataPath + "/PlayerDataFile.json", json);

    }
}
