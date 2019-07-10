using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Button))]
public class GotoTitle : UIBehaviour
{
    protected override void Start()
    {
        base.Start();

        // Buttonクリック時、OnClickメソッドを呼び出す
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        // 「TitleScene」シーンに遷移する
        SceneManager.LoadScene("TitleScene");
    }
}