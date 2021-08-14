using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositionText : MonoBehaviour
{
    float m_X; 
    float m_Y;
    float m_Z;

    public GameObject Katana;    
    //public int posi = 0;

    void Start()
    {

    }
    void Update()
    {
        //Text position = Katana.GetComponent<Text>();
        m_X = Katana.transform.position.x;
        m_Y = Katana.transform.position.y;
        m_Z = Katana.transform.position.z;
        //テキスト表示
        this.GetComponent<Text> ().text ="x座標は" + m_X.ToString() +  "\nY座標は" + m_Y.ToString() +  "\nZ座標は" + m_Z.ToString();

    }
}
