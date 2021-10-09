using UnityEngine;
using UnityEngine.SceneManagement;
public class Pulic変数 : MonoBehaviour{
    public string 対象Scene;
    public void Onclick(){
        SceneManager.LoadScene(対象Scene);
    }
}