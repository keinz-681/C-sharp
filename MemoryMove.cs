using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryMove : MonoBehaviour
{
    float rotSpeed =0;
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 12;
        }  
        transform.Rotate(0, this.rotSpeed, 0);

        if(Input.GetKey(KeyCode.O))
        {
            this.rotSpeed = 0.7f;
        }  
        transform.Rotate(0, 0, 0);
    }
}
