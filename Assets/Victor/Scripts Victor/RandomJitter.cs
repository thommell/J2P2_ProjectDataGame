using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomJitter : MonoBehaviour
{
    private float xJitter;
    private float yJitter;
    private float timer;
    private float jitterTime;

    private void Start()
    {
        JitterRNG();
    }
    private void Update()
    {
        timer = Time.deltaTime;
        if(jitterTime >= timer)
        {
            transform.position = new Vector3(xJitter, yJitter);
            JitterRNG();
            timer = 0;
        }
    }
    private void JitterRNG()
    {
        xJitter = Random.Range(-0.05f, 0.05f);
        yJitter = Random.Range(-3.2f, -2.8f);
        jitterTime = Random.Range(2.5f, 3f );
    }
    
}
