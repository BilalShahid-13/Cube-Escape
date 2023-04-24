using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

[System.Serializable]
struct sc
{
    public TMP_Text score,highscore;
    public int dec;
    public Transform player;
}
public class score : MonoBehaviour
{
    [SerializeField] sc s1 = new sc();
    private void FixedUpdate()
    {
        
        s1.dec = Convert.ToInt32(s1.player.position.z);
        Display();
        SaveText();
    }
    private void Start()
    {
        s1.highscore.text = PlayerPrefs.GetFloat("HighScore",0).ToString();
    }
    void Display()
    {
        s1.score.text = s1.player.position.z.ToString("0");
        //s1.highscore.text = s1.score.text;
    }
    void SaveText()
    {
        if(s1.dec > PlayerPrefs.GetFloat("HighScore",0))
        {
            PlayerPrefs.SetFloat("HighScore", s1.dec);
        }
        
    }
}
