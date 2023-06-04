using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private bool firstPush_next = false;
    private bool firstPush_exit = false;
    private string now_stage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Goal");
        }
    }

    public void Next()
    {
        if (!firstPush_next)
        {
            now_stage = StartLostKattle.sceen_name;
            now_stage = now_stage.Replace("stage", "");

            string next_stage = "stage" + (int.Parse(now_stage) + 1).ToString();

            SceneManager.LoadScene(next_stage);
            
            

        }
    }
    public void Finish()
    {
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
