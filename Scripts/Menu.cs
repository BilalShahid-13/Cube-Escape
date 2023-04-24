using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
struct GameUI
{
    public GameObject player, highscore,touchbuttons;
}
public class Menu : MonoBehaviour
{
    [SerializeField] GameUI gameUI = new GameUI();
    public void Start_()
    {
        Invoke("invoke_start", 0.5f);
    }

    public void invoke_start()
    {
        gameUI.player.SetActive(true);
        gameUI.highscore.SetActive(true);  
    }

    public void Quit()
    {
        Application.Quit();
    }
}
