using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradesScriptThom : MonoBehaviour
{
    /// <summary>
    /// First element is current price.
    /// Second element is cps.
    /// Third element is how many the user has.
    /// </summary>
    [Header("UpgradeOptions")]
    public float[] gtx = new float[3] { 100, 2, 0 };
    public float[] ape = new float[3] { 500, 8, 0 };
    public float[] tradeBot = new float[3] { 1000, 12, 0 };
    public float[] cryptoMiningTrojan = new float[3] { 1750, 15, 0 };
    public float[] cryptoPriceMisinfo = new float[3] { 2300, 18, 0 };
    public float[] monkeyPng = new float[3] { 2800, 20, 0 };
    public float[] topRaddit = new float[3] { 5000, 0, 0 };
    public float[] cryptoInfluencer = new float[3] { 10000, 40, 0 };
    public float[] bloodSacrifice = new float[3] { 50000, 60, 0 };
    public float[] illuminatiMC = new float[3] { 100000, 125, 0 };



    public void BuyGtx()
    {
        Debug.Log("Bought 1 GTX");
        // Make gtx more expensive
        gtx[0] = Mathf.RoundToInt(gtx[0] * 1.2f);
        gtx[2]++;
        // debugging
        Debug.Log("Gtx amount is: " + gtx[2]);
        Debug.Log("Gtx price is: " + gtx[0]);
    }
    public void BuyApe()
    {
        Debug.Log("Bought 1 APE");
        // Make ape more expensive
        ape[0] = Mathf.RoundToInt(ape[0] * 1.2f);
        ape[2]++;
        // debugging
        Debug.Log("ape amount is: " + ape[2]);
        Debug.Log("ape price is: " + ape[0]);
    }
    public void BuyTradeBot()
    {
        Debug.Log("Bought 1 TRADEBOT");
        // Make tradebot more expensive
        tradeBot[0] = Mathf.RoundToInt(tradeBot[0] * 1.2f);
        tradeBot[2]++;
        // debugging
        Debug.Log("tradebot amount is: " + tradeBot[2]);
        Debug.Log("ape price is: " + tradeBot[0]);
    }
    public void BuyCryptoMiningTrojan()
    {
        Debug.Log("Bought 1 CRYPTOMININGTROJAN");
        // Make cryptoMiningTrojan more expensive
        cryptoMiningTrojan[0] = Mathf.RoundToInt(cryptoMiningTrojan[0] * 1.2f);
        cryptoMiningTrojan[2]++;
        // debugging
        Debug.Log("cryptoMiningTrojan amount is: " + cryptoMiningTrojan[2]);
        Debug.Log("cryptoMiningTrojan price is: " + cryptoMiningTrojan[0]);

    }
    public void BuyPriceMisInfo()
    {
        Debug.Log("Bought 1 PRICEMISINFO");
        // Make cryptoPriceMisinfo more expensive
        cryptoPriceMisinfo[0] = Mathf.RoundToInt(cryptoPriceMisinfo[0] * 1.2f);
        cryptoPriceMisinfo[2]++;
        // debugging
        Debug.Log("cryptoPriceMisinfo amount is: " + cryptoPriceMisinfo[2]);
        Debug.Log("cryptoPriceMisinfo price is: " + cryptoPriceMisinfo[0]);
    }
    public void BuyMonkeyPng()
    {
        Debug.Log("Bought 1 MONKEYPNG");
        // Make monkeyPng more expensive
        monkeyPng[0] = Mathf.RoundToInt(monkeyPng[0] * 1.2f);
        monkeyPng[2]++;
        // debugging
        Debug.Log("monkeyPng amount is: " + monkeyPng[2]);
        Debug.Log("monkeyPng price is: " + monkeyPng[0]);
    }
    public void BuyTopRaddit()
    {
        Debug.Log("Bought 1 TOPRADDIT");
        // Make topRaddit more expensive
        topRaddit[0] = Mathf.RoundToInt(topRaddit[0] * 1.2f);
        topRaddit[2]++;
        // debugging
        Debug.Log("topRaddit amount is: " + topRaddit[2]);
        Debug.Log("topRaddit price is: " + topRaddit[0]);
    }
    public void BuyCryptoInfluencer()
    {
        Debug.Log("Bought 1 cryptoInfluencer");
        // Make cryptoInfluencer more expensive
        cryptoInfluencer[0] = Mathf.RoundToInt(cryptoInfluencer[0] * 1.2f);
        cryptoInfluencer[2]++;
        // debugging
        Debug.Log("cryptoInfluencer amount is: " + cryptoInfluencer[2]);
        Debug.Log("cryptoInfluencer price is: " + cryptoInfluencer[0]);
    }
    public void BuyBloodSacrifice()
    {
        Debug.Log("Bought 1 BLOODSACRIFICE");
        // Make bloodSacrifice more expensive
        bloodSacrifice[0] = Mathf.RoundToInt(bloodSacrifice[0] * 1.2f);
        bloodSacrifice[2]++;
        // debugging
        Debug.Log("bloodSacrifice amount is: " + bloodSacrifice[2]);
        Debug.Log("bloodSacrifice price is: " + bloodSacrifice[0]);
    }
    public void BuyIlluminatiMC()
    {
        Debug.Log("Bought 1 ILLUMINATIMC");
        // Make illuminatiMC more expensive
        illuminatiMC[0] = Mathf.RoundToInt(illuminatiMC[0] * 1.2f);
        illuminatiMC[2]++;
        // debugging
        Debug.Log("illuminatiMC amount is: " + illuminatiMC[2]);
        Debug.Log("illuminatiMC price is: " + illuminatiMC[0]);
    }

}
