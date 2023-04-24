using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
struct Cam
{
    public Transform player;
    public Transform camera;
    public Vector3 offset; //0,0.25,-0.97
}
public class camera : MonoBehaviour
{
    [SerializeField] Cam c1 = new Cam();
    private void Update()
    {
        c1.camera.position = c1.player.position + c1.offset;
    }
}
