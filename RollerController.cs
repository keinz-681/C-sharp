using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()//開始時にi度だけ実行される
    {
        
    }

    void Update()//すべてのコードが一往復したときに再び実行される
    {
        if(Input.GetMouseButtonDown(0))//マウスが下がった時
        {
            this.rotSpeed = 10;//これの回転角度を10と指定
        }  
        transform.Rotate(0,0,this.rotSpeed);//1度実行される毎に10°回転
    }
}
