
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
    float[] upgradePricesTradeBot = { 1000, 1150, 1323, 1521, 1749, 2011, 2313, 2660, 3059, 3518, 7036 };
    int bot = 0;

    [Header("Crypto Mining Trojan")]
    public Button MiningTrojan;
    float[] upgradePricesCryptoMiningTrojan = { 1750, 2013, 2314, 2662, 3061, 3520, 4048, 4655, 5353, 6156, 12312 };
    int trojan = 0;

    [Header("Crypto Price Misinformation")]
    public Button Misinformation;
    float[] upgradePricesCryptoPriceMisinformation = { 2300, 2588, 2911, 3275, 3684, 4145, 4663, 5246, 5901, 6639, 13278 };
    int mis = 0;

    [Header("Monkey PNG")]
    public Button MonkeyPNG;
    float[] upgradePricesMonkeyPNG = { 2800, 3290, 3866, 4542, 5337, 6271, 7369, 8658, 10173, 11954, 23907 };
    int png = 0;

    [Header("Top Raddit Cryptowins")]
    public Button TopRadditCryptowins;
    float[] upgradePricesTopRadditCryptowins = { 5000, 5813, 6757, 7855, 9132, 10615, 12340, 14345, 16677, 19387, 38774 };
    int top = 0;

    [Header("Crypto Influencer")]
    public Button CryptoInfluencer;
    float[] upgradePricesCryptoInfluencer = { 10000, 12000, 14400, 20736, 24883, 29860, 35832, 42998, 51598, 61917, 123835 };
    int crypto = 0;

    [Header("Blood Sacrifice To The Crypto Gods")]
    public Button BloodSacrificeTTCG;
    float[] upgradePricesBloodSacrificeToTheCryptoGods = { 50000, 60000, 72000, 86400, 103680, 124416, 149299, 179159, 214991, 257989, 515978 };
    int blood = 0;

    [Header("Illuminati Market Control")]
    public Button IlluminatiMarketControl;
    float[] upgradePricesIlluminatiMarketControl = { 125000, 156250, 195513, 244141, 305176, 381470, 476837, 595046, 745058, 931323, 2000000 };
    int market = 0;


    public void ButtonGTX9090()
    {
        if (script.points > upgradePricesGTX9090[GTX])
        {
            script.points -= upgradePricesGTX9090[GTX];
            Debug.Log("upgradeprice = " + upgradePricesGTX9090[GTX]);
            GTX++;
            Debug.Log("GTX9090" + GTX);
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
            Debug.Log("CryptoApe" + ape);
        }
        if (ape == upgradePricesCryptoApe.Length)
        {
            Debug.Log("uitgespeeld");
            CryptoApe.interactable = false;
        }
    }

    public void ButtonTradeBot()
    {
        if (script.points > upgradePricesTradeBot[bot])
        {
            script.points -= upgradePricesCryptoApe[bot];
            Debug.Log("upgradeprice = " + upgradePricesTradeBot[bot]);
            bot++;
            Debug.Log("TradeBot" + bot);
        }
        if (ape == upgradePricesTradeBot.Length)
        {
            Debug.Log("uitgespeeld");
            TradeBot.interactable = false;
        }

    }

    public void ButtonCryptoMiningTrojan()
    {
        if (script.points > upgradePricesCryptoMiningTrojan[trojan])
        {
            script.points -= upgradePricesCryptoMiningTrojan[trojan];
            Debug.Log("upgradeprice = " + upgradePricesCryptoMiningTrojan[trojan]);
            trojan++;
            Debug.Log("CryptoMiningTrojan" + trojan);
        }
        if (trojan == upgradePricesCryptoMiningTrojan.Length)
        {
            Debug.Log("uitgespeeld");
            MiningTrojan.interactable = false;
        }

    }

    public void ButtonCryptoPriceMisinformation()
    {
        if (script.points > upgradePricesCryptoPriceMisinformation[mis])
        {
            script.points -= upgradePricesCryptoPriceMisinformation[mis];            
            mis++;
            Debug.Log("CryptoPriceMisInformation" + mis);
        }
        if (mis == upgradePricesCryptoPriceMisinformation.Length)
        {
            Debug.Log("uitgespeeld");
            Misinformation.interactable = false;
        }

    }

    public void ButtonMonkeyPNG()
    {
        if (script.points > upgradePricesMonkeyPNG[png])
        {
            script.points -= upgradePricesMonkeyPNG[png];
            png++;
         //   Debug.Log("CryptoPriceMisInformation" + );
        }
        if (png == upgradePricesMonkeyPNG.Length)
        {
            Debug.Log("uitgespeeld");
            MonkeyPNG.interactable = false;
        }

    }

    public void ButtonTopRadditCryptowins()
    {
        if (script.points > upgradePricesTopRadditCryptowins[top])
        {
            script.points -= upgradePricesTopRadditCryptowins[top];
            top++;
            //   Debug.Log("CryptoPriceMisInformation" + );
        }
        if (top == upgradePricesTopRadditCryptowins.Length)
        {
            Debug.Log("uitgespeeld");
            TopRadditCryptowins.interactable = false;
        }
    }

    public void ButtonCryptoInfluencer()
    {
        if (script.points > upgradePricesCryptoInfluencer[crypto])
        {
            script.points -= upgradePricesCryptoInfluencer[crypto];
            crypto++;
            //   Debug.Log("CryptoPriceMisInformation" + );
        }
        if (crypto == upgradePricesCryptoInfluencer.Length)
        {
            Debug.Log("uitgespeeld");
            CryptoInfluencer.interactable = false;
        }
    }

    public void ButtonBloodSacrificeToTheCryptoGods()
    {
        if (script.points > upgradePricesBloodSacrificeToTheCryptoGods[blood])
        {
            script.points -= upgradePricesBloodSacrificeToTheCryptoGods[blood];
            blood++;
            //   Debug.Log("CryptoPriceMisInformation" + );
        }
        if (blood == upgradePricesBloodSacrificeToTheCryptoGods.Length)
        {
            Debug.Log("uitgespeeld");
            BloodSacrificeTTCG.interactable = false;
        }

    }

    public void ButtonIlluminatiMarketControl()
    {
        if (script.points > upgradePricesIlluminatiMarketControl[market])
        {
            script.points -= upgradePricesIlluminatiMarketControl[market];
            market++;
            //   Debug.Log("CryptoPriceMisInformation" + );
        }
        if (market == upgradePricesIlluminatiMarketControl.Length)
        {
            Debug.Log("uitgespeeld");
            IlluminatiMarketControl.interactable = false;
        }

    }
  
}
