using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScore : MonoBehaviour
{
    GameObject goal_score;
    private string now_stage;

    // Start is called before the first frame update
    void Start()
    {
        goal_score = GameObject.Find("GoalScore");
        Text goal_score_text = goal_score.GetComponent<Text>();

        now_stage = StartLostKattle.sceen_name;

        if (now_stage == "stage3")
        {
            goal_score_text.text = "ClearScore:" + GameManager.score_before.ToString();
        }
        else
        {
            goal_score_text.text = "Score:" + GameManager.score_before.ToString();
        }
        
    }

}
