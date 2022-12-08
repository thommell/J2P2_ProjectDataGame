using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlanetRandomizer : MonoBehaviour
{
    private MinigameScore _mgs;

    private int resetAmount = 0;
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
      if(resetAmount < _mgs.wonMinigames)
        {
            RandomPlanet();
            resetAmount++;
        }
    }
}
