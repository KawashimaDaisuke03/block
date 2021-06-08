using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    Rigidbody myRigidbody;

    void Start()
    {
        //Rigidbodyにアクセスして変数に保持
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //左右キーの入力で速度を変更。
        myRigidbody.velocity = new
        Vector3(Input.GetAxis("Horizontal") * speed, 0f, 0f);
    }
}
