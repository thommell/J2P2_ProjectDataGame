using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CryptoUpgrades : MonoBehaviour
{
   
    public BasicClickSystem script;
  

    [Header("GTX 9090 variables etc")]
    public Button GTX9090;
    int GTX = 0;
    public TextMeshProUGUI displayGTXPrice;
    public float gtxPrice = 100f;

    [Header("Crypto Ape")]
    public Button CryptoApe;
    int ape = 0;
    public TextMeshProUGUI displayApePrice;
    float apePrice = 500f;

    [Header("Trade Bot")]
    public Button TradeBot;
    int bot = 0;
    public TextMeshProUGUI displayBotPrice;
    float botPrice = 1000f;

    [Header("Crypto Mining Trojan")]
    public Button MiningTrojan;
    int trojan = 0;
    public TextMeshProUGUI displayTrojanPrice;
    float trojanPrice = 1750f;

    [Header("Crypto Price Misinformation")]
    public Button Misinformation;
    int mis = 0;
    public TextMeshProUGUI displayMisinformationPrice;
    float misinformationPrice = 2300;

    [Header("Monkey PNG")]
    public Button MonkeyPNG;
    int png = 0;
    public TextMeshProUGUI displayPNGPrice;
    float monkeyPrice = 3000f;

    [Header("Top Raddit Cryptowins")]
    public Button TopRadditCryptowins;
    int top = 0;
    public TextMeshProUGUI displayRadditPrice;
    float radditPrice = 5000f;

    [Header("Crypto Influencer")]
    public Button CryptoInfluencer;
    int crypto = 0;
    public TextMeshProUGUI displayInfluencerPrice;
    float influencerPrice = 12500f;

    [Header("Blood Sacrifice To The Crypto Gods")]
    public Button BloodSacrificeTTCG;
    int blood = 0;
    public TextMeshProUGUI displayBSTTCGPrice;
    float bsttcgPrice = 50000f;

    [Header("Illuminati Market Control")]
    public Button IlluminatiMarketControl;
    int market = 0;
    public TextMeshProUGUI displayMarketPrice;
    float illuminatiPrice = 100000f;


   
    void Update()
    {

        displayGTXPrice.text = System.Math.Round(gtxPrice) + ("   Level   " + GTX).ToString();
        displayApePrice.text = System.Math.Round(apePrice) + ("   Level   " + ape).ToString();
        displayBotPrice.text = System.Math.Round(botPrice) + ("   Level   " + bot).ToString();
        displayTrojanPrice.text = System.Math.Round(trojanPrice) + ("   Level   " + trojan).ToString();
        displayMisinformationPrice.text = System.Math.Round(misinformationPrice) + ("   Level   " + mis).ToString();
        displayPNGPrice.text = System.Math.Round(monkeyPrice) + ("   Level   " + png).ToString();
        displayRadditPrice.text = System.Math.Round(radditPrice) + ("   Level   " + top).ToString();
        displayInfluencerPrice.text = System.Math.Round(influencerPrice) + ("   Level   " + crypto).ToString();
        displayBSTTCGPrice.text = System.Math.Round(bsttcgPrice) + ("   Level   " + blood).ToString();
        displayMarketPrice.text = System.Math.Round(illuminatiPrice) + ("   Level   " + market).ToString();
    }
    public void ButtonGTX9090()
    {
       if (script.points > gtxPrice)
       {
            script.points -= gtxPrice;
            Debug.Log("upgradeprice = " + gtxPrice);
            gtxPrice = gtxPrice * 1.2f;
            GTX++;
            Debug.Log("GTX9090 lvl: " + GTX);          
        }     
    }
    public void ButtonCryptoApe()
    {
        if (script.points > apePrice)
        {
            script.points -= apePrice;
            Debug.Log("upgradeprice = " + apePrice);
            apePrice = apePrice * 1.2f;
            ape++;
        }  
    }

    public void ButtonTradeBot()
    {
        if (script.points > botPrice)
        {
            script.points -= botPrice;
            Debug.Log("upgradeprice = " + botPrice);
            botPrice = botPrice * 1.15f;
            bot++;
        }
    }

    public void ButtonCryptoMiningTrojan()
    {
        if (script.points > trojanPrice)
        {
            script.points -= trojanPrice;
            Debug.Log("upgradeprice = " + trojanPrice);
            trojanPrice = trojanPrice * 1.15f;
            trojan++;
        }
    }

    public void ButtonCryptoPriceMisinformation()
    {
        if (script.points > misinformationPrice)
        {
            script.points -= misinformationPrice;
            misinformationPrice = misinformationPrice * 1.125f;
            mis++;
        }
    }

    public void ButtonMonkeyPNG()
    {
        if (script.points > monkeyPrice)
        {
            script.points -= monkeyPrice;
            monkeyPrice = monkeyPrice * 1.175f;
            png++;
        }
    }

    public void ButtonTopRadditCryptowins()
    {
        if (script.points > radditPrice)
        {
            script.points -= radditPrice;
            radditPrice = radditPrice * 1.1625f;
            top++;
        }
    }

    public void ButtonCryptoInfluencer()
    {
        if (script.points > influencerPrice)
        {
            script.points -= influencerPrice;
            influencerPrice = influencerPrice * 1.2f;
            crypto++;
        }
    }

    public void ButtonBloodSacrificeToTheCryptoGods()
    {
        if (script.points > bsttcgPrice)
        {
            script.points -= bsttcgPrice;
            bsttcgPrice = bsttcgPrice * 1.225f;
            blood++;
        }
    }

    public void ButtonIlluminatiMarketControl()
    {
        if (script.points > illuminatiPrice)
        {
            script.points -= illuminatiPrice;
            illuminatiPrice = illuminatiPrice * 1.25f;
            market++;
        }
    }
}
