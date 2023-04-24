//using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

[System.Serializable]
struct movement
{
    public Rigidbody rb;
    public float force, left_right;
    public bool isclick_left, isclick_right;
    public GameObject lvlcompleteUI, touch_button,lvl1;

}
public class playermovement : MonoBehaviour
{
    public bool pos;
   [SerializeField] movement m1 = new movement();

    private void Awake()
    {
       // m1.player_clone = m1.player;
    }
    void FixedUpdate()
    {
            m1.rb.AddForce(0, 0, m1.force * Time.deltaTime, ForceMode.VelocityChange); 
        if (m1.isclick_left == true)
            Left();
        else if (m1.isclick_right == true)
            Right();   
    }

    public void Left()
    {
        m1.rb.AddForce(-m1.left_right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void Right()
    {
        m1.rb.AddForce(m1.left_right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void Pointer_Left_Down()
    {
        m1.isclick_left = true;
    }

    public void Pointer_Left_Up()
    {
        m1.isclick_left= false;
    }

    public void Pointer_Right_Down()
    {
        m1.isclick_right = true;
    }

    public void Pointer_Right_Up()
    {
        m1.isclick_right = false;
    }
}
