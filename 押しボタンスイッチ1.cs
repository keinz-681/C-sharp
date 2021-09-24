//スイッチのスクリプトテンプレート
using UnityEngine;//

public class Pushrolling : MonoBehaviour//クラス名は各自変更
{
    GameObject Pen;//オブジェクト名は自由
    GameObject obj;

    void Start()//Unityが始まった時に一度だけ呼び出される関数
    {
        this.Pen = GameObject.Find("Stop");//ボタンを検索、変数に結び付ける。
        this.obj = GameObject.Find("Chack");//動きを停止させたいオブジェクトの検索
    }
    public void Onclick()//クリックした時に呼び出される関数
    {
        this.gameObject.SetActive(false);//変数の無効化(※最初から無効化されているとStartでオブジェクトを見つけることが出来ない。)
        this.Pen.SetActive(true);//変数の有効か
        obj.GetComponent<ChackController>().enabled = true;//スクリプトの有効化(スイッチで制御するスクリプトに使える。)
    }
}

