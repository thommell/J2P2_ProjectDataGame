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
    float[] gtx = new float[3] { 100, 2, 0 };
    float[] ape = new float[3] { 500, 8, 0 };
    float[] tradeBot = new float[3] { 1000, 12, 0 };
    float[] cryptoMiningTrojan = new float[3] { 1750, 15, 0 };
    float[] cryptoPriceMisinfo = new float[3] { 2300, 18, 0 };
    float[] monkeyPng = new float[3] { 2800, 20, 0 };
    float[] topRaddit = new float[3] { 5000, 0, 0 };
    float[] cryptoInfluencer = new float[3] { 10000, 40, 0 };
    float[] bloodSacrifice = new float[3] { 50000, 60, 0 };
    float[] illuminatiMC = new float[3] { 100000, 125, 0 };



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
    }
    public void BuyTradeBot()
    {
        Debug.Log("Bought 1 TRADEBOT");
    }
    public void BuyCryptoMiningTrojan()
    {
        Debug.Log("Bought 1 CRYPTOMININGTROJAN");
    }
    public void BuyPriceMisInfo()
    {
        Debug.Log("Bought 1 PRICEMISINFO");
    }
    public void BuyMonkeyPng()
    {
        Debug.Log("Bought 1 MONKEYPNG");
    }
    public void BuyTopRaddit()
    {
        Debug.Log("Bought 1 TOPRADDIT");
    }
    public void BuyCryptoInfluencer()
    {
        Debug.Log("Bought 1 CRYPTOINFLUENCER");
    }
    public void BuyBloodSacrifice()
    {
        Debug.Log("Bought 1 BLOODSACRIFICE");
    }
    public void BuyIlluminatiMC()
    {
        Debug.Log("Bought 1 ILLUMINATIMC");
    }

}
