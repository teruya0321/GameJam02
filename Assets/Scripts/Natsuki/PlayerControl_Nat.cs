using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl_Nat : MonoBehaviour
{
    Vector3 moving;
    public float _speed;//�v���C���[�̈ړ��X�s�[�h
    Rigidbody rb;
    public Vector3 movingVelocity;
    Vector3 roteuler;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        roteuler = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);//���_�ړ��̓z�ł�
    }
    void Update()
    {
        var velocity = Vector3.zero;//�v���C���[�̈ړ��@���ɂ������̂Ő\����Ȃ��ł��B
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

        float mouseInputX = Input.GetAxis("Mouse X");//���̎��_�ړ�

        roteuler = new Vector3(0, roteuler.y + mouseInputX * -1, 0f);
        transform.localEulerAngles = roteuler;
    }
}
