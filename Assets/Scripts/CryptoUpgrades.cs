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
    [SerializeField] int GTX = 0;
    public TextMeshProUGUI displayGTXPrice;
    public float gtxPrice = 100f;
    bool gtxActive = false;

    [Header("Crypto Ape")]
    public Button CryptoApe;
    [SerializeField] int ape = 0;
    public TextMeshProUGUI displayApePrice;
    float apePrice = 500f;
    bool apeActive = false;

    [Header("Trade Bot")]
    public Button TradeBot;
    [SerializeField] int bot = 0;
    public TextMeshProUGUI displayBotPrice;
    float botPrice = 1000f;
    bool botActive = false;




    public Button MiningTrojan;
    [SerializeField] int trojan = 0;
    public TextMeshProUGUI displayTrojanPrice;
    float trojanPrice = 1750f;
    bool trojanActive = false;

    [Header("Crypto Price Misinformation")]
    public Button Misinformation;
    [SerializeField] int mis = 0;
    public TextMeshProUGUI displayMisinformationPrice;
    float misinformationPrice = 2300;
    bool misinformationActive = false;

    [Header("Monkey PNG")]
    public Button MonkeyPNG;
    [SerializeField] int png = 0;
    public TextMeshProUGUI displayPNGPrice;
    float monkeyPrice = 3000f;
    bool monkeyActive = false;

    [Header("Top Raddit Cryptowins")]
    public Button TopRadditCryptowins;
    [SerializeField] int top = 0;
    public TextMeshProUGUI displayRadditPrice;
    float radditPrice = 5000f;
    bool RadditActive = false;

    [Header("Crypto Influencer")]
    public Button CryptoInfluencer;
    [SerializeField] int crypto = 0;
    public TextMeshProUGUI displayInfluencerPrice;
    float influencerPrice = 12500f;
    bool influencerActive = false;

    [Header("Blood Sacrifice To The Crypto Gods")]
    public Button BloodSacrificeTTCG;
    [SerializeField] int blood = 0;
    public TextMeshProUGUI displayBSTTCGPrice;
    float bsttcgPrice = 50000f;
    bool bloodActive = false;

    [Header("Illuminati Market Control")]
    public Button IlluminatiMarketControl;
    [SerializeField] int market = 0;
    public TextMeshProUGUI displayMarketPrice;
    float illuminatiPrice = 100000f;
    bool illuminatiActive = false;

    private float autoPeriod = 0.0f;
    private float period = 0.0f;
    private float period2 = 0.0f;
    private float period3 = 0.0f;
    private float period4 = 0.0f;
    private float totalAutoPoints;
    public TextMeshProUGUI displayTotalAutoPoints;

    void Update()
    {
        displayGTXPrice.text = ("? ") + System.Math.Round(gtxPrice) + ("   Level   " + GTX).ToString();
        displayApePrice.text = ("? ") + System.Math.Round(apePrice) + ("   Level   " + ape).ToString();
        displayBotPrice.text = ("? ") + System.Math.Round(botPrice) + ("   Level   " + bot).ToString();
        displayTrojanPrice.text = ("? ") + System.Math.Round(trojanPrice) + ("   Level   " + trojan).ToString();
        displayMisinformationPrice.text = ("? ") + System.Math.Round(misinformationPrice) + ("   Level   " + mis).ToString();
        displayPNGPrice.text = ("? ") + System.Math.Round(monkeyPrice) + ("   Level   " + png).ToString();
        displayRadditPrice.text = ("? ") + System.Math.Round(radditPrice) + ("   Level   " + top).ToString();
        displayInfluencerPrice.text = ("? ") + System.Math.Round(influencerPrice) + ("   Level   " + crypto).ToString();
        displayBSTTCGPrice.text = ("? ") + System.Math.Round(bsttcgPrice) + ("   Level   " + blood).ToString();
        displayMarketPrice.text = ("? ") + System.Math.Round(illuminatiPrice) + ("   Level   " + market).ToString();
        displayTotalAutoPoints.text = System.Math.Round(totalAutoPoints).ToString();

        if (autoPeriod > 1f)
        {
            if (trojanActive == true)
            {
                if (trojan < 5)
                {
                    script.points += trojan * 2.5f;
                    totalAutoPoints += trojan * 2.5f;
                }
                else
                    script.points += trojan * 3.5f;
            }
            if (illuminatiActive == true)
            {
                script.points += market * 100f;
                totalAutoPoints += market * 100f;
            }
            autoPeriod = 0;
        }
        if (period > 2.5f)
        {
            if (gtxActive == true)
            {
                script.points += GTX * 4f;
                totalAutoPoints += GTX * 4f / 2.5f;
            }
            if (apeActive == true)
            {
                script.points += ape * 10f;
                totalAutoPoints += ape * 10f / 2.5f;
            }
            if (botActive == true)
            {
                if (bot < 3)
                {
                    script.points += bot * 12.5f;
                    totalAutoPoints += ape * 12.5f / 2.5f;
                }
                else
                    script.points += bot * 15.5f;
                totalAutoPoints += ape * 15.5f / 2.5f;
            }
            period = 0;
        }

        if (period2 > 7.5f)
        {
            
            if (misinformationActive == true)
            {
                script.points += mis * 50f;
                totalAutoPoints += mis * 50f / 7.5f;
            }
            period2 = 0;
        }

        if (period3 > 15f)
        {
            if (monkeyActive == true)
            {
                script.points += png * 125f;
                totalAutoPoints += png * 125f / 15f;
            }
            if (RadditActive == true)
            {
                script.points += top * 300f;
                totalAutoPoints += top * 300f / 15f;
            }
            if (influencerActive == true)
            {
                script.points += crypto * 350f;
                totalAutoPoints += crypto * 350f / 15f;

            }
            period3 = 0;
        }
        if (period4 > 30f)
        {
            if (bloodActive == true)
            {
                script.points += blood * 1000f;
                totalAutoPoints += blood * 1000f / 30f;
            }
            period4 = 0;
        }

        autoPeriod += UnityEngine.Time.deltaTime;
        period += UnityEngine.Time.deltaTime;
        period2 += UnityEngine.Time.deltaTime;
        period3 += UnityEngine.Time.deltaTime;
        period4 += UnityEngine.Time.deltaTime;
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
        if (GTX >= 1)
        {
            gtxActive = true;
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
        if (ape >= 1)
        {
            apeActive = true;
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
        if (bot >= 1)
        {
            botActive = true;
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
        if (trojan >= 1)
        {
            trojanActive = true;
        }
    }

    public void ButtonCryptoPriceMisinformation()
    {
        if (script.points > misinformationPrice)
        {
            script.points -= misinformationPrice;
            if (mis < 3)
            {
                misinformationPrice = misinformationPrice * 1.125f;
                mis++;
            }
            else
                misinformationPrice = misinformationPrice * 1.25f;
            mis++;
        }
        if (mis >= 1)
        {
            misinformationActive = true;
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
        if (png >= 1)
        {
            monkeyActive = true;
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
        if (top >= 1)
        {
            RadditActive = true;
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
        if (crypto >= 1)
        {
            influencerActive = true;
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
        if (blood >= 1)
        {
            bloodActive = true;
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
        if (market >= 1)
        {
            illuminatiActive = true;
        }
    }
}
