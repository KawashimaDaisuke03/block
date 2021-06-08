using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    //速さの最小値を指定する変数を追加
    public float minSpeed = 5f;
    //速さの最大値を指定する変数を追加
    public float maxSpeed = 10f;
    Rigidbody myRigidbody;
    //Transformコンポーネントを保持しておくための変数を追加
    Transform myTransform;
    void Start()
    {
        //RigidBodyにアクセスして変数に保持しておく。
        myRigidbody = GetComponent<Rigidbody>();
        //斜め45度に進む。
        myRigidbody.velocity = new Vector3(speed, speed, 0f);
        //Transformコンポーネントを取得して保持
        myTransform = transform;
    }
    //毎フレーム速度をチェックする
    private void Update()
    {
        //現在のフレーム速度を取得
        Vector3 velocity = myRigidbody.velocity;
        //速さを計算
        float clampedSpeed = Mathf.Clamp(velocity.magnitude, minSpeed, maxSpeed);
        //速度を変更
        myRigidbody.velocity = velocity.normalized * clampedSpeed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //プレイヤーに衝突時、跳ね返る方向を変える
        if (collision.gameObject.CompareTag("Player"))
        {
            //プレイヤーの位置を取得
            Vector3 playerPos = collision.transform.position;
            //ボールの位置を取得
            Vector3 ballsPos = myTransform.position;
            //プレイヤーから見たボールの方向を計算
            Vector3 direction = (ballsPos - playerPos).normalized;
            //現在の速さを取得
            float speed = myRigidbody.velocity.magnitude;
            //速度を変更
            myRigidbody.velocity = direction * speed;
        }
    }
}