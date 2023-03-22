using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ReadCSV_nos : MonoBehaviour
{
    TextAsset csvFile; // CSV�t�@�C��
    List<string[]> csvDatas = new List<string[]>(); // CSV�̒��g�����郊�X�g;
    int height = 0;
    int i = 1;
    public EnemyData_nos data;
    private void Awake()
    {
        csvFile = Resources.Load("CSVs/test2") as TextAsset; // Resouces����CSV�ǂݍ���
        StringReader reader = new StringReader(csvFile.text);
        // , �ŕ�������s���ǂݍ���
        // ���X�g�ɒǉ����Ă���
        while (reader.Peek() != -1) // reader.Peaek��-1�ɂȂ�܂�
        {
            string line = reader.ReadLine(); // ��s���ǂݍ���
            csvDatas.Add(line.Split(',')); // , ��؂�Ń��X�g�ɒǉ�
            height++; // �s�����Z
        }
        i = Random.Range(1, 6);
        data.enemyID = int.Parse(csvDatas[i][0]);
        data.enemyName = csvDatas[i][1];
        data.atk = int.Parse(csvDatas[i][2]);
        data.hp = int.Parse(csvDatas[i][3]);
        
        // csvDatas[�s][��]���w�肵�Ēl�����R�Ɏ��o����
        
    }
}