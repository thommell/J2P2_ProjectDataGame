using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using JetBrains.Annotations;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] PlanetRandomizer _pr;
    [SerializeField] UpgradesScriptThom _ugst;
    [SerializeField] CryptoManager _cm;
    [SerializeField] BasicClickSystem _bcs;

   // [SerializeField] ReadFromJson _rfj;
    private void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
            DestroyImmediate(this.gameObject);

       /* if (File.Exists (Application.dataPath + "/PlayerDataFile.json")) 
        {
            if (_ugst != null)
            {
                string json = File.ReadAllText(Application.dataPath + "/PlayerDataFile.json");
                JsonData data = JsonUtility.FromJson<JsonData>(json);

                _ugst.gtx[2] = data.gtxCountData;
                _ugst.gtx[0] = data.gtxPriceData;

                _ugst.ape[2] = data.apeCount;
                _ugst.ape[0] = data.apePriceData;

                _ugst.tradeBot[2] = data.tradebotCount;
                _ugst.tradeBot[0] = data.tradebotPriceData;

                _ugst.cryptoPriceMisinfo[2] = data.cpmCount;
                _ugst.cryptoPriceMisinfo[0] = data.cpmPriceData;


                _ugst.cryptoMiningTrojan[2] = data.cmtCount;
                _ugst.cryptoMiningTrojan[0] = data.cmtPriceData;

                _ugst.monkeyPng[2] = data.monkeypngCount;
                _ugst.monkeyPng[0] = data.monkeypngPriceData;

                _ugst.topRaddit[2] = data.topradditCount;
                _ugst.topRaddit[0] = data.topradditPriceData;

                _ugst.cryptoInfluencer[2] = data.cryptoInfCount;
                _ugst.cryptoInfluencer[0] = data.cryptoInfPriceData;

                _ugst.bloodSacrifice[2] = data.bsttcgCount;
                _ugst.bloodSacrifice[0] = data.bsttcgPriceData;

                _ugst.illuminatiMC[2] = data.illuminatiCount;
                _ugst.illuminatiMC[0] = data.illuminatiPriceData;

                _bcs.points = data.points;
                _cm.cps = data.cps;
                _pr.resetAmount = data.planetAmount;

                // Link to method LoadFromJason
            }
        }
        else
        {*/
            // Create JsonFile with all the data
           
            JsonData data = new JsonData();

            data.gtxCountData = 0;
            data.gtxPriceData = 0;

            data.apeCount = 0;
            data.apePriceData = 0;

            data.tradebotCount = 0;
            data.tradebotPriceData = 0;

            data.cpmCount = 0;
            data.cpmPriceData = 0;


            data.cmtCount = 0;
            data.cmtPriceData = 0;

            data.monkeypngCount = 0;
            data.monkeypngPriceData = 0;

            data.topradditCount = 0;
            data.topradditPriceData= 0;

            data.cryptoInfCount = 0;
            data.cryptoInfPriceData = 0;

            data.bsttcgCount = 0;
            data.bsttcgPriceData = 0;

            data.illuminatiCount = 0;
            data.illuminatiPriceData= 0;

            data.points = 0;
            data.points = 0;
            data.planetAmount = 0;

            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(Application.dataPath + "/PlayerDataFile.json", json);
        //}
    }
    private void Update()
    {
        _pr = FindObjectOfType<PlanetRandomizer>();
        _bcs = FindObjectOfType<BasicClickSystem>();
        _ugst = FindObjectOfType<UpgradesScriptThom>();
        _cm = FindObjectOfType<CryptoManager>();

        if (_ugst = null)
        {
            JsonData data = new JsonData();
            data.gtxCountData = _ugst.gtx[2];
            data.gtxPriceData = _ugst.gtx[0];

            data.apeCount = _ugst.ape[2];
            data.apePriceData = _ugst.ape[0];

            data.tradebotCount = _ugst.tradeBot[2];
            data.tradebotPriceData = _ugst.tradeBot[0];

            data.cpmCount = _ugst.cryptoPriceMisinfo[2];
            data.cpmPriceData = _ugst.cryptoPriceMisinfo[0];


            data.cmtCount = _ugst.cryptoMiningTrojan[2];
            data.cmtPriceData = _ugst.cryptoMiningTrojan[0];

            data.monkeypngCount = _ugst.monkeyPng[2];
            data.monkeypngPriceData = _ugst.monkeyPng[0];

            data.topradditCount = _ugst.topRaddit[2];
            data.topradditPriceData = _ugst.topRaddit[0];

            data.cryptoInfCount = _ugst.cryptoInfluencer[2];
            data.cryptoInfPriceData = _ugst.cryptoInfluencer[0];

            data.bsttcgCount = _ugst.bloodSacrifice[2];
            data.bsttcgPriceData = _ugst.bloodSacrifice[0];

            data.illuminatiCount = _ugst.illuminatiMC[2];
            data.illuminatiPriceData = _ugst.illuminatiMC[0];

            data.points = _bcs.points;
            data.points = _cm.cps;
            data.planetAmount = _pr.resetAmount;

            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(Application.dataPath + "/PlayerDataFile.json", json);
        }
    }
}
