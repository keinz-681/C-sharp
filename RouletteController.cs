using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }  
        transform.Rotate(this.rotSpeed, 0, 0);

        if(Input.GetKey(KeyCode.O))
        {
            this.rotSpeed = 0.7f;
        }  
        transform.Rotate(0, 0, 0);
    }
}
