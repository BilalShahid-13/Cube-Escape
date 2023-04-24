using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("Loading", 3f); 
    }

   void Loading()
    {
        SceneManager.LoadScene("Menu");
    }
}
