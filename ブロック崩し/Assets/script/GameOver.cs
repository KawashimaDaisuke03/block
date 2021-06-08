using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text gameOverMessage;
    //ゲームオーバーしたかどうかを判断するための変数
    bool isGameOver = false;
    // Start is called before the first frame update

    public void Update()
    {
        //  ゲームオーバーかつSubmitボタンを押したら実行する
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            // playシーンをロードする
            SceneManager.LoadScene("Play");
        }
    }
    //衝突時に呼ばれる
    public void OnCollisionEnter(Collision collision)
    {
        //Game Overと表示する
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
        //isGameOverをtrueにする(フラグを立てる)
        isGameOver = true;
    }
}
