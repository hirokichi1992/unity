using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour
{

    //Prefabを入れる変数
    public GameObject obake;
    //時間を入れる変数
    private float time = 2;

    void Start()
    {
        //time秒後に出現させる
        Invoke("Create", time);
    }

    void Create()
    {
        // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
        GameObject ob = Instantiate(obake) as GameObject;
        // おばけを配置する(座標)
        ob.transform.position = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(2f, 10f));
        // おばけを配置する(角度)
        ob.transform.Rotate(new Vector3(0f, 1f, 0f), 180f);
        // おばけを配置する(大きさ)
        ob.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }



}