using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private bool firstPush_next = false;
    private bool firstPush_exit = false;
    private string now_stage;
    private string stage_name;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.score_before = GameManager.score;
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

            now_stage = StartLostKattle.sceen_name;

            if(now_stage == "stage3")
            {
                SceneManager.LoadScene("Congratulations");
            }
            else
            {
                SceneManager.LoadScene(next_stage);
            }

            firstPush_next = true;
        }
    }
    public void Finish()
    {
        if(!firstPush_exit)
        {
            SceneManager.LoadScene("TitleScene");

            firstPush_exit = true;
        }
        
    }
}
