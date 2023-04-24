using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    [SerializeField] AudioSource idle,hit;
    bool sfx;

    private void Awake()
    {
        sfx = true;
        PlayerPrefs.SetInt("Sfx", (sfx ? 1 : 0));
        sfx = true;
        idle.Play();
    }
    public void play_on()
    {
        sfx = true;
        PlayerPrefs.SetInt("Sfx", (sfx ? 1 : 0));
        sfx = true;
        idle.Play();
        hit.Play();
    }
    public void play_off()
    {
        sfx = false;
        PlayerPrefs.SetInt("Sfx", (sfx ? 1 : 0));
        sfx = false;
        idle.Pause();
        hit.Pause();
    }
}
