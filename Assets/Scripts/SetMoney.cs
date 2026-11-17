using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetMoney : MonoBehaviour
{

    void Start()
    {
        GetComponent<TMP_Text>().text = PlayerPrefs.GetInt("CarCoins").ToString();
    }

    
}
