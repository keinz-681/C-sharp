using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//追加コンテンツ

public class ScoreManager : MonoBehaviour
{
    public GameObject score_object = null;//テキストオブジェクト
    public int score_num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text> ();

        score_text.text = "Score:" + score_num;

        score_num += 1;
    }
}
