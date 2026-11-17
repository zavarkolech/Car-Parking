using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectLevel : MonoBehaviour
{
    public TMP_Text CountMoves;

    [Serializable]
    public struct Levels
    {
        public GameObject level;
        public int moves;
    }
    public Levels[] levels;
        
    
    void Start()
    {
        if(!PlayerPrefs.HasKey("Game Level")) PlayerPrefs.SetInt("Game Level", 1);
        Levels now = levels[PlayerPrefs.GetInt("Game Level") - 1];
        now.level.SetActive(true); 
        CountMoves.text = now.moves.ToString();
    }

}
