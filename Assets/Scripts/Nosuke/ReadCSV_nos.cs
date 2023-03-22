using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ReadCSV_nos : MonoBehaviour
{
    TextAsset csvFile; // CSVファイル
    List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト;
    int height = 0;
    int i = 1;
    public EnemyData_nos data;
    private void Awake()
    {
        csvFile = Resources.Load("CSVs/test2") as TextAsset; // Resouces下のCSV読み込み
        StringReader reader = new StringReader(csvFile.text);
        // , で分割しつつ一行ずつ読み込み
        // リストに追加していく
        while (reader.Peek() != -1) // reader.Peaekが-1になるまで
        {
            string line = reader.ReadLine(); // 一行ずつ読み込み
            csvDatas.Add(line.Split(',')); // , 区切りでリストに追加
            height++; // 行数加算
        }
        i = Random.Range(1, 6);
        data.enemyID = int.Parse(csvDatas[i][0]);
        data.enemyName = csvDatas[i][1];
        data.atk = int.Parse(csvDatas[i][2]);
        data.hp = int.Parse(csvDatas[i][3]);
        
        // csvDatas[行][列]を指定して値を自由に取り出せる
        
    }
}