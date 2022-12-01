using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Buttonspawner : MonoBehaviour
{
    [SerializeField] GameObject timedEventButton;
    void Update()
    {
        if (GameObject.Find("Timed Event Button(Clone)") == null)
        {
            Vector2 randomSpawnPos = new Vector2(Random.Range(-2f, 2f), Random.Range(-4.5f, 4f));
            Instantiate(timedEventButton, randomSpawnPos, Quaternion.identity);
        }
    }
}
