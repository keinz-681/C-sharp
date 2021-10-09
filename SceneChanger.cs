using UnityEngine;
using UnityEngine.SceneManagement;//シーン切り替えに必要。
public class Pulic変数 : MonoBehaviour{
    public string 対象Scene;//インスペクターで切り替えるシーンを入力。
    public void Onclick(){
        SceneManager.LoadScene(対象Scene);//ボタンをクリックした時にシーンを切り替える。
    }
}
