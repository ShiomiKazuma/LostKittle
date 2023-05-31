using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    private bool firstPush_start = false;
    private bool firstPush_exit = false;
    //startボタンが押された時の処理
    public void PressStart()
    {
        Debug.Log("スタートボタンがおされました");

        if (!firstPush_start)
        {

            //次のシーンに行く処理
            SceneManager.LoadScene("stage1");
            firstPush_start = true;
        }
    }

    //exitボタンが押された時の処理
    public void PressExit()
    {
        Debug.Log("exitボタンが押されました");
        if (!firstPush_exit)
        {
            Debug.Log("ゲームが終了しました");
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
                Application.Quit();//ゲームプレイ終了
#endif
            firstPush_exit = true;
        }
    }
}
