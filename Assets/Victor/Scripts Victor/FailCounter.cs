using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FailCounter : MonoBehaviour
{
    public int failInt;
    private Transform failCross;
    private GameObject failObject;
    void Update()
    {
        for (int i = 0; i < failInt; i++)
        {
            failCross = this.gameObject.transform.GetChild(i);
            failObject = failCross.gameObject;
            Color color = failObject.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

        }
    }
}
