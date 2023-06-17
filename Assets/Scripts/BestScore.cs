using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    GameObject bestScore;
    // Start is called before the first frame update
    void Start()
    {
        bestScore = GameObject.Find("BestScore");

        Text bestScore_text = bestScore.GetComponent<Text>();

        bestScore_text.text = "Best Score:" + Goal.best_score.ToString();
    }

    
}
