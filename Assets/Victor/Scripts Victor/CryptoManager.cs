using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptoManager : MonoBehaviour
{
    public float cps;
    private float timer = 0.0f;
    [SerializeField] UpgradesScriptThom _ugst;
    [SerializeField] BasicClickSystem _bcs;

    void Update()
    {
        timer += Time.deltaTime;
        Debug.Log("timer = " +timer);
        if (timer >= 1.0f)
        {
            _bcs.points += _ugst.cps;
            timer = 0.0f;
        }
    }
}
