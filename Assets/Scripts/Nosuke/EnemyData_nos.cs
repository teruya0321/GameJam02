using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData_nos : MonoBehaviour
{
    public int enemyID;
    public string enemyName;
    public int atk;
    public int hp;
    void Start()
    {
        Debug.Log("�GID" + enemyID);
        Debug.Log("���O" + enemyName);
        Debug.Log("�U����" + atk);
        Debug.Log("�̗�" + hp);
    }
}
