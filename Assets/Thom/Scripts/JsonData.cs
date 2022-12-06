using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[System.Serializable]
public class JsonData
{
    public float totalPoints;
    public int tappedData;
    public float timeData;
    public int winData;
    public int loseData;
    public int totalUpgradesData;

    [Header("GTX 9090 variables etc")]
    public int gtxCountData;
    public float gtxPriceData;
    public bool gtxActiveData;

    [Header("Crypto Ape")]
    public int apeCount;
    public float apePriceData;
    public bool apeActiveData;

    [Header("Trade Bot")]
    public int tradebotCount;
    public float tradebotPriceData;
    public bool tradebotActiveData;

    [Header("Crypto Mining Trojan")]
    public int cmtCount;
    public float cmtPriceData;
    public bool cmtActiveData;

    [Header("Monkey PNG")]
    public int monkeypngCount;
    public float monkeypngPriceData;
    public bool monkeypngActiveData;

    [Header("Top Raddit Cryptowins")]
    public int topradditCount;
    public float topradditPriceData;
    public bool topradditActiveData;

    [Header("Crypto Influencer")]
    public int cryptoInfCount;
    public float cryptoInfPriceData;
    public bool cryptoInfActiveData;

    [Header("Blood Sacrifice To The Crypto Gods")]
    public int bsttcgCount;
    public float bsttcgPriceData;
    public bool bsttcgActiveData;

    [Header("Illuminati Market Control")]
    public int illuminatiCount;
    public float illuminatiPriceData;
    public bool illuminatiActiveData;
}
