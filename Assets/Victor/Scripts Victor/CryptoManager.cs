using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CryptoManager : MonoBehaviour
{
    public float cps;
    private float timer = 0.0f;
    [SerializeField] UpgradesScriptThom _ugst;
    [SerializeField] BasicClickSystem _bcs;
    void Start()
    {
        
    }

    void Update()
    {
        cps = (_ugst.gtx[1] * _ugst.gtx[2] + _ugst.ape[1] * _ugst.ape[2] + _ugst.tradeBot[1] * _ugst.tradeBot[2] + _ugst.cryptoMiningTrojan[1] * _ugst.cryptoMiningTrojan[2]  + _ugst.cryptoPriceMisinfo[1] * _ugst.cryptoPriceMisinfo[2]  + _ugst.monkeyPng[1] * _ugst.monkeyPng[2]  + _ugst.topRaddit[1] * _ugst.topRaddit[2]  + _ugst.cryptoInfluencer[1] * _ugst.cryptoInfluencer[2]  + _ugst.bloodSacrifice[1] * _ugst.bloodSacrifice[2]  + _ugst.illuminatiMC[1] * _ugst.illuminatiMC[2]);

        timer += Time.deltaTime;

        if (timer >= 1.0f)
        {
            _bcs.points += cps;
        }
    }
}
