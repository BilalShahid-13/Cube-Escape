using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

[System.Serializable]
struct GameUi
{
    public GameObject Setting_Game_UI,On_Screen_highscore,setting_button;
    public TMP_Text HighScore_Setting_Game_UI;
    public bool isfreeze;
}
public class Setting : MonoBehaviour
{
    [SerializeField] GameUi GameUi = new GameUi();
    
    public void Pause_Game()
    {
        GameUi.HighScore_Setting_Game_UI.text = PlayerPrefs.GetFloat("HighScore", 0).ToString();
        GameUi.On_Screen_highscore.SetActive(false);
        GameUi.setting_button.SetActive(false);
        GameUi.Setting_Game_UI.SetActive(true);
        Time.timeScale = 0f;
        GameUi.isfreeze = true;
    }
    public void Resume_Game()
    {
        GameUi.On_Screen_highscore.SetActive(true);
        GameUi.setting_button.SetActive(true);
        GameUi.Setting_Game_UI.SetActive(false);
        Time.timeScale = 1f;
       // GameUi.isfreeze = false;
    }
    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void Restart() 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("Game");
    }
}
