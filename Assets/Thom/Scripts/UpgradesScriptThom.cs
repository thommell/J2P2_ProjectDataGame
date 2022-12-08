using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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

    [Header("Links to price display")]
    public TextMeshProUGUI gtxPrice;
    public TextMeshProUGUI apePrice;
    public TextMeshProUGUI tradeBotPrice;
    public TextMeshProUGUI trojanPrice;
    public TextMeshProUGUI misinfoPrice;
    public TextMeshProUGUI monkeyPrice;
    public TextMeshProUGUI radditPrice;
    public TextMeshProUGUI influencerPrice;
    public TextMeshProUGUI bloodPrice;
    public TextMeshProUGUI illuminatiPrice;



    [SerializeField] BasicClickSystem _bcs;
    public float cps;
    public void Update()
    {
        gtxPrice.text = ("€ ") + System.Math.Round(gtx[0]) + ("   Level   " + gtx[2]).ToString();  
        apePrice.text = ("€ ") + System.Math.Round(ape[0]) + ("   Level   " + ape[2]).ToString();
        tradeBotPrice.text = ("€ ") + System.Math.Round(tradeBot[0]) + ("   Level   " + tradeBot[2]).ToString();
        trojanPrice.text = ("€ ") + System.Math.Round(cryptoMiningTrojan[0]) + ("   Level   " + cryptoMiningTrojan[2]).ToString();
        misinfoPrice.text = ("€ ") + System.Math.Round(cryptoPriceMisinfo[0]) + ("   Level   " + cryptoPriceMisinfo[2]).ToString();
        monkeyPrice.text = ("€ ") + System.Math.Round(monkeyPng[0]) + ("   Level   " + monkeyPng[2]).ToString();
        radditPrice.text = ("€ ") + System.Math.Round(topRaddit[0]) + ("   Level   " + topRaddit[2]).ToString();
        influencerPrice.text = ("€ ") + System.Math.Round(cryptoInfluencer[0]) + ("   Level   " + cryptoInfluencer[2]).ToString();
        bloodPrice.text = ("€ ") + System.Math.Round(bloodSacrifice[0]) + ("   Level   " + bloodSacrifice[2]).ToString();
        illuminatiPrice.text = ("€ ") + System.Math.Round(illuminatiMC[0]) + ("   Level   " + illuminatiMC[2]).ToString();

        cps = (gtx[1] * gtx[2] + ape[1] * ape[2] + tradeBot[1] * tradeBot[2] + cryptoMiningTrojan[1] * cryptoMiningTrojan[2] + cryptoPriceMisinfo[1] * cryptoPriceMisinfo[2] + monkeyPng[1] * monkeyPng[2] + topRaddit[1] * topRaddit[2] + cryptoInfluencer[1] * cryptoInfluencer[2] + bloodSacrifice[1] * bloodSacrifice[2] + illuminatiMC[1] * illuminatiMC[2]);
        Debug.Log("cps =  " + cps);

    }
    public void BuyGtx()
    {
        Debug.Log("Bought 1 GTX");
        // Make gtx more expensive
        _bcs.points = _bcs.points - gtx[0];
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
        _bcs.points = _bcs.points - ape[0];
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
        _bcs.points = _bcs.points - tradeBot[0];
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
        _bcs.points = _bcs.points - cryptoMiningTrojan[0];
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
        _bcs.points = _bcs.points - cryptoPriceMisinfo[0];
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
        _bcs.points = _bcs.points - monkeyPng[0];
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
        _bcs.points = _bcs.points - topRaddit[0];
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
        _bcs.points = _bcs.points - cryptoInfluencer[0];
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
        _bcs.points = _bcs.points - bloodSacrifice[0];
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
        _bcs.points = _bcs.points - illuminatiMC[0];
        illuminatiMC[0] = Mathf.RoundToInt(illuminatiMC[0] * 1.2f);
        illuminatiMC[2]++;
        // debugging
        Debug.Log("illuminatiMC amount is: " + illuminatiMC[2]);
        Debug.Log("illuminatiMC price is: " + illuminatiMC[0]);
    }

}
