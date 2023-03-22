using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Nat : MonoBehaviour
{
    Vector3 moving;
    public float _speed;//プレイヤーの移動スピード
    Rigidbody rb;
    public Vector3 movingVelocity;
    Vector3 roteuler;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        roteuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);//視点移動の奴です
    }
    void Update()
    {
        var velocity = Vector3.zero;//プレイヤーの移動　見にくいもので申し訳ないです。
        if (Input.GetKey(KeyCode.W))
        {
            velocity.z = _speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x = -_speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z = -_speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x = _speed;
        }
        if (velocity.x != 0 || velocity.z != 0)
        {
           transform.position += transform.rotation * velocity;
        }

        float mouseInputX = Input.GetAxis("Mouse X");//横の視点移動

        roteuler = new Vector3(0, roteuler.y + mouseInputX * -1, 0f);
        transform.localEulerAngles = roteuler;
    }
}
