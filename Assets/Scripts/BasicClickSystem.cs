using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BasicClickSystem : MonoBehaviour
{
    public int totalTaps;
 //   [SerializeField] ReadFromJson _rfj;
    [SerializeField] public float points;
    [SerializeField] public TextMeshProUGUI displayPoints, displayPoints2;
    [SerializeField] Button elonMaskButton;

    private void Awake()
    {
  //      _rfj.LoadFromJSON();
    }
    void Update()
    {
        displayPoints.text = "Score: " + System.Math.Round(points, 1).ToString();
        displayPoints2.text = "Score: " + System.Math.Round(points, 1).ToString(); 
    }
    public void buttonClick()
    {
        points++;
        totalTaps++;
    }

    public void SaveData()
    {
  //      _rfj.SaveUserData();
    }
}
