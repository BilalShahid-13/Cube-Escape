using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_loader : MonoBehaviour
{
    int lvl_count;
    //[SerializeField] GameObject lvl1, lvl2;
    // Start is called before the first frame update
    private void Awake()
    {
        //lvl_count = PlayerPrefs.GetInt("lvl_load");
    }
    void Start()
    {
        if( lvl_count == 1 )
            SceneManager.LoadScene("lvl1");
        else if( lvl_count == 2 )
            SceneManager.LoadScene("lvl2");
    }
}
