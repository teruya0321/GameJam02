using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float minangle;
    public float maxangle;

    PlayerControl_Nat playerControl_Nat;

    private void Start()
    {
        //GameObject  = GameObject.Find("Player"); //Player���Ă����I�u�W�F�N�g��T��
        playerControl_Nat = GetComponent<PlayerControl_Nat>(); //�t���Ă���X�N���v�g���擾
    }

    public void Shot(Vector3 dir)
    {
        //�Y�����ɂ����ɍ��ށ@�����limit�ɍ��킹�Ēe�̂΂炯��ݒ肵�悤�Ƃ��Ă���
        //if (limit == 0)




        GetComponent<Rigidbody>().AddForce(dir);
        Vector3 vel = new Vector3(Random.Range(minangle, maxangle), Random.Range(minangle, maxangle), Random.Range(minangle, maxangle));
        GetComponent<Rigidbody>().velocity = vel;

    }
}
