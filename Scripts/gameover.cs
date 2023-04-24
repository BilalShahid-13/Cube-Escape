using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public Text highscore;

    private void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
    }
   
    public void Restart ()
    {
        if (PlayerPrefs.GetString("level_restart") == "lvl1")
        {
            SceneManager.LoadScene("lvl1");
        }    
        else if(PlayerPrefs.GetString("level_restart") == "lvl2")
        {
            SceneManager.LoadScene("lvl2");
        }  
        else if (PlayerPrefs.GetString("level_restart") == "lvl3")
        {
            SceneManager.LoadScene("lvl3");
        }    
        else if (PlayerPrefs.GetString("level_restart") == "lvl4")
        {
            SceneManager.LoadScene("lvl4");
        }

    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    
}
