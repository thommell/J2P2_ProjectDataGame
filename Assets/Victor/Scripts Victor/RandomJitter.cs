using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomJitter : MonoBehaviour
{
    private float jitterAmount;
    private float timer;
    [SerializeField] float jitterTime;
    //[SerializeField] GameObject rocketShip;

    private void Start()
    {
        JitterRNG();
    }
    private void Update()
    {
        timer = Time.deltaTime;
        if(jitterTime >= timer)
        {
            transform.position = new Vector3(jitterAmount, -3);
            JitterRNG();
            timer = 0;
        }
    }
    private void JitterRNG()
    {
        jitterAmount = Random.Range(-0.2f, 0.2f);
        jitterTime = Random.Range(1.5f, 2f );
    }
    
}
