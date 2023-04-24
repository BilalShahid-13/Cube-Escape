using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class complete_level : MonoBehaviour
{
    public void lvl(string lvl)
    {
        SceneManager.LoadScene(lvl);
    }
    public void Back()
    {
        SceneManager.LoadScene("game");
    }
    public void level_restart(string lvl)
    {
        PlayerPrefs.SetString("level_restart", lvl);
    }
}
