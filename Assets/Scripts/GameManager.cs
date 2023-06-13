using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] int player_hp = 1;
    [SerializeField] GameObject canvas;
    string scean_name;
    GameObject stage_name;
    GameObject time;
    GameObject score_text;
    private float timer;
    public static float score;
    public static float score_before;


    private void Start()
    {
        stage_name = GameObject.Find("StageName");
        time = GameObject.Find ("Time");
        score_text = GameObject.Find("Score");
        timer = 0;

        score = 3000 + score_before;
    }
    // Update is called once per frame
    void Update()
    {

        Text stage_name_text = stage_name.GetComponent<Text>();
        stage_name_text.text = SceneManager.GetActiveScene().name;

        Text time_text = time.GetComponent<Text>();
        timer += Time.deltaTime;
        string timer_str = timer.ToString("f2");
        time_text.text = "Time:" + timer_str;

        if (Input.GetButtonDown("Reset")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        Text score_text_text = score_text.GetComponent<Text>();
        score_text_text.text = score.ToString();

    }

    public void EnemyHit(int damage)
    {
        player_hp -= damage;

        if(player_hp <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("GameOver");
        }
    }

    public void ScoreDown()
    {
        score = score - 100;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            score_before = score;
        }
    }
}
