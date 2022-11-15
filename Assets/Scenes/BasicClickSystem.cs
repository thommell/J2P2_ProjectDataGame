using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicClickSystem : MonoBehaviour
{
    [SerializeField] private float points;
    [SerializeField] private float autoPointsPS = 0f;
    [SerializeField] public TextMeshProUGUI displayPoints;
    [SerializeField] public float[] increaseAutoPoints = { 50f, 250f , 500f , 1000f, 10000f, 100000f, 500000f, 1000000f, };
    [SerializeField] public int x = 0;
   // [SerializeField] public bool enoughPoints = false;
    
 
    void Update()
    {
        displayPoints.text = "Score: " + System.Math.Round(points, 1).ToString();

        if (Input.GetMouseButtonDown(0))
        {
            points++;
        }
        if(points <= increaseAutoPoints[x])
        {
           points += 1 * Time.deltaTime * autoPointsPS;          
        }
        else
        {
            x++;
            autoPointsPS++;
        }
    }
}
