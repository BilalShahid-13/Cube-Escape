using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_selector : MonoBehaviour
{
    [SerializeField] Button[] buttons;
    int LevelReached;

    private void Start()
    {
        LevelReached = PlayerPrefs.GetInt("Level", 1);
        for(int i=0; i<buttons.Length; i++)
        {
            if(i+1 > LevelReached)
            buttons[i].interactable = false;
        }
    }
}
