using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicClickSystem : MonoBehaviour
{
    [SerializeField] public float points = 2000;
    [SerializeField] private float autoPointsPS = 0f;
    [SerializeField] private TextMeshProUGUI displayPoints;
    [SerializeField] private TextMeshProUGUI criticalHitMessage;
    [SerializeField] private float[] increaseAutoPoints = { 50f, 250f , 500f , 1000f, 10000f, 100000f, 500000f, 1000000f };
    [SerializeField] private int x = 0;
    private float clicks;
   // [SerializeField] public bool enoughPoints = false;
    
 
    void Update()
    {
        displayPoints.text = "Score: " + System.Math.Round(points, 1).ToString();

        if (Input.GetMouseButtonDown(0))
        {
            points++;
            clicks++;

           int criticalHit = Random.Range(1, 1000);
            Debug.Log(criticalHit);
            if (criticalHit == 69 || criticalHit == 727 || criticalHit == 420)
            {           
                points += 10;
                criticalHitMessage.gameObject.SetActive(true);
                Debug.Log("pog");
            }
            

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
