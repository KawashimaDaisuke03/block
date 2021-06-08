using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //何かと衝突したときに呼ばれるビルドインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
