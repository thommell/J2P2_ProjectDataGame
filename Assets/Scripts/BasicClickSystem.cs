using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicClickSystem : MonoBehaviour
{
    [SerializeField] public float points;
 //  [SerializeField] private float autoPointsPS = 0f;
    [SerializeField] public TextMeshProUGUI displayPoints, displayPoints2;
    [SerializeField] public float[] increaseAutoPoints = { 50f, 250f , 500f , 1000f, 10000f, 100000f, 500000f, 1000000f, };
    [SerializeField] public int x = 0;
    [SerializeField] Button elonMaskButton;
    // [SerializeField] public bool enoughPoints = false;


    void Update()
    {
        displayPoints.text = "Score: " + System.Math.Round(points, 1).ToString();
        displayPoints2.text = "Score: " + System.Math.Round(points, 1).ToString();

        
    /*    if(points <= increaseAutoPoints[x])
        {
           points += 1 * Time.deltaTime * autoPointsPS;          
        }
        else
        {
            x++;
            autoPointsPS++;
        }
    */
    }
    public void Buttonclick()
    {
        points++;
    }
}
