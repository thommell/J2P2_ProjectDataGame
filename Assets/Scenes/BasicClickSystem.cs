using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasicClickSystem : MonoBehaviour
{
    [SerializeField] private float points;
    [SerializeField] public TextMeshProUGUI displayPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayPoints.text = "Score: " + points.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            points++;
        }
    }
}
