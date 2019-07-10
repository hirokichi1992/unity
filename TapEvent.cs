using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapEvent : MonoBehaviour
{
    public GameObject obake;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    //オブジェクトを拡大する(0.1f)
    public void OnClickTapEvent()
    {
        // アタッチされているオブジェクトのサイズを 0.1f 拡大する
        this.transform.localScale = this.transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
        // クリックログ
        Debug.Log("クリックしました！");
    }


    //オブジェクトを拡大する(0.2f)
    public void OnClickTapEvent2()
    {
        // アタッチされているオブジェクトのサイズを 0.2f 拡大する
        this.transform.localScale = this.transform.localScale + new Vector3(0.2f, 0.2f, 0.2f);
        // クリックログ
        Debug.Log("クリックしました！");
    }


    //オブジェクトを削除する
    public void Dissapear()
    {
        Destroy(gameObject);
        Debug.Log("削除しました！");
    }


    //オブジェクトを変更する
    public void ChangeObject()
    {
        Destroy(gameObject);
        Debug.Log("オブジェクトを変更しました！");
        GameObject ob = Instantiate(obake) as GameObject;
        int px = Random.Range(-1, 1);
        int py = Random.Range(-1, 1);
        int pz = Random.Range(1, 5);
        ob.transform.position = new Vector3(px, py, pz);

    }

    public void UseGravity()
    {
        rb.useGravity = true;
        Debug.Log("重力を追加しました！");

    }

    //シーンを変更する
    public void ChangeScene()
    {
        // 「Click」シーンに遷移する
        SceneManager.LoadScene("Click");
    }







}