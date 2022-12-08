using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetRandomizer : MonoBehaviour
{
    private UpgradesScriptThom _ugst;
    private MinigameScore _mgs;
    public bool makePlanet = false;
    public bool minigameFail = false;


    public int resetAmount = 0;
    private int planetNum;
    private int ringNum;
    private int moonNum;
    private PlanetRandomizer instance;

    private void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
            DestroyImmediate(this.gameObject);
    }
    private void Start()
    {
        
        RandomPlanet();
    }
    private void RandomPlanet()
    {
        planetNum = Random.Range(1, 4);
        ringNum = Random.Range(1, 3);
        moonNum = Random.Range(1, 3);


        if (planetNum == 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(false);
            RandomColour(planetNum);
            SetMoonAndRing();

        }
        else if(planetNum == 2)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(false);
            RandomColour(planetNum);
            SetMoonAndRing();
        }
        else if (planetNum == 3)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(false);
            transform.GetChild(2).gameObject.SetActive(true);
            RandomColour(planetNum);
            SetMoonAndRing();
        }
    }
    private void RandomColour(int childNum)
    {
        transform.GetChild(childNum - 1).gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }
    private void SetMoonAndRing()
    {
        if (moonNum == 1)
        {
            transform.GetChild(3).gameObject.SetActive(true);
            RandomColour(4);
        }
        else
        {
            transform.GetChild(3).gameObject.SetActive(false);
        }

        if(ringNum == 1)
        {
            transform.GetChild(4).gameObject.SetActive(true);
            RandomColour(5);
        }
        else
        {
            transform.GetChild(4).gameObject.SetActive(false);
        }

    }
    
    private void Update()
    {
        _ugst = FindObjectOfType<UpgradesScriptThom>();
        if (makePlanet)
        {
            _ugst.gtx[2] = 0;
            _ugst.ape[2] = 0;
            _ugst.tradeBot[2] = 0;
            _ugst.cryptoMiningTrojan[2] = 0;
            _ugst.cryptoPriceMisinfo[2] = 0;
            _ugst.monkeyPng[2] = 0;
            _ugst.topRaddit[2] = 0;
            _ugst.cryptoInfluencer[2] = 0;
            _ugst.bloodSacrifice[2] = 0;
            _ugst.illuminatiMC[2] = 0;
            minigameFail = false;
            makePlanet = false;
            RandomPlanet();
            resetAmount++;
            
        }

        if (minigameFail)
        {
            _ugst.gtx[2] = 0;
            _ugst.ape[2] = 0;
            _ugst.tradeBot[2] = 0;
            _ugst.cryptoMiningTrojan[2] = 0;
            _ugst.cryptoPriceMisinfo[2] = 0;
            _ugst.monkeyPng[2] = 0;
            _ugst.topRaddit[2] = 0;
            _ugst.cryptoInfluencer[2] = 0;
            _ugst.bloodSacrifice[2] = 0;
            _ugst.illuminatiMC[2] = 0;
            minigameFail = false;
        }
    }
}
