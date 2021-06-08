using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //Textコンポーネントを使用する場合に必要
 
public class ResetText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //アクセスは一回きりなので、フィールド変数を用意しなくていい
        Text myText = GetComponent<Text>();
        //textに空の文字列を設定する
        myText.text = "";
    }
}
