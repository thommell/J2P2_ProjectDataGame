using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CryptoUpgrades : MonoBehaviour
{
    public BasicClickSystem script;
    [Header("GTX 9090 variables etc")]
    public Button GTX9090;
    float[] upgradePricesGTX9090 = { 100, 120, 144, 173, 207, 249, 299, 358, 430, 516, 1032 };
    int GTX = 0;
    
    [Header("Crypto Ape")]
    public Button CryptoApe;
    float[] upgradePricesCryptoApe = { 500, 600, 720, 864, 1037, 1244, 1493, 1792, 2150, 2580, 5160 };
    int ape = 0;

    [Header("Trade Bot")]
    public Button TradeBot;
    float[] upgradePricesTradeBot = {1000, 1150, 1323, 1521, 1749, 2011, 2313, 2660, 3059, 3518, 7036 };
    int bot = 0;

    [Header("Crypto Mining Trojan")]
    public Button MiningTrojan;
    float[] upgradePricesCryptoMiningTrojan = {1750, 2013, 2314, 2662, 3061, 3520, 4048, 4655, 5353, 6156, 12312 };
    int trojan = 0;

    [Header("Crypto Price Misinformation")]
    public Button Misinformation;
    float[] upgradePricesCryptoPriceMisinformation = {2300, 2588, 2911, 3275, 3684, 4145, 4663, 5246, 5901, 6639, 13278 };
    int mis = 0;

    [Header("Monkey PNG")]
    public Button MonkeyPNG;
    float[] upgradePricesMonkeyPNG = {2800, 3290, 3866, 4542, 5337, 6271, 7369, 8658, 10173, 11954, 23907 };
    int png = 0;

    [Header("Top Raddit Cryptowins")]
    public Button TopRadditCryptowins;
    float[] upgradePricesTopRadditCryptowins = { 5000, 5813, 6757, 7855, 9132, 10615, 12340, 14345, 16677, 19387, 38774 };
    int top = 0;

    [Header("Crypto Influencer")]
    public Button CryptoInfluencer;
    float[] upgradePricesCryptoInfluencer = {10000, 12000, 14400, 20736, 24883, 29860, 35832, 42998, 51598, 61917, 123835  };
    int crypto = 0;

    [Header("Blood Sacrifice To The Crypto Gods")]
    public Button BloodSacrificeTTCG;
    float[] upgradePricesBloodSacrificeToTheCryptoGods = {50000, 60000, 72000, 86400, 103680, 124416, 149299, 179159, 214991, 257989, 515978  };
    int blood = 0;

    [Header("Illuminati Market Control")]
    public Button IlluminatiMarketControl;
    float[] upgradePricesIlluminatiMarketControl = {125000, 156250, 195513, 244141, 305176, 381470, 476837, 595046, 745058, 931323, 2000000 };
    int market = 0;


    public void ButtonGTX9090()
    {
        if(script.points > upgradePricesGTX9090[GTX])
        {
            script.points -= upgradePricesGTX9090[GTX];          
            Debug.Log("upgradeprice = " + upgradePricesGTX9090[GTX]);
            GTX++;
        }
        if (GTX == upgradePricesGTX9090.Length)
        {
            Debug.Log("uitgespeeld");
            GTX9090.interactable = false;
        }

      
    }

    public void ButtonCryptoApe()
    {
        if (script.points > upgradePricesCryptoApe[ape])
        {
            script.points -= upgradePricesCryptoApe[ape];
            Debug.Log("upgradeprice = " + upgradePricesCryptoApe[ape]);
            ape++;
        }
        if (ape == upgradePricesCryptoApe.Length)
        {
            Debug.Log("uitgespeeld");
            CryptoApe.interactable = false;
        }
    }

    public void ButtonTradeBot()
    {

    }

    public void ButtonCryptoMiningTrojan()
    {

    }

    public void ButtonCryptoPriceMisinformation()
    {

    }

    public void ButtonMonkeyPNG()
    {

    }

    public void ButtonTopRadditCryptowins()
    {

    }
    
    public void ButtonCryptoInfluencer()
    {

    }

    public void ButtonBloodSacrificeToTheCryptoGods()
    {

    }
    
    public void ButtonIlluminatiMarketControl()
    {

    }
}
