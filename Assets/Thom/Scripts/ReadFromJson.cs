using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ReadFromJson : MonoBehaviour
{
    [SerializeField] BasicClickSystem _bcs;
    private void Awake()
    {
        // Checks if playerdata file does not exist.
        if (!File.Exists("/PlayerDataFile.json"))
        {
            string dataPath = @"C:\Users\Thom\Desktop\School\Unity\GitHub\Github Projects\J2P2_ProjectDataGame\Assets";
            using FileStream fs = File.Create(dataPath);
        }
    }
    // fix not loading saved data
    public void SaveUserData()
    {
        Debug.Log("Saved Data!");
        JsonData playerData = new();
        playerData.totalPoints = _bcs.currentPoints;
        playerData.tappedData = _bcs.totalTaps;
        Debug.Log("SAVED points: " + playerData.totalPoints);

        string json = JsonUtility.ToJson(playerData, true);
        File.WriteAllText(Application.dataPath + "/PlayerDataFile.json", json);
    }
    public void LoadFromJSON()
    {
        string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
        JsonData playerData = JsonUtility.FromJson<JsonData>(json);
        _bcs.points = playerData.totalPoints;
        _bcs.totalTaps = playerData.tappedData;
        Debug.Log("LOADED points: " + playerData.totalPoints);
    }
}