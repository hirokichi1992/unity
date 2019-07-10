using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearScript : MonoBehaviour
{
    private void Start()
    {
        //10秒後に消える
        Invoke("Destroy", 10);
    }

    //Invokeで使う
    void Destroy()
    {
        Destroy(gameObject);
    }
}