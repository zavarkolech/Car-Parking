using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetCurrentLevel : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<TMP_Text>().text = "#" + PlayerPrefs.GetInt("Game Level");
    }

    
}