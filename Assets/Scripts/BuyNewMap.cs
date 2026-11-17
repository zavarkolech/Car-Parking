using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyNewMap : MonoBehaviour

{
    public TMP_Text CountCoins;
    public void BuyMap (int price)
    {
        if(PlayerPrefs.GetInt("CarCoins") >= price)
        {
            PlayerPrefs.SetInt("CarCoins", PlayerPrefs.GetInt("CarCoins") - price);
            PlayerPrefs.SetString("NowMap", "Cyber");
            CountCoins.text = PlayerPrefs.GetInt("CarCoins").ToString();
        }
    }
}
