using System;
using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

[System.Serializable]
struct col
{
    public playermovement PlayermovementScript;
    public Transform Playeroffset;
    public GameObject TouchButtons,Setting_Ui,lvlcompleteUI;
    public score score_script;
    public bool bol,pos;
    public AudioSource idle,hit;
    public int sfx;
    public GameObject player__, playerclone;
    public int a,trigger_cout;
    public string lvl,lvl_restart;
}
public class collsion : MonoBehaviour
{
    [SerializeField] col col1 = new col();
    public void Awake()
    {
        if (PlayerPrefs.GetInt("Sfx") != 0)
        {
            col1.idle.Play();
        }
        else if (PlayerPrefs.GetInt("Sfx") == 0)
        {
            Debug.Log("On");
            //col1.idle.Pause();
        }
    }
    private void Start()
    {
        col1.bol = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "enemy")
        {
            if (PlayerPrefs.GetInt("Sfx") != 0)
            {
                col1.hit.Play();

            }
            col1.PlayermovementScript.enabled = false;
            col1.TouchButtons.SetActive(false);
            col1.Setting_Ui.SetActive(false);
            Invoke("GameOver_", 0.5f);
            col1.idle.Pause();
        }
        else if (collision.collider.tag == "lvlcomplete")
        {
            col1.PlayermovementScript.enabled = false;
            col1.TouchButtons.SetActive(true);
            col1.lvlcompleteUI.SetActive(true);
            PlayerPrefs.SetInt("Level", 2);
            StartCoroutine(NextLevel(col1.lvl));
        }
        else if(collision.collider.tag == "ground")
        {
            Collision_ground(col1.lvl_restart);
        }
    }
    private void FixedUpdate()
    {
        if (col1.Playeroffset.position.y < -0.3)
        {
            if (col1.bol == true)
            {
                //col1.bol = true;
                col1.PlayermovementScript.enabled = false;
                col1.bol = false;
                col1.TouchButtons.SetActive(false);
                col1.score_script.enabled = false;
                //col1.lvl1.SetActive(false);
                col1.Setting_Ui.SetActive(false);
                Invoke("GameOver_", 0.5f);
            }

        }
    }
    void GameOver_()
    {
        SceneManager.LoadScene("GameOver");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +6);
    }
    IEnumerator NextLevel(string lvl)
    {
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene(lvl);
    }

    public void Collision_ground(string lvl)
    {
        PlayerPrefs.SetString("level_restart",lvl);
    }
}


